using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstpract
{
    public partial class DonorManager : Form
    {
        public DonorManager()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            // 1. Reset ID field
            textBoxx1.Text = "Auto Generated";

            // 2. Clear all textboxes
            textBox2.Clear();
            textBox1.Clear();
            textBox4.Clear();
            textBoxx7.Clear();

            // 3. Uncheck all gender options
            checkBox1.Checked = false;
            checkBox2.Checked = false;

            // 4. Reset ComboBox
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "";
        }

        private void DonorManager_Load(object sender, EventArgs e)
        {
            buttonLoad_Click(sender, e);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();

                var query = "select * from Doner";

                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                this.dataGridViewDoner.DataSource = dt;
                this.dataGridViewDoner.Refresh();
                this.dataGridViewDoner.ClearSelection();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewDoner_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            this.ResetForm();

            var id = this.dataGridViewDoner.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxx1.Text = id;

            var Fullname = this.dataGridViewDoner.Rows[e.RowIndex].Cells["Fullname"].Value.ToString();
            textBox1.Text = Fullname;

            var Password = this.dataGridViewDoner.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            textBox4.Text = Password;

            var BloodGroup = this.dataGridViewDoner.Rows[e.RowIndex].Cells["BloodGroup"].Value.ToString();
            if (!string.IsNullOrEmpty(BloodGroup))
            {
                int index = comboBox1.FindStringExact(BloodGroup.Trim());
                if (index != -1)
                {
                    comboBox1.SelectedIndex = index;
                }
                else
                {
                    comboBox1.Text = BloodGroup;
                }
            }

            var gender = this.dataGridViewDoner.Rows[e.RowIndex].Cells["gender"].Value?.ToString().Trim();
            checkBox1.Checked = (gender == "Male");
            checkBox2.Checked = (gender == "Female");

            var ContactNumber = this.dataGridViewDoner.Rows[e.RowIndex].Cells["Contactnumber"].Value.ToString();
            textBox2.Text = ContactNumber;

            var Address = this.dataGridViewDoner.Rows[e.RowIndex].Cells["address"].Value.ToString();
            textBoxx7.Text = Address;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void buttonADDDD_Click(object sender, EventArgs e)
        {
            var Fullname = textBox1.Text;
            var password = textBox4.Text;
            var contactnumber = textBox2.Text;
            var address = textBoxx7.Text;
            string Doner = "Doner";
            string Status = "Donation Recived";
            string gender = checkBox1.Checked ? "Male" : "Female";

            // FIX 1: Safety Check for ComboBox
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Error: Please select a Blood Group.");
                return;
            }
            var BloodGroup = comboBox1.SelectedItem.ToString();

            // Standard Validation
            if (string.IsNullOrEmpty(Fullname) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(contactnumber))
            {
                MessageBox.Show("Error: All fields are required!");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;TrustServerCertificate=True");

            try
            {
                con.Open();

                // Check if it is a new record
                string idText = textBoxx1.Text.Trim();
                bool isNewRecord = (idText == "Auto Genarated" || idText == "Auto Generated" || string.IsNullOrEmpty(idText));

                // Define main query (Insert or Update)
                var query = isNewRecord ?
                    "INSERT INTO Doner (FullName, contactnumber, Address, Gender, BloodGroup, Password,Status) VALUES ('" + Fullname + "', '" + contactnumber + "', '" + address + "', '" + gender + "', '" + BloodGroup + "', '" + password + "', '" + Status + "')" :
                    "UPDATE Doner SET FullName = '" + Fullname + "', contactNumber = '" + contactnumber + "', Address = '" + address + "', Gender = '" + gender + "', BloodGroup = '" + BloodGroup + "', Password = '" + password + "' WHERE DonerID = " + idText;

                SqlCommand cmd = new SqlCommand(query, con);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    if (isNewRecord)
                    {
                        // 1. Insert into Login Table
                        string loginQuery = "insert into Login (Password, Role,Fullname,address,Contactnumber) values ('" + password + "','" + Doner + "','" + Fullname + "','" + address + "','" + contactnumber + "')";
                        new SqlCommand(loginQuery, con).ExecuteNonQuery();

                        // 2. Retrieve the auto-generated Login ID (Added part)
                        string loginIdQuery = "SELECT ID FROM Login WHERE Password = '" + password + "' AND Role = '" + Doner + "' AND Fullname = '" + Fullname + "' AND address = '" + address + "' AND Contactnumber = '" + contactnumber + "'";
                        SqlDataAdapter adpLogin = new SqlDataAdapter(loginIdQuery, con);
                        DataTable dtLogin = new DataTable();
                        dtLogin.Clear();
                        adpLogin.Fill(dtLogin);

                        string dbLoginId = "";
                        if (dtLogin.Rows.Count > 0)
                        {
                            dbLoginId = dtLogin.Rows[0]["ID"].ToString();
                        }

                        // 3. Retrieve DonerID to update BloodStock
                        string retrieveDonerQuery = "SELECT DonerID FROM Doner WHERE FullName = '" + Fullname + "' AND ContactNumber = '" + contactnumber + "' AND Password = '" + password + "'";
                        SqlDataAdapter adpDoner = new SqlDataAdapter(retrieveDonerQuery, con);
                        DataTable dtDoner = new DataTable();
                        adpDoner.Fill(dtDoner);

                        if (dtDoner.Rows.Count > 0)
                        {
                            var Status2 = "Available";
                            string dbDonerId = dtDoner.Rows[0]["DonerID"].ToString();
                            string BloodStockEntry = "insert into BloodStock (DonerID, BloodGroup, gender, Status) values ('" + dbDonerId + "','" + BloodGroup + "','" + gender + "','" + Status2 + "')";
                            new SqlCommand(BloodStockEntry, con).ExecuteNonQuery();
                        }

                        // Show Success with the retrieved Login ID
                        MessageBox.Show("Registered Successfully!\nYour Login ID is: " + dbLoginId + "\nYou can now login with this ID.");
                    }
                    else
                    {
                        MessageBox.Show("Updated Successfully!");
                    }

                    this.ResetForm();
                    buttonLoad_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxx1.Text) || textBoxx1.Text.Trim() == "Auto Generated" || textBoxx1.Text.Trim() == "Auto Genarated")
            {
                MessageBox.Show("Please select a valid record from the list to delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;TrustServerCertificate=True");

                try
                {
                    con.Open();
                    // Ensure DonerID matches your database column name exactly
                    string query = "DELETE FROM Doner WHERE DonerID = " + textBoxx1.Text;

                    SqlCommand cmd = new SqlCommand(query, con);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Deleted Successfully!");
                        this.ResetForm();
                        buttonLoad_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error: Record not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Status2 = "Recived";
            string Status3 = "Available";
            // Fixed spelling: Recived -> Received

            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();

                // 1. Fixed Query: 
                // - Wrapped DonerID in single quotes
                // - Added '=' and 'SET' for BloodTransfer
                // - Wrapped TransferID.Text in single quotes
                string query = "UPDATE Doner SET Status = '" + Status2 + "' WHERE DonerID = '" + textBoxx1.Text + "';"+
                                 "UPDATE BloodStock SET Status = '" + Status3 + "' WHERE DonerID = '" + textBoxx1.Text + "';";

                // 2. Create the command
                SqlCommand cmd = new SqlCommand(query, con);

                // 3. Execute the update
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Blood Is Added In Blood Stock .");
                }

                con.Close();

                // 4. Refresh your grids to show the new status
                this.buttonLoad_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
    }
}
