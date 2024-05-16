namespace DTRRR
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
            Logo = new PictureBox();
            LoginLabel = new Label();
            label1 = new Label();
            UserBox = new TextBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            PassWordBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.Image = Properties.Resources._202_2024792_user_profile_icon_png_download_fa_user_circle_removebg_preview1;
            Logo.Location = new Point(144, 26);
            Logo.Name = "Logo";
            Logo.Size = new Size(104, 105);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            Logo.Click += Logo_Click;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Segoe UI", 15F);
            LoginLabel.ForeColor = Color.Cyan;
            LoginLabel.Location = new Point(64, 134);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(262, 35);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Login to Your Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(39, 169);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 2;
            label1.Text = "EmployeeName:";
            label1.Click += label1_Click;
            // 
            // UserBox
            // 
            UserBox.Location = new Point(39, 204);
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(312, 27);
            UserBox.TabIndex = 3;
            UserBox.TextChanged += UserBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(39, 246);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = Color.Cyan;
            checkBox1.Location = new Point(39, 322);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Cyan;
            button1.Location = new Point(39, 372);
            button1.Name = "button1";
            button1.Size = new Size(312, 43);
            button1.TabIndex = 7;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PassWordBox
            // 
            PassWordBox.Location = new Point(39, 280);
            PassWordBox.Name = "PassWordBox";
            PassWordBox.Size = new Size(312, 27);
            PassWordBox.TabIndex = 8;
            PassWordBox.UseSystemPasswordChar = true;
            PassWordBox.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__6_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(391, 511);
            Controls.Add(PassWordBox);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(UserBox);
            Controls.Add(label1);
            Controls.Add(LoginLabel);
            Controls.Add(Logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "LogInForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Label LoginLabel;
        private Label label1;
        private TextBox UserBox;
        private Label label2;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox PassWordBox;
    }
}
