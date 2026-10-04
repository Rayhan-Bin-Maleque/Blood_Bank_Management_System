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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace firstpract
{
    public partial class BloodStock : Form
    {
        public BloodStock()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            textBox4.Text = "       Auto Genarated";
            textBoxDonerID.Text = "   Auto Genarated";
            textBox2.Clear();

            radioButton1.Checked = radioButton2.Checked = false;
            radioButtonAvailable.Checked = radioButtonUnavailable.Checked = false;
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BloodStock_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                var query = "select * from BloodStock ";
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                var query = "select * from BloodStock ";
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
            var Stockid = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox4.Text = Stockid;
            var DonerID = this.dataGridView1.Rows[e.RowIndex].Cells["DonerID"].Value.ToString();
            textBoxDonerID.Text = DonerID;


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
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            if (gender == "Male")
            {
                radioButton1.Checked = true;
            }
            else if (gender == "Female")
            {
                radioButton2.Checked = true;
            }

            var Statues = this.dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString().Trim();
            radioButtonAvailable.Checked = false;
            radioButtonUnavailable.Checked = false;
            if (Statues == "Available")
            {
                radioButtonAvailable.Checked = true;
            }
            else if (Statues == "Unavailable")
            {
                radioButtonUnavailable.Checked = true;

            }


            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            // SQL Query string - FIXED: This now correctly checks ID, Password, and Role in the database
            var query = "SELECT COUNT(Status) FROM BloodStock WHERE Status = 'Available'";

            // Data Adapter and Dataset to fetch data
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            // Check if the table exists and has rows
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Access the count from the first row and first column [0][0]
                // Convert it to double as you requested in your variable type
                double count = Convert.ToDouble(ds.Tables[0].Rows[0][0]);

                // Example: Display the result in a label or textbox
                textBox2.Text = count.ToString();
            }
            else
            {
                // Handle the case where no data was returned
                return;
            }

            con.Close();



        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DonorManager from = new DonorManager();
            from.Show();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            DonorRegForm from = new DonorRegForm();
            from.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DonorManager from = new DonorManager();
            from.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;TrustServerCertificate=True");

            try
            {
                con.Open();

                // 1. Fetch the current status
                string checkQuery = "SELECT Status FROM BloodStock WHERE StockID = " + textBox4.Text;
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                object result = checkCmd.ExecuteScalar();

                if (result != null)
                {
                    // Use Trim() to remove spaces and ToLower() for a safe comparison
                    string currentStatus = result.ToString().Trim();

                    // 2. THE TOGGLE: This handles BOTH cases automatically
                    // If it's Available -> becomes Unavailable
                    // If it's Unavailable -> becomes Available
                    string newStatus = (currentStatus == "Available") ? "Unavailable" : "Available";

                    // 3. Update the database with the new toggled status
                    string updateQuery = "UPDATE BloodStock SET Status = '" + newStatus + "' WHERE StockID = " + textBox4.Text;
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Success! Status changed from " + currentStatus + " to " + newStatus);

                        // Refresh UI
                        this.ResetForm();
                        button2_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Stock ID not found in the database.");
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
