namespace firstpract
{
    partial class BloodStock
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
            label9 = new Label();
            buttonNew = new Button();
            buttonRemove = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            label10 = new Label();
            textBoxDonerID = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            radioButtonAvailable = new RadioButton();
            radioButtonUnavailable = new RadioButton();
            panel1 = new Panel();
            button4 = new Button();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.ImageAlign = ContentAlignment.TopCenter;
            label9.Location = new Point(524, 43);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(344, 28);
            label9.TabIndex = 37;
            label9.Text = "Blood Stock (Manager View)";
            // 
            // buttonNew
            // 
            buttonNew.BackColor = Color.FromArgb(255, 255, 128);
            buttonNew.Cursor = Cursors.Hand;
            buttonNew.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNew.Location = new Point(189, 546);
            buttonNew.Margin = new Padding(5, 3, 5, 3);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(106, 44);
            buttonNew.TabIndex = 58;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = false;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.ForestGreen;
            buttonRemove.Cursor = Cursors.Hand;
            buttonRemove.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.Location = new Point(321, 546);
            buttonRemove.Margin = new Padding(5, 3, 5, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(106, 44);
            buttonRemove.TabIndex = 57;
            buttonRemove.Text = "Add";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(56, 546);
            button2.Margin = new Padding(5, 3, 5, 3);
            button2.Name = "button2";
            button2.Size = new Size(106, 44);
            button2.TabIndex = 55;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(191, 152);
            textBox4.Margin = new Padding(5, 3, 5, 3);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(292, 41);
            textBox4.TabIndex = 64;
            textBox4.Text = "       Auto Genarated";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(108, 165);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(73, 19);
            label10.TabIndex = 63;
            label10.Text = "Stock ID:";
            // 
            // textBoxDonerID
            // 
            textBoxDonerID.Font = new Font("Century", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxDonerID.Location = new Point(191, 213);
            textBoxDonerID.Margin = new Padding(5, 3, 5, 3);
            textBoxDonerID.Multiline = true;
            textBoxDonerID.Name = "textBoxDonerID";
            textBoxDonerID.Size = new Size(292, 32);
            textBoxDonerID.TabIndex = 62;
            textBoxDonerID.Text = "   Auto Genarated";
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.WindowFrame;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" });
            comboBox1.Location = new Point(191, 351);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 23);
            comboBox1.TabIndex = 61;
            comboBox1.Text = "    Select your Blood Group";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 226);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 60;
            label3.Text = "Doner ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 351);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 59;
            label2.Text = "Blood Group:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 286);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 65;
            label1.Text = "Total Units:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(191, 273);
            textBox2.Margin = new Padding(5, 3, 5, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 32);
            textBox2.TabIndex = 66;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(108, 405);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 67;
            label4.Text = "Gender:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(15, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(56, 21);
            radioButton1.TabIndex = 68;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(110, 7);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 21);
            radioButton2.TabIndex = 69;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(731, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(540, 420);
            dataGridView1.TabIndex = 70;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(124, 463);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 71;
            label5.Text = "Status:";
            // 
            // radioButtonAvailable
            // 
            radioButtonAvailable.AutoSize = true;
            radioButtonAvailable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButtonAvailable.Location = new Point(206, 469);
            radioButtonAvailable.Name = "radioButtonAvailable";
            radioButtonAvailable.Size = new Size(85, 21);
            radioButtonAvailable.TabIndex = 72;
            radioButtonAvailable.TabStop = true;
            radioButtonAvailable.Text = "Available";
            radioButtonAvailable.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnavailable
            // 
            radioButtonUnavailable.AutoSize = true;
            radioButtonUnavailable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButtonUnavailable.Location = new Point(301, 469);
            radioButtonUnavailable.Name = "radioButtonUnavailable";
            radioButtonUnavailable.Size = new Size(101, 21);
            radioButtonUnavailable.TabIndex = 73;
            radioButtonUnavailable.TabStop = true;
            radioButtonUnavailable.Text = "Unavailable";
            radioButtonUnavailable.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(191, 407);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 31);
            panel1.TabIndex = 74;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 0, 0);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(459, 546);
            button4.Margin = new Padding(5, 3, 5, 3);
            button4.Name = "button4";
            button4.Size = new Size(106, 44);
            button4.TabIndex = 75;
            button4.Text = "Remove";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(255, 255, 128);
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(731, 546);
            buttonUpdate.Margin = new Padding(5, 3, 5, 3);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(200, 44);
            buttonUpdate.TabIndex = 76;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // BloodStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1378, 652);
            Controls.Add(buttonUpdate);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(radioButtonUnavailable);
            Controls.Add(radioButtonAvailable);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(label10);
            Controls.Add(textBoxDonerID);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonNew);
            Controls.Add(buttonRemove);
            Controls.Add(button2);
            Controls.Add(label9);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BloodStock";
            Text = "BloodStock";
            Load += BloodStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDonerID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Label label1;
        private TextBox textBox2;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DataGridView dataGridView1;
        private Label label5;
        private RadioButton radioButtonAvailable;
        private RadioButton radioButtonUnavailable;
        private Panel panel1;
        private Button buttonRemove;
        private Button button4;
        private Button buttonUpdate;
    }
}