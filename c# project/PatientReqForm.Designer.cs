namespace c__project
{
    partial class PatientReqForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxPatientFullname = new TextBox();
            textBoxPatientAddress = new TextBox();
            textBoxPatientContact = new TextBox();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            comboBoxBloodGroup = new ComboBox();
            panel1 = new Panel();
            label8 = new Label();
            textBoxPassword = new TextBox();
            buttonSubmit = new Button();
            buttonBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 293);
            label2.Name = "label2";
            label2.Size = new Size(222, 25);
            label2.TabIndex = 1;
            label2.Text = "Requested Blood Group:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(158, 191);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(104, 419);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 3;
            label4.Text = "Contact Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(179, 487);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(179, 351);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 5;
            label6.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(415, 9);
            label7.Name = "label7";
            label7.Size = new Size(316, 40);
            label7.TabIndex = 6;
            label7.Text = "Patient Request Form:";
            // 
            // textBoxPatientFullname
            // 
            textBoxPatientFullname.Location = new Point(288, 179);
            textBoxPatientFullname.Multiline = true;
            textBoxPatientFullname.Name = "textBoxPatientFullname";
            textBoxPatientFullname.Size = new Size(359, 37);
            textBoxPatientFullname.TabIndex = 8;
            // 
            // textBoxPatientAddress
            // 
            textBoxPatientAddress.Location = new Point(288, 475);
            textBoxPatientAddress.Multiline = true;
            textBoxPatientAddress.Name = "textBoxPatientAddress";
            textBoxPatientAddress.Size = new Size(359, 37);
            textBoxPatientAddress.TabIndex = 9;
            // 
            // textBoxPatientContact
            // 
            textBoxPatientContact.Location = new Point(288, 407);
            textBoxPatientContact.Multiline = true;
            textBoxPatientContact.Name = "textBoxPatientContact";
            textBoxPatientContact.Size = new Size(359, 37);
            textBoxPatientContact.TabIndex = 10;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButtonMale.Location = new Point(17, 9);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(56, 21);
            radioButtonMale.TabIndex = 11;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButtonFemale.Location = new Point(106, 10);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(71, 21);
            radioButtonFemale.TabIndex = 12;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // comboBoxBloodGroup
            // 
            comboBoxBloodGroup.FormattingEnabled = true;
            comboBoxBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            comboBoxBloodGroup.Location = new Point(305, 293);
            comboBoxBloodGroup.Name = "comboBoxBloodGroup";
            comboBoxBloodGroup.Size = new Size(160, 23);
            comboBoxBloodGroup.TabIndex = 13;
            comboBoxBloodGroup.Text = " Select your Blood Group";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButtonMale);
            panel1.Controls.Add(radioButtonFemale);
            panel1.Location = new Point(288, 345);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 34);
            panel1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(158, 242);
            label8.Name = "label8";
            label8.Size = new Size(101, 25);
            label8.TabIndex = 15;
            label8.Text = "Password:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(288, 230);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(359, 37);
            textBoxPassword.TabIndex = 16;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(1018, 500);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(103, 42);
            buttonSubmit.TabIndex = 17;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click_1;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(1018, 452);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(103, 42);
            buttonBack.TabIndex = 18;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1254, 578);
            Controls.Add(buttonBack);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxPassword);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(comboBoxBloodGroup);
            Controls.Add(textBoxPatientContact);
            Controls.Add(textBoxPatientAddress);
            Controls.Add(textBoxPatientFullname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "PatientForm";
            Text = "patientForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxPatientFullname;
        private TextBox textBoxPatientAddress;
        private TextBox textBoxPatientContact;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private ComboBox comboBoxBloodGroup;
        private Panel panel1;
        private Label label8;
        private TextBox textBoxPassword;
        private Button buttonSubmit;
        private Button buttonBack;
    }
}