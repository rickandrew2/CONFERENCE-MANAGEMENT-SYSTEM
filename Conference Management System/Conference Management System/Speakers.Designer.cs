namespace Conference_Management_System
{
    partial class Speakers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Speakers));
            label2 = new Label();
            label1 = new Label();
            firstNameTb = new TextBox();
            lastNameTb = new TextBox();
            contactBtn = new Label();
            contactTb = new TextBox();
            label5 = new Label();
            emailTb = new TextBox();
            backpic = new PictureBox();
            nextpic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextpic).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(89, 186);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 18;
            label2.Text = "First Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 137);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 17;
            label1.Text = "Last Name : ";
            // 
            // firstNameTb
            // 
            firstNameTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTb.Location = new Point(271, 185);
            firstNameTb.Name = "firstNameTb";
            firstNameTb.Size = new Size(219, 30);
            firstNameTb.TabIndex = 16;
            // 
            // lastNameTb
            // 
            lastNameTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTb.Location = new Point(271, 136);
            lastNameTb.Name = "lastNameTb";
            lastNameTb.Size = new Size(219, 30);
            lastNameTb.TabIndex = 15;
            lastNameTb.TextChanged += lastNameTb_TextChanged;
            // 
            // contactBtn
            // 
            contactBtn.AutoSize = true;
            contactBtn.BackColor = Color.Transparent;
            contactBtn.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            contactBtn.Location = new Point(89, 239);
            contactBtn.Name = "contactBtn";
            contactBtn.Size = new Size(157, 25);
            contactBtn.TabIndex = 21;
            contactBtn.Text = "Contact Number : ";
            // 
            // contactTb
            // 
            contactTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            contactTb.Location = new Point(271, 238);
            contactTb.Name = "contactTb";
            contactTb.Size = new Size(219, 30);
            contactTb.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(89, 287);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 23;
            label5.Text = "Email :";
            // 
            // emailTb
            // 
            emailTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            emailTb.Location = new Point(271, 287);
            emailTb.Name = "emailTb";
            emailTb.Size = new Size(219, 30);
            emailTb.TabIndex = 22;
            // 
            // backpic
            // 
            backpic.BackColor = Color.Transparent;
            backpic.ErrorImage = (Image)resources.GetObject("backpic.ErrorImage");
            backpic.Image = Properties.Resources.image_removebg_preview__5_;
            backpic.Location = new Point(525, 375);
            backpic.Name = "backpic";
            backpic.Size = new Size(51, 36);
            backpic.SizeMode = PictureBoxSizeMode.StretchImage;
            backpic.TabIndex = 24;
            backpic.TabStop = false;
            backpic.Click += backpic_Click;
            // 
            // nextpic
            // 
            nextpic.BackColor = Color.Transparent;
            nextpic.Image = Properties.Resources.image_removebg_preview__7_3;
            nextpic.Location = new Point(582, 375);
            nextpic.Name = "nextpic";
            nextpic.Size = new Size(55, 36);
            nextpic.SizeMode = PictureBoxSizeMode.StretchImage;
            nextpic.TabIndex = 26;
            nextpic.TabStop = false;
            nextpic.Click += nextpic_Click;
            // 
            // Speakers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_11_21_162226;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(nextpic);
            Controls.Add(backpic);
            Controls.Add(label5);
            Controls.Add(emailTb);
            Controls.Add(contactBtn);
            Controls.Add(contactTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(firstNameTb);
            Controls.Add(lastNameTb);
            DoubleBuffered = true;
            Name = "Speakers";
            Size = new Size(640, 425);
            ((System.ComponentModel.ISupportInitialize)backpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextpic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox firstNameTb;
        private TextBox lastNameTb;
        private Label contactBtn;
        private TextBox contactTb;
        private Label label5;
        private TextBox emailTb;
        private PictureBox backpic;
        private PictureBox nextpic;
    }
}
