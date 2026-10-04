using firstpract;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace c__project
{
    public partial class DonerView : Form
    {
        string loggedInId;
        public DonerView(string id, string pass, string name, string addr, string dbContact)
        {
            InitializeComponent();

            // Set the text boxes immediately using the passed data
            textBoxx1.Text = id;
            textBox1.Text = pass;
            textBoxx2.Text = name;
            textBoxx7.Text = addr;
            textBoxx4.Text = dbContact;


            // Optional: Show a message to confirm it received data
            // MessageBox.Show("Welcome " + name);
        }

        private void DonerView_Load(object sender, EventArgs e)
        {
            // 3. Automatically load data when the form opens
            LoadUserData();
        }

        private void LoadUserData()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // 1. First Query: Get details from Login table using ID
                    string query1 = "SELECT Password, Fullname, address, Contactnumber FROM Login WHERE ID = '" + loggedInId + "'";


                    using (SqlCommand cmd1 = new SqlCommand(query1, con))
                    {
                        using (SqlDataReader reader1 = cmd1.ExecuteReader())
                        {
                            if (reader1.Read())
                            {
                                // Fill basic info textboxes
                                textBox1.Text = reader1["Password"].ToString();
                                textBoxx2.Text = reader1["Fullname"].ToString();
                                textBoxx7.Text = reader1["address"].ToString();
                                textBoxx4.Text = reader1["Contactnumber"].ToString();

                                // Store these values to search in the doner table
                                string nameForSearch = reader1["Fullname"].ToString();
                                string phoneForSearch = reader1["Contactnumber"].ToString();
                                string password = reader1["Password"].ToString();
                                string Address = reader1["address"].ToString();

                                // We must close the first reader before opening a second one
                                reader1.Close();

                                // 2. Second Query: Get BloodGroup from doner table using the details we just found
                                // Using the "way you gave me" (string concatenation)
                                string query2 = "SELECT DonerID FROM Doner WHERE Fullname = '" + nameForSearch.Trim() + "' " +
                                                                                    "AND contactnumber = '" + phoneForSearch.Trim();

                                using (SqlCommand cmd2 = new SqlCommand(query2, con))
                                {
                                    using (SqlDataReader reader2 = cmd2.ExecuteReader())
                                    {
                                        if (reader2.Read())
                                        {
                                            // Assuming you have a textbox named textBoxBlood for this
                                            textBox2.Text = reader2["BloodGroup"].ToString();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found in Login table.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void DonerView_Load_1(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void DonerView_Load_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Status = "Donation pending";
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;TrustServerCertificate=True");

            try
            {
                con.Open();

                // 1. Fixed the query syntax: Added proper spaces and removed extra semicolons.
                // Table name changed to 'doner' (lowercase) to match your DB results
                string query = "UPDATE doner SET Status = '" + Status + "' " +
                               "WHERE Fullname = '" + textBoxx2.Text.Trim() + "' " +
                               "AND Password = '" + textBox1.Text.Trim() + "' " +
                               "AND contactnumber = '" + textBoxx4.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Status updated successfully to Donation pending!");
                }
                else
                {
                    MessageBox.Show("No record found to update. Please check if Name, Password, and Contact Number match exactly.");
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
    }
}
