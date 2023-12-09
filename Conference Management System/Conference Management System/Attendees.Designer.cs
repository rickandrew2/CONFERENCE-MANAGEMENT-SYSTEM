namespace Conference_Management_System
{
    partial class Attendees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendees));
            typeAttendeesTb = new TextBox();
            orgNameTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            affiliationTb = new TextBox();
            label4 = new Label();
            contactNumTb = new TextBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // typeAttendeesTb
            // 
            typeAttendeesTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            typeAttendeesTb.Location = new Point(326, 145);
            typeAttendeesTb.Name = "typeAttendeesTb";
            typeAttendeesTb.Size = new Size(219, 30);
            typeAttendeesTb.TabIndex = 25;
            // 
            // orgNameTb
            // 
            orgNameTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            orgNameTb.Location = new Point(326, 189);
            orgNameTb.Name = "orgNameTb";
            orgNameTb.Size = new Size(219, 30);
            orgNameTb.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 145);
            label1.Name = "label1";
            label1.Size = new Size(236, 25);
            label1.TabIndex = 27;
            label1.Text = "Type of Attendees               :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 189);
            label2.Name = "label2";
            label2.Size = new Size(237, 25);
            label2.TabIndex = 28;
            label2.Text = "Name of the Organization   :";
            // 
            // affiliationTb
            // 
            affiliationTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            affiliationTb.Location = new Point(326, 237);
            affiliationTb.Name = "affiliationTb";
            affiliationTb.Size = new Size(219, 30);
            affiliationTb.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 237);
            label4.Name = "label4";
            label4.Size = new Size(232, 25);
            label4.TabIndex = 31;
            label4.Text = "Contact Number                 :";
            // 
            // contactNumTb
            // 
            contactNumTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            contactNumTb.Location = new Point(326, 286);
            contactNumTb.Name = "contactNumTb";
            contactNumTb.Size = new Size(219, 30);
            contactNumTb.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 286);
            label5.Name = "label5";
            label5.Size = new Size(233, 25);
            label5.TabIndex = 33;
            label5.Text = "Email Address                     :";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.image_removebg_preview__7_2;
            pictureBox2.Location = new Point(584, 373);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = Properties.Resources.image_removebg_preview__5_1;
            pictureBox1.Location = new Point(527, 373);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Attendees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_11_21_163455;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(contactNumTb);
            Controls.Add(label4);
            Controls.Add(affiliationTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(orgNameTb);
            Controls.Add(typeAttendeesTb);
            DoubleBuffered = true;
            Name = "Attendees";
            Size = new Size(640, 425);
            Load += Attendees_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox typeAttendeesTb;
        private TextBox orgNameTb;
        private Label label1;
        private Label label2;
        private TextBox affiliationTb;
        private Label label4;
        private TextBox contactNumTb;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
