namespace Conference_Management_System
{
    partial class Sponsor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sponsor));
            label5 = new Label();
            contactTb = new TextBox();
            emailTb = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            firstNameTb = new TextBox();
            lastNameTb = new TextBox();
            backPic = new PictureBox();
            setBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)backPic).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(109, 288);
            label5.Name = "label5";
            label5.Size = new Size(157, 25);
            label5.TabIndex = 43;
            label5.Text = "Contact Number : ";
            // 
            // contactTb
            // 
            contactTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            contactTb.Location = new Point(291, 288);
            contactTb.Name = "contactTb";
            contactTb.Size = new Size(219, 30);
            contactTb.TabIndex = 42;
            // 
            // emailTb
            // 
            emailTb.AutoSize = true;
            emailTb.BackColor = Color.Transparent;
            emailTb.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            emailTb.Location = new Point(109, 240);
            emailTb.Name = "emailTb";
            emailTb.Size = new Size(133, 25);
            emailTb.TabIndex = 41;
            emailTb.Text = "Email Address :";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(291, 239);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 30);
            textBox3.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(109, 187);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 38;
            label2.Text = "First Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(109, 138);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 37;
            label1.Text = "Last Name : ";
            // 
            // firstNameTb
            // 
            firstNameTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTb.Location = new Point(291, 186);
            firstNameTb.Name = "firstNameTb";
            firstNameTb.Size = new Size(219, 30);
            firstNameTb.TabIndex = 36;
            // 
            // lastNameTb
            // 
            lastNameTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTb.Location = new Point(291, 137);
            lastNameTb.Name = "lastNameTb";
            lastNameTb.Size = new Size(219, 30);
            lastNameTb.TabIndex = 35;
            // 
            // backPic
            // 
            backPic.AccessibleName = "";
            backPic.BackColor = Color.Transparent;
            backPic.ErrorImage = (Image)resources.GetObject("backPic.ErrorImage");
            backPic.Image = Properties.Resources.image_removebg_preview__5_4;
            backPic.Location = new Point(569, 364);
            backPic.Name = "backPic";
            backPic.Size = new Size(51, 49);
            backPic.SizeMode = PictureBoxSizeMode.StretchImage;
            backPic.TabIndex = 54;
            backPic.TabStop = false;
            backPic.Click += backPic_Click;
            // 
            // setBtn
            // 
            setBtn.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            setBtn.Location = new Point(329, 343);
            setBtn.Name = "setBtn";
            setBtn.Size = new Size(150, 29);
            setBtn.TabIndex = 55;
            setBtn.Text = "Set Conference";
            setBtn.UseVisualStyleBackColor = true;
            setBtn.Click += setBtn_Click;
            // 
            // Sponsor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_11_21_165853;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(setBtn);
            Controls.Add(backPic);
            Controls.Add(label5);
            Controls.Add(contactTb);
            Controls.Add(emailTb);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(firstNameTb);
            Controls.Add(lastNameTb);
            DoubleBuffered = true;
            Name = "Sponsor";
            Size = new Size(640, 425);
            ((System.ComponentModel.ISupportInitialize)backPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox contactTb;
        private Label emailTb;
        private TextBox textBox3;
        private Label label2;
        private Label label1;
        private TextBox firstNameTb;
        private TextBox lastNameTb;
        private PictureBox backPic;
        private Button setBtn;
    }
}
