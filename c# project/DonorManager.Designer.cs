namespace firstpract
{
    partial class DonorManager
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
            comboBox1 = new ComboBox();
            buttonLoad = new Button();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            textBoxx7 = new TextBox();
            textBoxx1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonADDDD = new Button();
            buttonNew = new Button();
            label10 = new Label();
            textBox4 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            buttonRemove = new Button();
            panel2 = new Panel();
            dataGridViewDoner = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoner).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.WindowFrame;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" });
            comboBox1.Location = new Point(217, 216);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 23);
            comboBox1.TabIndex = 48;
            comboBox1.Text = "    Select your Blood Group";
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.Info;
            buttonLoad.Cursor = Cursors.Hand;
            buttonLoad.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLoad.Location = new Point(43, 593);
            buttonLoad.Margin = new Padding(5, 3, 5, 3);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(106, 44);
            buttonLoad.TabIndex = 46;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Cursor = Cursors.Hand;
            checkBox3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox3.Location = new Point(390, 268);
            checkBox3.Margin = new Padding(5, 3, 5, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(68, 20);
            checkBox3.TabIndex = 44;
            checkBox3.Text = "Others";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Cursor = Cursors.Hand;
            checkBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(296, 268);
            checkBox2.Margin = new Padding(5, 3, 5, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(73, 20);
            checkBox2.TabIndex = 43;
            checkBox2.Text = "Female";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(217, 269);
            checkBox1.Margin = new Padding(5, 3, 5, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 20);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "Male";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxx7
            // 
            textBoxx7.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxx7.Location = new Point(217, 402);
            textBoxx7.Margin = new Padding(5, 3, 5, 3);
            textBoxx7.Multiline = true;
            textBoxx7.Name = "textBoxx7";
            textBoxx7.Size = new Size(292, 71);
            textBoxx7.TabIndex = 41;
            // 
            // textBoxx1
            // 
            textBoxx1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxx1.Location = new Point(217, 52);
            textBoxx1.Margin = new Padding(5, 3, 5, 3);
            textBoxx1.Multiline = true;
            textBoxx1.Name = "textBoxx1";
            textBoxx1.ReadOnly = true;
            textBoxx1.Size = new Size(292, 32);
            textBoxx1.TabIndex = 39;
            textBoxx1.Text = "        Auto Genarated";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.ImageAlign = ContentAlignment.TopCenter;
            label9.Location = new Point(361, 98);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(216, 23);
            label9.TabIndex = 36;
            label9.Text = "Donor's Manager View";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(133, 402);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 19);
            label8.TabIndex = 35;
            label8.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 321);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 19);
            label5.TabIndex = 32;
            label5.Text = "Contact Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(124, 269);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 31;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(101, 154);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 30;
            label3.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 218);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 29;
            label2.Text = "Blood Group:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 52);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 28;
            label1.Text = "Donor ID:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(217, 154);
            textBox1.Margin = new Padding(5, 3, 5, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 32);
            textBox1.TabIndex = 49;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(217, 321);
            textBox2.Margin = new Padding(5, 3, 5, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 32);
            textBox2.TabIndex = 50;
            // 
            // buttonADDDD
            // 
            buttonADDDD.BackColor = Color.ForestGreen;
            buttonADDDD.Cursor = Cursors.Hand;
            buttonADDDD.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonADDDD.Location = new Point(312, 593);
            buttonADDDD.Margin = new Padding(5, 3, 5, 3);
            buttonADDDD.Name = "buttonADDDD";
            buttonADDDD.Size = new Size(106, 44);
            buttonADDDD.TabIndex = 53;
            buttonADDDD.Text = "Submit";
            buttonADDDD.UseVisualStyleBackColor = false;
            buttonADDDD.Click += buttonADDDD_Click;
            // 
            // buttonNew
            // 
            buttonNew.BackColor = Color.FromArgb(255, 255, 128);
            buttonNew.Cursor = Cursors.Hand;
            buttonNew.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNew.Location = new Point(180, 593);
            buttonNew.Margin = new Padding(5, 3, 5, 3);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(106, 44);
            buttonNew.TabIndex = 54;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = false;
            buttonNew.Click += buttonNew_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(117, 102);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(84, 19);
            label10.TabIndex = 55;
            label10.Text = "Password:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(217, 102);
            textBox4.Margin = new Padding(5, 3, 5, 3);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(292, 32);
            textBox4.TabIndex = 56;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonRemove);
            panel1.Controls.Add(textBoxx1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonNew);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonADDDD);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBoxx7);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(buttonLoad);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox3);
            panel1.Location = new Point(1040, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 724);
            panel1.TabIndex = 58;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(168, 523);
            button1.Margin = new Padding(5, 3, 5, 3);
            button1.Name = "button1";
            button1.Size = new Size(235, 44);
            button1.TabIndex = 58;
            button1.Text = "Recived";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.Red;
            buttonRemove.Cursor = Cursors.Hand;
            buttonRemove.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.Location = new Point(442, 593);
            buttonRemove.Margin = new Padding(5, 3, 5, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(106, 44);
            buttonRemove.TabIndex = 57;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewDoner);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1032, 724);
            panel2.TabIndex = 59;
            // 
            // dataGridViewDoner
            // 
            dataGridViewDoner.AllowUserToAddRows = false;
            dataGridViewDoner.AllowUserToDeleteRows = false;
            dataGridViewDoner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoner.Location = new Point(66, 154);
            dataGridViewDoner.Name = "dataGridViewDoner";
            dataGridViewDoner.ReadOnly = true;
            dataGridViewDoner.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDoner.Size = new Size(840, 301);
            dataGridViewDoner.TabIndex = 37;
            dataGridViewDoner.CellDoubleClick += dataGridViewDoner_CellDoubleClick;
            // 
            // DonorManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1705, 727);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DonorManager";
            Text = "DonorManager";
            Load += DonorManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoner).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxx7;
        private System.Windows.Forms.TextBox textBoxx1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonADDDD;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewDoner;
        private Button buttonRemove;
        private Button button1;
    }
}