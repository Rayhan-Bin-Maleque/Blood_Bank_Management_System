using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__project
{
    public partial class PatientReqForm : Form
    {
        public PatientReqForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {


        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {

            var Fullname = textBoxPatientFullname.Text;
            var password = textBoxPassword.Text;
            var contactnumber = textBoxPatientContact.Text;
            var address = textBoxPatientAddress.Text;
            String gender;
            var BloodGroup = comboBoxBloodGroup.SelectedItem.ToString();
            string Paitent = "Patient";
            string Status = "Pending";

            if (string.IsNullOrEmpty(Fullname))
            {
                MessageBox.Show("Error full name is requied");
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Error password is requied");
            }
            if (string.IsNullOrEmpty(contactnumber))
            {
                MessageBox.Show("Error contactnumber is requied");
            }

            if (radioButtonMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (comboBoxBloodGroup == null)
            {
                MessageBox.Show("Error Blood Group is requied");
            }

            var message = $"Fullname:{Fullname}\n" +
                          $"password:{password}\n" +
                          $"gender:{gender}\n" +
                          $"Blood Group:{BloodGroup}\n";

            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            // SQL Query string
            var query = "insert into Patient (FullName, ContactNumber, Address, Gender, BloodGroup, Password,Status) values ( '" + Fullname + "', '" + contactnumber + "', '" + address + "', '" + gender + "', '" + BloodGroup + "', '" + password + "', '" + Status + "')";

            // --- FIXED SECTION ---
            // Use SqlCommand instead of DataAdapter for Inserting
            SqlCommand cmd = new SqlCommand(query, con);
            // FIX: Assign the value "Patient" to the variable so it saves in the Login table

            try
            {
                // 1. Execute the main Patient registration
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // 2. Add to Login table first (since ID is Identity, SQL generates it here)
                    string loginQuery = "insert into Login (Password, Role,Fullname,address,Contactnumber) values ('" + password + "','" + Paitent + "','" + Fullname + "','" + address + "','" + contactnumber + "')";
                    SqlCommand loginCmd = new SqlCommand(loginQuery, con);
                    loginCmd.ExecuteNonQuery();

                    // 3. Now retrieve the ID that was just generated for that password
                    string retrieveIdQuery = "SELECT ID FROM Login WHERE Password = '" + password + "' AND Role = '" + Paitent + "' AND Fullname = '" + Fullname + "' AND address = '" + address + "' AND Contactnumber = '" + contactnumber + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(retrieveIdQuery, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    // Access the generated ID from the first row
                    string dbLoginId = dt.Rows[0]["ID"].ToString();

                    MessageBox.Show("Patient Registered Successfully!\n" + "Your id is: " + dbLoginId + "\nYou can now login with this ID.");

                    // --- NEW PART ADDED HERE ---
                    // 4. Retrieve the patientID from the Patient table to record the transfer request
                    string retrievePatientIdQuery = "SELECT paitentID FROM Patient WHERE FullName = '" + Fullname + "' AND ContactNumber = '" + contactnumber + "'";
                    SqlDataAdapter adpPatient = new SqlDataAdapter(retrievePatientIdQuery, con);
                    DataTable dtPatient = new DataTable();
                    adpPatient.Fill(dtPatient);

                    if (dtPatient.Rows.Count > 0)
                    {
                        string dbPatientId = dtPatient.Rows[0]["paitentID"].ToString();
                        string transferStatus = "Pending";

                        string bloodTransferQuery = "INSERT INTO BloodTransfer (patientID, BloodGroup, Gender, Status) VALUES (" + dbPatientId + ", '" + BloodGroup + "', '" + gender + "', '" + transferStatus + "')";
                        new SqlCommand(bloodTransferQuery, con).ExecuteNonQuery();

                        MessageBox.Show("Registration Successful!\nPatient ID: " + dbPatientId + "\nTransfer Record Created.");
                    }
                    // --- END OF NEW PART ---

                    // Clear your textboxes
                    textBoxPatientFullname.Clear();
                    textBoxPatientContact.Clear();
                    textBoxPatientAddress.Clear();
                    textBoxPassword.Clear();
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
