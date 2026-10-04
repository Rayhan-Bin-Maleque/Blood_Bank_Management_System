using firstpract;
using Microsoft.Data.SqlClient;
using System.Data;

namespace c__project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            var id = textBox_id.Text;
            var password = textBox_pass.Text;

            // FIX 1: Check if SelectedItem is null BEFORE calling .ToString() to prevent crash
            if (comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Error: Please select a Role.");
                return;
            }
            var Role = comboBoxRole.SelectedItem.ToString();

            // Validation: Check if fields are empty
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Error: ID and Password is required.");
                return;
            }

            // Database Connection
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;TrustServerCertificate=True");

            try
            {
                con.Open();

                // SQL Query: Verifies credentials against the Login table
                var query = "select * from Login where ID='" + id + "' and Password='" + password + "' and Role='" + Role + "'";

                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                // FIX 2: Check if exactly one matching record was found
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 1)
                {
                    // --- UPDATED INDIVIDUAL LOGIC STARTS HERE ---

                    // 1. Check for Administrative / Manager IDs first
                    if (id == "1" && password == "123")
                    {
                        DonorManager from = new DonorManager();
                        from.Show();
                    }
                    else if (id == "2" && password == "1234")
                    {
                        PatientManager from = new PatientManager();
                        from.Show();
                    }
                    else if (id == "3" && password == "12345")
                    {
                        BloodStock from = new BloodStock();
                        from.Show();
                    }
                    else if (id == "4" && password == "123456")
                    {
                        BloodTransfer3 from = new BloodTransfer3();
                        from.Show();
                    }
                    // 2. If not a specific manager ID, check the Role for regular users
                    else if (Role == "Doner" || Role == "Donor")
                    {
                        string dbID = ds.Tables[0].Rows[0]["ID"].ToString();
                        string dbPass = ds.Tables[0].Rows[0]["Password"].ToString(); //
                        string dbName = ds.Tables[0].Rows[0]["Fullname"].ToString(); //
                        string dbAddr = ds.Tables[0].Rows[0]["address"].ToString();
                        string dbContact = ds.Tables[0].Rows[0]["Contactnumber"].ToString();

                        //

                        // Pass all 4 items to the new form
                        DonerView from = new DonerView(id, dbPass, dbName, dbAddr, dbContact);
                        from.Show();
                        this.Hide();
                    }
                    else if (Role == "Patient" || Role == "Patient")
                    {
                        string dbID = ds.Tables[0].Rows[0]["ID"].ToString();
                        string dbPass = ds.Tables[0].Rows[0]["Password"].ToString(); //
                        string dbName = ds.Tables[0].Rows[0]["Fullname"].ToString(); //
                        string dbAddr = ds.Tables[0].Rows[0]["address"].ToString();
                        string dbContact = ds.Tables[0].Rows[0]["Contactnumber"].ToString();

                        //

                        // Pass all 4 items to the new form
                        PatientView from = new PatientView(id, dbPass, dbName, dbAddr, dbContact);
                        from.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login successful as " + Role);
                    }

                    
                    this.Hide();
                    // --- UPDATED INDIVIDUAL LOGIC ENDS HERE ---
                }
                else
                {
                    MessageBox.Show("Error: Invalid ID, Password, or Role.");
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

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignupForm from = new SignupForm();
            from.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
