namespace c__project
{
    partial class BloodTransfer3
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel9 = new Panel();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            panel11 = new Panel();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            New = new Button();
            Decline = new Button();
            Transfer = new Button();
            button2 = new Button();
            panel4 = new Panel();
            PatientID = new TextBox();
            label3 = new Label();
            panel7 = new Panel();
            panel10 = new Panel();
            RequestFemaleradioButton3 = new RadioButton();
            RequestMaleradioButton4 = new RadioButton();
            label14 = new Label();
            panel5 = new Panel();
            RequestStatus = new TextBox();
            label15 = new Label();
            panel8 = new Panel();
            textBox1 = new TextBox();
            label13 = new Label();
            panel3 = new Panel();
            TransferID = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel11.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 550F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1434, 663);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(553, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 657);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel9
            // 
            panel9.Controls.Add(dataGridView2);
            panel9.Controls.Add(label2);
            panel9.Location = new Point(66, 315);
            panel9.Name = "panel9";
            panel9.Size = new Size(725, 309);
            panel9.TabIndex = 154;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(179, 74);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(541, 198);
            dataGridView2.TabIndex = 106;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(601, 48);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 108;
            label2.Text = "Blood Stock";
            // 
            // panel6
            // 
            panel6.Controls.Add(dataGridView1);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(66, 59);
            panel6.Name = "panel6";
            panel6.Size = new Size(725, 244);
            panel6.TabIndex = 153;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(179, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(541, 198);
            dataGridView1.TabIndex = 106;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(460, 9);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(260, 23);
            label7.TabIndex = 108;
            label7.Text = "Blood Request From Patient";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.ImageAlign = ContentAlignment.TopCenter;
            label9.Location = new Point(278, 19);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(291, 23);
            label9.TabIndex = 152;
            label9.Text = "Blood Transfer (Manager View)";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(New);
            panel1.Controls.Add(Decline);
            panel1.Controls.Add(Transfer);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 657);
            panel1.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(textBox2);
            panel11.Controls.Add(label4);
            panel11.Location = new Point(8, 122);
            panel11.Name = "panel11";
            panel11.Size = new Size(508, 55);
            panel11.TabIndex = 145;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(139, 10);
            textBox2.Margin = new Padding(5, 3, 5, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(292, 32);
            textBox2.TabIndex = 144;
            textBox2.Text = " Auto Genarated";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 13);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 143;
            label4.Text = "Doner ID:";
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(157, 492);
            button1.Margin = new Padding(5, 3, 5, 3);
            button1.Name = "button1";
            button1.Size = new Size(184, 53);
            button1.TabIndex = 144;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // New
            // 
            New.BackColor = Color.FromArgb(255, 255, 128);
            New.Cursor = Cursors.Hand;
            New.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            New.Location = new Point(157, 580);
            New.Margin = new Padding(5, 3, 5, 3);
            New.Name = "New";
            New.Size = new Size(106, 44);
            New.TabIndex = 143;
            New.Text = "New";
            New.UseVisualStyleBackColor = false;
            New.Click += New_Click;
            // 
            // Decline
            // 
            Decline.BackColor = Color.IndianRed;
            Decline.Cursor = Cursors.Hand;
            Decline.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Decline.Location = new Point(290, 580);
            Decline.Margin = new Padding(5, 3, 5, 3);
            Decline.Name = "Decline";
            Decline.Size = new Size(106, 44);
            Decline.TabIndex = 142;
            Decline.Text = "Decline";
            Decline.UseVisualStyleBackColor = false;
            Decline.Click += Decline_Click;
            // 
            // Transfer
            // 
            Transfer.BackColor = Color.FromArgb(192, 255, 192);
            Transfer.Cursor = Cursors.Hand;
            Transfer.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Transfer.Location = new Point(406, 580);
            Transfer.Margin = new Padding(5, 3, 5, 3);
            Transfer.Name = "Transfer";
            Transfer.Size = new Size(106, 44);
            Transfer.TabIndex = 141;
            Transfer.Text = "Transfer";
            Transfer.UseVisualStyleBackColor = false;
            Transfer.Click += Transfer_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(20, 580);
            button2.Margin = new Padding(5, 3, 5, 3);
            button2.Name = "button2";
            button2.Size = new Size(106, 44);
            button2.TabIndex = 140;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(PatientID);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(8, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(508, 44);
            panel4.TabIndex = 137;
            // 
            // PatientID
            // 
            PatientID.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PatientID.Location = new Point(131, 3);
            PatientID.Margin = new Padding(5, 3, 5, 3);
            PatientID.Multiline = true;
            PatientID.Name = "PatientID";
            PatientID.ReadOnly = true;
            PatientID.Size = new Size(292, 32);
            PatientID.TabIndex = 144;
            PatientID.Text = " Auto Genarated";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 13);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 143;
            label3.Text = "Patient ID:";
            // 
            // panel7
            // 
            panel7.Controls.Add(panel10);
            panel7.Controls.Add(label14);
            panel7.Location = new Point(19, 259);
            panel7.Name = "panel7";
            panel7.Size = new Size(508, 44);
            panel7.TabIndex = 139;
            // 
            // panel10
            // 
            panel10.Controls.Add(RequestFemaleradioButton3);
            panel10.Controls.Add(RequestMaleradioButton4);
            panel10.Location = new Point(219, 7);
            panel10.Name = "panel10";
            panel10.Size = new Size(236, 31);
            panel10.TabIndex = 160;
            // 
            // RequestFemaleradioButton3
            // 
            RequestFemaleradioButton3.AutoSize = true;
            RequestFemaleradioButton3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RequestFemaleradioButton3.Location = new Point(109, 3);
            RequestFemaleradioButton3.Name = "RequestFemaleradioButton3";
            RequestFemaleradioButton3.Size = new Size(71, 21);
            RequestFemaleradioButton3.TabIndex = 69;
            RequestFemaleradioButton3.TabStop = true;
            RequestFemaleradioButton3.Text = "Female";
            RequestFemaleradioButton3.UseVisualStyleBackColor = true;
            // 
            // RequestMaleradioButton4
            // 
            RequestMaleradioButton4.AutoSize = true;
            RequestMaleradioButton4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RequestMaleradioButton4.Location = new Point(20, 5);
            RequestMaleradioButton4.Name = "RequestMaleradioButton4";
            RequestMaleradioButton4.Size = new Size(56, 21);
            RequestMaleradioButton4.TabIndex = 68;
            RequestMaleradioButton4.TabStop = true;
            RequestMaleradioButton4.Text = "Male";
            RequestMaleradioButton4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(54, 12);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(157, 19);
            label14.TabIndex = 159;
            label14.Text = "Requested Gender:";
            // 
            // panel5
            // 
            panel5.Controls.Add(RequestStatus);
            panel5.Controls.Add(label15);
            panel5.Location = new Point(19, 329);
            panel5.Name = "panel5";
            panel5.Size = new Size(508, 44);
            panel5.TabIndex = 138;
            // 
            // RequestStatus
            // 
            RequestStatus.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RequestStatus.Location = new Point(197, 6);
            RequestStatus.Margin = new Padding(5, 3, 5, 3);
            RequestStatus.Multiline = true;
            RequestStatus.Name = "RequestStatus";
            RequestStatus.ReadOnly = true;
            RequestStatus.Size = new Size(238, 32);
            RequestStatus.TabIndex = 162;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(74, 19);
            label15.Margin = new Padding(5, 0, 5, 0);
            label15.Name = "label15";
            label15.Size = new Size(120, 19);
            label15.TabIndex = 161;
            label15.Text = "Request Status:";
            // 
            // panel8
            // 
            panel8.Controls.Add(textBox1);
            panel8.Controls.Add(label13);
            panel8.Location = new Point(20, 209);
            panel8.Name = "panel8";
            panel8.Size = new Size(508, 44);
            panel8.TabIndex = 138;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(197, 9);
            textBox1.Margin = new Padding(5, 3, 5, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(292, 32);
            textBox1.TabIndex = 158;
            textBox1.Text = " Auto Genarated";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(11, 18);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(195, 19);
            label13.TabIndex = 157;
            label13.Text = "Requested Blood Group:";
            // 
            // panel3
            // 
            panel3.Controls.Add(TransferID);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(8, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(508, 44);
            panel3.TabIndex = 136;
            // 
            // TransferID
            // 
            TransferID.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TransferID.Location = new Point(127, 0);
            TransferID.Margin = new Padding(5, 3, 5, 3);
            TransferID.Multiline = true;
            TransferID.Name = "TransferID";
            TransferID.ReadOnly = true;
            TransferID.Size = new Size(291, 32);
            TransferID.TabIndex = 135;
            TransferID.Text = " Auto Genarated";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 13);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 134;
            label1.Text = "Transfer ID:";
            // 
            // BloodTransfer3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 675);
            Controls.Add(tableLayoutPanel1);
            Name = "BloodTransfer3";
            Text = "BloodTransfer3";
            Load += BloodTransfer3_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private TextBox TransferID;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel8;
        private Panel panel7;
        private Panel panel5;
        private TextBox PatientID;
        private Label label3;
        private Label label13;
        private Panel panel10;
        private RadioButton RequestFemaleradioButton3;
        private RadioButton RequestMaleradioButton4;
        private Label label14;
        private TextBox RequestStatus;
        private Label label15;
        private Button New;
        private Button Decline;
        private Button Transfer;
        private Button button2;
        private Panel panel6;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label9;
        private Panel panel9;
        private DataGridView dataGridView2;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Panel panel11;
        private TextBox textBox2;
        private Label label4;
    }
}