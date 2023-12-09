namespace Conference_Management_System
{
    partial class Register
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
            lastNameTb = new TextBox();
            firstNameTb = new TextBox();
            addressTb = new TextBox();
            emailAddTb = new TextBox();
            contactNumberTb = new TextBox();
            registerBtn = new Button();
            usernameTb = new TextBox();
            passwordTb = new TextBox();
            showPass = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lastNameTb
            // 
            lastNameTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTb.Location = new Point(301, 97);
            lastNameTb.Name = "lastNameTb";
            lastNameTb.Size = new Size(219, 30);
            lastNameTb.TabIndex = 0;
            // 
            // firstNameTb
            // 
            firstNameTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTb.Location = new Point(301, 138);
            firstNameTb.Name = "firstNameTb";
            firstNameTb.Size = new Size(219, 30);
            firstNameTb.TabIndex = 1;
            // 
            // addressTb
            // 
            addressTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            addressTb.Location = new Point(301, 181);
            addressTb.Name = "addressTb";
            addressTb.Size = new Size(219, 30);
            addressTb.TabIndex = 2;
            // 
            // emailAddTb
            // 
            emailAddTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            emailAddTb.Location = new Point(301, 224);
            emailAddTb.Name = "emailAddTb";
            emailAddTb.Size = new Size(219, 30);
            emailAddTb.TabIndex = 3;
            // 
            // contactNumberTb
            // 
            contactNumberTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            contactNumberTb.Location = new Point(301, 272);
            contactNumberTb.Name = "contactNumberTb";
            contactNumberTb.Size = new Size(219, 30);
            contactNumberTb.TabIndex = 4;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = SystemColors.ControlLight;
            registerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            registerBtn.ForeColor = SystemColors.ActiveCaptionText;
            registerBtn.Location = new Point(665, 272);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(123, 44);
            registerBtn.TabIndex = 10;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // usernameTb
            // 
            usernameTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTb.Location = new Point(301, 316);
            usernameTb.Name = "usernameTb";
            usernameTb.Size = new Size(219, 30);
            usernameTb.TabIndex = 11;
            // 
            // passwordTb
            // 
            passwordTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTb.Location = new Point(301, 360);
            passwordTb.Name = "passwordTb";
            passwordTb.Size = new Size(219, 30);
            passwordTb.TabIndex = 13;
            passwordTb.UseSystemPasswordChar = true;
            // 
            // showPass
            // 
            showPass.BackColor = Color.Transparent;
            showPass.BackgroundImageLayout = ImageLayout.Stretch;
            showPass.Cursor = Cursors.No;
            showPass.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            showPass.Location = new Point(544, 365);
            showPass.Name = "showPass";
            showPass.Size = new Size(121, 23);
            showPass.TabIndex = 15;
            showPass.Text = "Show";
            showPass.UseVisualStyleBackColor = false;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(126, 360);
            label7.Name = "label7";
            label7.Size = new Size(90, 23);
            label7.TabIndex = 14;
            label7.Text = "Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(128, 316);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 12;
            label6.Text = "Username :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(128, 272);
            label5.Name = "label5";
            label5.Size = new Size(147, 23);
            label5.TabIndex = 9;
            label5.Text = "Contact Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(128, 224);
            label4.Name = "label4";
            label4.Size = new Size(125, 23);
            label4.TabIndex = 8;
            label4.Text = "Email Address :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(128, 181);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 7;
            label3.Text = "Address :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(128, 138);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 6;
            label2.Text = "First Name : ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 97);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 5;
            label1.Text = "Last Name : ";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SCHEDUL_WEBSITE_DESIGN2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 451);
            Controls.Add(showPass);
            Controls.Add(label7);
            Controls.Add(passwordTb);
            Controls.Add(label6);
            Controls.Add(usernameTb);
            Controls.Add(registerBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contactNumberTb);
            Controls.Add(emailAddTb);
            Controls.Add(addressTb);
            Controls.Add(firstNameTb);
            Controls.Add(lastNameTb);
            DoubleBuffered = true;
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lastNameTb;
        private TextBox firstNameTb;
        private TextBox addressTb;
        private TextBox emailAddTb;
        private TextBox contactNumberTb;
        private Button registerBtn;
        private TextBox usernameTb;
        private TextBox passwordTb;
        private CheckBox showPass;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}