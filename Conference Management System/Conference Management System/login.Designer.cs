namespace Conference_Management_System
{
    partial class login
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
            passwordTb = new TextBox();
            usernameTb = new TextBox();
            loginBtn = new Button();
            showPass = new CheckBox();
            Password1 = new Label();
            Label1 = new Label();
            SuspendLayout();
            // 
            // passwordTb
            // 
            passwordTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTb.Location = new Point(311, 246);
            passwordTb.Name = "passwordTb";
            passwordTb.PlaceholderText = "Enter password";
            passwordTb.Size = new Size(219, 30);
            passwordTb.TabIndex = 8;
            passwordTb.UseSystemPasswordChar = true;
            // 
            // usernameTb
            // 
            usernameTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTb.Location = new Point(312, 195);
            usernameTb.Name = "usernameTb";
            usernameTb.PlaceholderText = "Enter username";
            usernameTb.Size = new Size(219, 30);
            usernameTb.TabIndex = 7;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.ControlLight;
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = SystemColors.ActiveCaptionText;
            loginBtn.Location = new Point(666, 279);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(122, 38);
            loginBtn.TabIndex = 11;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.BackColor = Color.Transparent;
            showPass.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            showPass.ForeColor = SystemColors.ActiveCaptionText;
            showPass.Location = new Point(546, 252);
            showPass.Name = "showPass";
            showPass.Size = new Size(67, 24);
            showPass.TabIndex = 12;
            showPass.Text = "Show";
            showPass.UseVisualStyleBackColor = false;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // Password1
            // 
            Password1.AutoSize = true;
            Password1.BackColor = Color.Transparent;
            Password1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Password1.Location = new Point(180, 249);
            Password1.Name = "Password1";
            Password1.Size = new Size(95, 23);
            Password1.TabIndex = 10;
            Password1.Text = "Password : ";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.Location = new Point(181, 198);
            Label1.Name = "Label1";
            Label1.Size = new Size(96, 23);
            Label1.TabIndex = 9;
            Label1.Text = "Username :";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SCHEDUL_WEBSITE_DESIGN__2_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(showPass);
            Controls.Add(loginBtn);
            Controls.Add(Password1);
            Controls.Add(Label1);
            Controls.Add(passwordTb);
            Controls.Add(usernameTb);
            DoubleBuffered = true;
            Name = "login";
            Text = "Login";
            Load += login_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passwordTb;
        private TextBox usernameTb;
        private Button loginBtn;
        private CheckBox showPass;
        private Label Password1;
        private Label Label1;
    }
}