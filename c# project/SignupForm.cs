using firstpract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__project
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void buttonpatientSignup_Click(object sender, EventArgs e)
        {
            PatientReqForm from = new PatientReqForm();
            from.Show();
            this.Close();
        }

        private void buttondonateSignup_Click(object sender, EventArgs e)
        {
            DonorRegForm form = new DonorRegForm();
            form.Show();
            this.Close();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
