namespace c__project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            comboBoxRole = new ComboBox();
            buttonSignUp = new Button();
            buttonlogin = new Button();
            textBox_pass = new TextBox();
            textBox_id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1256, 576);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 570);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBoxRole);
            panel2.Controls.Add(buttonSignUp);
            panel2.Controls.Add(buttonlogin);
            panel2.Controls.Add(textBox_pass);
            panel2.Controls.Add(textBox_id);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(759, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 570);
            panel2.TabIndex = 1;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Doner", "Patient", "Manager" });
            comboBoxRole.Location = new Point(75, 313);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(121, 23);
            comboBoxRole.TabIndex = 6;
            comboBoxRole.Text = "Select Role";
            // 
            // buttonSignUp
            // 
            buttonSignUp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonSignUp.Location = new Point(166, 428);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(117, 39);
            buttonSignUp.TabIndex = 5;
            buttonSignUp.Text = "SignUp";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // buttonlogin
            // 
            buttonlogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonlogin.Location = new Point(166, 383);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(117, 39);
            buttonlogin.TabIndex = 4;
            buttonlogin.Text = "login";
            buttonlogin.UseVisualStyleBackColor = true;
            buttonlogin.Click += buttonlogin_Click;
            // 
            // textBox_pass
            // 
            textBox_pass.Location = new Point(70, 260);
            textBox_pass.Multiline = true;
            textBox_pass.Name = "textBox_pass";
            textBox_pass.PasswordChar = '*';
            textBox_pass.Size = new Size(311, 37);
            textBox_pass.TabIndex = 3;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(70, 185);
            textBox_id.Multiline = true;
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(311, 37);
            textBox_id.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 232);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 157);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 576);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button buttonSignUp;
        private Button buttonlogin;
        private TextBox textBox_pass;
        private TextBox textBox_id;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxRole;
    }
}
