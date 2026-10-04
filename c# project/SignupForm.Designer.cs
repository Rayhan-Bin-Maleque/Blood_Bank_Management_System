namespace c__project
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            buttonpatientSignup = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            buttondonateSignup = new Button();
            panel3 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(689, 571);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonpatientSignup);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(347, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 565);
            panel2.TabIndex = 1;
            // 
            // buttonpatientSignup
            // 
            buttonpatientSignup.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonpatientSignup.Location = new Point(120, 353);
            buttonpatientSignup.Name = "buttonpatientSignup";
            buttonpatientSignup.Size = new Size(104, 41);
            buttonpatientSignup.TabIndex = 2;
            buttonpatientSignup.Text = "Signup";
            buttonpatientSignup.UseVisualStyleBackColor = true;
            buttonpatientSignup.Click += buttonpatientSignup_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(71, 99);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 232);
            panel4.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttondonateSignup);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 565);
            panel1.TabIndex = 0;
            // 
            // buttondonateSignup
            // 
            buttondonateSignup.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttondonateSignup.Location = new Point(116, 353);
            buttondonateSignup.Name = "buttondonateSignup";
            buttondonateSignup.Size = new Size(104, 41);
            buttondonateSignup.TabIndex = 1;
            buttondonateSignup.Text = "Signup";
            buttondonateSignup.UseVisualStyleBackColor = true;
            buttondonateSignup.Click += buttondonateSignup_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(68, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 232);
            panel3.TabIndex = 0;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 571);
            Controls.Add(tableLayoutPanel1);
            Name = "SignupForm";
            Text = "SignupForm";
            Load += SignupForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel1;
        private Panel panel3;
        private Button buttonpatientSignup;
        private Button buttondonateSignup;
    }
}