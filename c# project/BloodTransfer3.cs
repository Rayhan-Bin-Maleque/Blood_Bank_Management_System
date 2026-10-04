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
    public partial class BloodTransfer3 : Form
    {
        public BloodTransfer3()
        {
            InitializeComponent();
        }
        private void ResetForm()
        {
            TransferID.Text = "Auto Generated";

            PatientID.Text = "Auto Generated";

            textBox1.Text = "Auto Generated";

            RequestStatus.Text = "";



            RequestMaleradioButton4.Checked = false;
            RequestFemaleradioButton3.Checked = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BloodTransfer3_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                var query = "select * from BloodTransfer ";
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

        private void New_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                var query = "select * from BloodTransfer ";
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
            this.ResetForm();
            var TransferiD = this.dataGridView1.Rows[e.RowIndex].Cells["Transfer_ID"].Value.ToString();
            TransferID.Text = TransferiD;

            var patientid = this.dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();
            PatientID.Text = patientid;


            var Status = this.dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            RequestStatus.Text = Status;


            var BloodGroup = this.dataGridView1.Rows[e.RowIndex].Cells["BloodGroup"].Value.ToString();
            textBox1.Text = BloodGroup;




            var gender = this.dataGridView1.Rows[e.RowIndex].Cells["gender"].Value.ToString().Trim();
            RequestMaleradioButton4.Checked = false;
            RequestFemaleradioButton3.Checked = false;
            if (gender == "Male")
            {
                RequestMaleradioButton4.Checked = true;
            }
            else if (gender == "Female")
            {
                RequestFemaleradioButton3.Checked = true;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {



            string BloodGroup = textBox1.Text;

            try
            {
                // 1. Setup the connection
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();

                // 2. Fixed Query: Added single quotes around BloodGroup so SQL treats it as text
                // Also changed table to BloodStock based on your earlier screenshots
                string query = "SELECT * FROM BloodStock WHERE Status = 'Available' AND BloodGroup = '" + BloodGroup + "'";

                // 3. Fill the DataGridView2
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                this.dataGridView2.DataSource = dt;
                this.dataGridView2.Refresh();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering stock: " + ex.Message);
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var DoneriD = this.dataGridView2.Rows[e.RowIndex].Cells["DonerID"].Value.ToString();
            textBox2.Text = DoneriD;
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            string DonerID = textBox2.Text;
            string Status = "Unavailable"; // Fixed spelling: Unavaiable -> Unavailable
            string Status2 = "Received Pending";
            string Status3 = "Please Collect";
            // Fixed spelling: Recived -> Received

            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();

                // 1. Fixed Query: 
                // - Wrapped DonerID in single quotes
                // - Added '=' and 'SET' for BloodTransfer
                // - Wrapped TransferID.Text in single quotes
                string query = "UPDATE BloodStock SET Status = '" + Status + "' WHERE DonerID = '" + DonerID + "'; " +
                               "UPDATE BloodTransfer SET Status = '" + Status2 + "' WHERE Transfer_ID = '" + TransferID.Text + "';"+
                               "UPDATE Patient SET Status = '" + Status2 + "' WHERE paitentID = '" + PatientID.Text + "';";

                // 2. Create the command
                SqlCommand cmd = new SqlCommand(query, con);

                // 3. Execute the update
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Transfer Successful! Blood Stock updated and Request marked as Received.");
                }

                con.Close();

                // 4. Refresh your grids to show the new status
                this.button2_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void Decline_Click(object sender, EventArgs e)
        {
            string Status2 = "Decline";  // Fixed spelling: Recived -> Received

            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=\"C# project\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();

                // 1. Fixed Query: 
                // - Wrapped DonerID in single quotes
                // - Added '=' and 'SET' for BloodTransfer
                // - Wrapped TransferID.Text in single quotes
                string query ="UPDATE BloodTransfer SET Status = '" + Status2 + "' WHERE Transfer_ID = '" + TransferID.Text + "';";

                // 2. Create the command
                SqlCommand cmd = new SqlCommand(query, con);

                // 3. Execute the update
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Blood Is Not Available In Blood Stock .");
                }

                con.Close();

                // 4. Refresh your grids to show the new status
                this.button2_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
    }
}

