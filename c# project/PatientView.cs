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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace c__project
{
    public partial class PatientView : Form
    {
        string loggedInId;
        public PatientView(string id, string pass, string name, string addr, string dbContact)
        {
            InitializeComponent();
            
            textBoxx1.Text = id;
            textBox1.Text = pass;
            textBoxx2.Text = name;
            textBoxx7.Text = addr;
            textBoxx4.Text = dbContact;

        }

        private void PatientView_Load(object sender, EventArgs e)
        {
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

                    // 1. Query to load specific fields from the Login table
                    string query = "SELECT ID, Fullname, Password, Contactnumber, address FROM Login WHERE ID = '" + loggedInId + "'";

                    string nameForSearch = "";
                    string phoneForSearch = "";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assign values to textboxes
                                textBoxx1.Text = reader["ID"].ToString();
                                textBoxx2.Text = reader["Fullname"].ToString();
                                textBox1.Text = reader["Password"].ToString();
                                textBoxx4.Text = reader["Contactnumber"].ToString();
                                textBoxx7.Text = reader["address"].ToString();

                                // Store values needed for the next query
                                nameForSearch = reader["Fullname"].ToString();
                                phoneForSearch = reader["Contactnumber"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("User not found in Login table.");
                                return; // Exit if no user found
                            }
                        } // reader closes automatically here
                    }

                    // 2. Second Query: Get Status from Patient table 
                    // Fixed the string concatenation and added the closing single quote
                    string query2 = "SELECT Status FROM Patient WHERE Fullname = '" + nameForSearch.Trim() + "' " +
                                    "AND contactnumber = '" + phoneForSearch.Trim() + "'";

                    using (SqlCommand cmd2 = new SqlCommand(query2, con))
                    {
                        using (SqlDataReader reader2 = cmd2.ExecuteReader())
                        {
                            if (reader2.Read())
                            {
                                label4.Text = reader2["Status"].ToString();
                            }
                            else
                            {
                                label4.Text = "No Status Found";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
    }
}
