using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstpract
{
    public partial class DonorRegForm : Form
    {
        public DonorRegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Fullname = textBoxx2.Text;
            var password = textBox1.Text;
            var contactnumber = textBoxx4.Text;
            var address = textBoxx7.Text;
            string gender = checkBox1.Checked ? "Male" : "Female";
            string Doner = "Doner";
            string Status = "Donation pending";

            // 1. Validation Logic
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Error Blood Group is required");
                return;
            }
            var BloodGroup = comboBox1.SelectedItem.ToString();

            if (string.IsNullOrEmpty(Fullname) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(contactnumber))
            {
                MessageBox.Show("Error: All fields (Name, Password, Contact) are required!");
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;TrustServerCertificate=True");

            try
            {
                con.Open();

                // 2. Insert into Doner table
                var query = "insert into Doner (Fullname, Contactnumber, address, gender, BloodGroup, Password,Status) values ( '" + Fullname + "', '" + contactnumber + "', '" + address + "', '" + gender + "', '" + BloodGroup + "', '" + password + "', '" + Status + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // 3. Insert into Login table
                    string loginQuery = "insert into Login (Password, Role,Fullname,address,Contactnumber) values ('" + password + "','" + Doner + "','" + Fullname + "','" + address + "','" + contactnumber + "')";
                    SqlCommand loginCmd = new SqlCommand(loginQuery, con);
                    loginCmd.ExecuteNonQuery();

                    // 4. Retrieve the Login ID for the user
                    string retrieveIdQuery =  "SELECT ID FROM Login WHERE Password = '" + password + "' AND Role = '" + Doner + "' AND Fullname = '" + Fullname + "' AND address = '" + address + "' AND Contactnumber = '" + contactnumber + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(retrieveIdQuery, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        string dbLoginId = dt.Rows[0]["ID"].ToString();
                        MessageBox.Show("Registration Successful!\n" + "Your ID is: " + dbLoginId + "\nYou can now login with this ID.");
                    }

                    // --- ADDED PART: BLOOD STOCK ENTRY ---
                    // 5. Retrieve the newly created DonerID to link with BloodStock
                    string retrieveDonerQuery = "SELECT DonerID FROM Doner WHERE FullName = '" + Fullname + "' AND ContactNumber = '" + contactnumber + "' AND Password = '" + password + "'";
                    SqlDataAdapter adpDoner = new SqlDataAdapter(retrieveDonerQuery, con);
                    DataTable dtDoner = new DataTable();
                    adpDoner.Fill(dtDoner);

                    if (dtDoner.Rows.Count > 0)
                    {
                        string Status2 = "Donation pending";
                        string dbDonerId = dtDoner.Rows[0]["DonerID"].ToString();
                        string BloodStockEntry = "insert into BloodStock (DonerID, BloodGroup, gender, Status) values ('" + dbDonerId + "','" + BloodGroup + "','" + gender + "','" + Status2 + "')";
                        new SqlCommand(BloodStockEntry, con).ExecuteNonQuery();
                    }
                    // --------------------------------------

                    // Clear textboxes
                    textBoxx2.Clear();
                    textBoxx4.Clear();
                    textBoxx7.Clear();
                    textBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void DonorRegForm_Load(object sender, EventArgs e)
        {

        }
    }
}

