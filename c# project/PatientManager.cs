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
    public partial class PatientManager : Form
    {
        public PatientManager()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            textBoxx1.Text = "Auto Generated";
            textBox2.Clear();
            textBox1.Clear();
            textBox4.Clear();
            textBoxx7.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "";
        }

        private void textBoxx1_TextChanged(object sender, EventArgs e)
        {
        }

        private void PatientManager_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                var query = "select * from Patient ";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Refresh();
                this.dataGridView1.ClearSelection();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                var query = "select * from Patient ";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Refresh();
                this.dataGridView1.ClearSelection();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            this.ResetForm();
            var id = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxx1.Text = id;
            var Fullname = this.dataGridView1.Rows[e.RowIndex].Cells["Fullname"].Value.ToString();
            textBox1.Text = Fullname;
            var Password = this.dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            textBox4.Text = Password;

            var BloodGroup = this.dataGridView1.Rows[e.RowIndex].Cells["BloodGroup"].Value.ToString();
            if (!string.IsNullOrEmpty(BloodGroup))
            {
                int index = comboBox1.FindStringExact(BloodGroup);
                if (index != -1)
                {
                    comboBox1.SelectedIndex = index;
                }
                else
                {
                    comboBox1.Text = BloodGroup;
                }
            }

            var gender = this.dataGridView1.Rows[e.RowIndex].Cells["gender"].Value.ToString().Trim();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            if (gender == "Male")
            {
                checkBox1.Checked = true;
            }
            else if (gender == "Female")
            {
                checkBox2.Checked = true;
            }

            var ContactNumber = this.dataGridView1.Rows[e.RowIndex].Cells["Contactnumber"].Value.ToString();
            textBox2.Text = ContactNumber;
            var Address = this.dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
            textBoxx7.Text = Address;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Fullname = textBox1.Text;
            var password = textBox4.Text;
            var contactnumber = textBox2.Text;
            var address = textBoxx7.Text;
            string Role = "Patient";
            string Status = "Pending";
            string gender = checkBox1.Checked ? "Male" : "Female";

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Error: Please select a Blood Group from the list.");
                return;
            }
            var BloodGroup = comboBox1.SelectedItem.ToString();

            if (string.IsNullOrEmpty(Fullname) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(contactnumber))
            {
                MessageBox.Show("Error: Name, Password, and Contact Number are required!");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;TrustServerCertificate=True");

            try
            {
                con.Open();

                // FIXED: Added .Trim() to ensure "Auto Genarated" matches even with extra spaces
                string idText = textBoxx1.Text.Trim();
                bool isNewRecord = (idText == "Auto Genarated" || string.IsNullOrEmpty(idText));

                var query = isNewRecord ?
                    "INSERT INTO Patient (FullName, ContactNumber, Address, Gender, BloodGroup, Password,Status) VALUES ('" + Fullname + "', '" + contactnumber + "', '" + address + "', '" + gender + "', '" + BloodGroup + "', '" + password + "', '" + Status + "')" :
                    "UPDATE Patient SET FullName = '" + Fullname + "', ContactNumber = '" + contactnumber + "', Address = '" + address + "', Gender = '" + gender + "', BloodGroup = '" + BloodGroup + "', Password = '" + password + "' WHERE paitentID = " + idText; // Removed single quotes for INT ID

                SqlCommand cmd = new SqlCommand(query, con);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    if (isNewRecord)
                    {
                        string loginQuery = "insert into Login (Password, Role,Fullname,address,Contactnumber) values ('" + password + "','" + Role + "','" + Fullname + "','" + address + "','" + contactnumber + "')";
                        new SqlCommand(loginQuery, con).ExecuteNonQuery();

                        // --- ADDED PART START ---
                        string retrieveLoginIdQuery = "SELECT ID FROM Login WHERE Password = '" + password + "' AND Role = '" + Role + "' AND Fullname = '" + Fullname + "' AND address = '" + address + "' AND Contactnumber = '" + contactnumber + "'";
                        SqlDataAdapter adpLogin = new SqlDataAdapter(retrieveLoginIdQuery, con);
                        DataTable dtLogin = new DataTable();
                        dtLogin.Clear();
                        adpLogin.Fill(dtLogin);

                        if (dtLogin.Rows.Count > 0)
                        {
                            string dbLoginId = dtLogin.Rows[0]["ID"].ToString();
                            MessageBox.Show("Registration Successful!\n" + "Your Login ID is: " + dbLoginId + "\nYou can now login with this ID.");
                        }
                        // --- ADDED PART END ---

                        string retrieveIdQuery = "SELECT paitentID FROM Patient WHERE FullName = '" + Fullname + "' AND ContactNumber = '" + contactnumber + "'";
                        SqlDataAdapter adp = new SqlDataAdapter(retrieveIdQuery, con);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            string dbPatientId = dt.Rows[0]["paitentID"].ToString();
                            string transferStatus = "Pending";

                            string bloodTransferQuery = "INSERT INTO BloodTransfer (patientID, BloodGroup, Gender, Status) VALUES (" + dbPatientId + ", '" + BloodGroup + "', '" + gender + "', '" + transferStatus + "')";
                            new SqlCommand(bloodTransferQuery, con).ExecuteNonQuery();

                            MessageBox.Show("Registration Successful!\nPatient ID: " + dbPatientId + "\nTransfer Record Created.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Patient Updated Successfully!");
                    }

                    this.ResetForm();
                    this.button2_Click(sender, e);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxx1.Text) || textBoxx1.Text.Trim() == "    Auto Genarated" || textBoxx1.Text.Trim() == "Auto Genarated")
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
                    string query = "DELETE FROM Patient WHERE paitentID = " + textBoxx1.Text;

                    SqlCommand cmd = new SqlCommand(query, con);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Deleted Successfully!");
                        this.ResetForm();
                        this.button2_Click(sender, e);
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
    }
}