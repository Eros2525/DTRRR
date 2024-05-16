namespace DTRRR
{
    partial class DTR_FORM
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TimeInButton = new Button();
            TimeOutButton = new Button();
            EmployeeLabel = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            TIMEIN = new DataGridViewTextBoxColumn();
            TIMEOUT = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TIMEIN, TIMEOUT });
            dataGridView1.GridColor = SystemColors.HotTrack;
            dataGridView1.Location = new Point(26, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(477, 170);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(578, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(509, 145);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 2;
            label1.Text = "Employee Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(511, 176);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Employee Role:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(521, 206);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 4;
            label3.Text = "Management:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(561, 237);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 5;
            label4.Text = "ID No:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(26, 404);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Date:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Coral;
            label6.Location = new Point(65, 404);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 7;
            label6.Text = "label6";
            label6.Click += label6_Click;
            // 
            // TimeInButton
            // 
            TimeInButton.BackColor = Color.Transparent;
            TimeInButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TimeInButton.ForeColor = Color.Coral;
            TimeInButton.Location = new Point(533, 301);
            TimeInButton.Name = "TimeInButton";
            TimeInButton.Size = new Size(225, 33);
            TimeInButton.TabIndex = 12;
            TimeInButton.Text = "Time In";
            TimeInButton.UseVisualStyleBackColor = false;
            TimeInButton.Click += TimeInButton_Click;
            // 
            // TimeOutButton
            // 
            TimeOutButton.BackColor = Color.Transparent;
            TimeOutButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TimeOutButton.ForeColor = Color.Coral;
            TimeOutButton.Location = new Point(533, 345);
            TimeOutButton.Name = "TimeOutButton";
            TimeOutButton.Size = new Size(225, 33);
            TimeOutButton.TabIndex = 13;
            TimeOutButton.Text = "Time Out";
            TimeOutButton.UseVisualStyleBackColor = false;
            TimeOutButton.Click += TimeOutButton_Click;
            // 
            // EmployeeLabel
            // 
            EmployeeLabel.AutoSize = true;
            EmployeeLabel.BackColor = Color.Transparent;
            EmployeeLabel.ForeColor = Color.FromArgb(255, 128, 0);
            EmployeeLabel.Location = new Point(642, 145);
            EmployeeLabel.Name = "EmployeeLabel";
            EmployeeLabel.Size = new Size(91, 20);
            EmployeeLabel.TabIndex = 14;
            EmployeeLabel.Text = "Karl Jarabba";
            EmployeeLabel.Click += EmployeeLabel_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.ForeColor = Color.FromArgb(255, 128, 0);
            label12.Location = new Point(642, 176);
            label12.Name = "label12";
            label12.Size = new Size(83, 20);
            label12.TabIndex = 15;
            label12.Text = "Head Chief";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.ForeColor = Color.FromArgb(255, 128, 0);
            label13.Location = new Point(642, 206);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 16;
            label13.Text = "Kitchen";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.ForeColor = Color.FromArgb(255, 128, 0);
            label14.Location = new Point(642, 237);
            label14.Name = "label14";
            label14.Size = new Size(65, 20);
            label14.TabIndex = 17;
            label14.Text = "4230241";
            label14.Click += label14_Click;
            // 
            // TIMEIN
            // 
            TIMEIN.HeaderText = "Time In";
            TIMEIN.MinimumWidth = 6;
            TIMEIN.Name = "TIMEIN";
            TIMEIN.Resizable = DataGridViewTriState.False;
            // 
            // TIMEOUT
            // 
            TIMEOUT.HeaderText = "Time Out";
            TIMEOUT.MinimumWidth = 6;
            TIMEOUT.Name = "TIMEOUT";
            TIMEOUT.Resizable = DataGridViewTriState.False;
            // 
            // DTR_FORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ArtStation___Explore;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(EmployeeLabel);
            Controls.Add(TimeOutButton);
            Controls.Add(TimeInButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "DTR_FORM";
            Text = "TimeLogs";
            Load += DTR_FORM_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button TimeInButton;
        private Button TimeOutButton;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label7;
        public Label label11;
        private Label EmployeeLabel;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn TIMEIN;
        private DataGridViewTextBoxColumn TIMEOUT;
    }
}