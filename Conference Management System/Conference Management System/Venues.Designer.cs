namespace Conference_Management_System
{
    partial class Venues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venues));
            label2 = new Label();
            label3 = new Label();
            nextpic = new PictureBox();
            backpic = new PictureBox();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            locationTb = new TextBox();
            venueNameTb = new TextBox();
            domainUpDownCapacity = new DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)nextpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backpic).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(114, 207);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Location ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(114, 269);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Capacity : ";
            // 
            // nextpic
            // 
            nextpic.BackColor = Color.Transparent;
            nextpic.Image = Properties.Resources.image_removebg_preview__7_;
            nextpic.Location = new Point(582, 371);
            nextpic.Name = "nextpic";
            nextpic.Size = new Size(53, 41);
            nextpic.SizeMode = PictureBoxSizeMode.StretchImage;
            nextpic.TabIndex = 36;
            nextpic.TabStop = false;
            nextpic.Click += nextpic_Click;
            // 
            // backpic
            // 
            backpic.BackColor = Color.Transparent;
            backpic.ErrorImage = (Image)resources.GetObject("backpic.ErrorImage");
            backpic.Image = Properties.Resources.image_removebg_preview__5_3;
            backpic.Location = new Point(525, 371);
            backpic.Name = "backpic";
            backpic.Size = new Size(51, 41);
            backpic.SizeMode = PictureBoxSizeMode.StretchImage;
            backpic.TabIndex = 35;
            backpic.TabStop = false;
            backpic.Click += backpic_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(97, 263);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 32;
            label4.Text = "Capacity :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(97, 210);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 29;
            label7.Text = "Location :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(97, 161);
            label8.Name = "label8";
            label8.Size = new Size(134, 25);
            label8.TabIndex = 28;
            label8.Text = "Venue's Name :";
            // 
            // locationTb
            // 
            locationTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            locationTb.Location = new Point(279, 209);
            locationTb.Name = "locationTb";
            locationTb.Size = new Size(219, 30);
            locationTb.TabIndex = 27;
            // 
            // venueNameTb
            // 
            venueNameTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            venueNameTb.Location = new Point(279, 160);
            venueNameTb.Name = "venueNameTb";
            venueNameTb.Size = new Size(219, 30);
            venueNameTb.TabIndex = 26;
            // 
            // domainUpDownCapacity
            // 
            domainUpDownCapacity.Location = new Point(279, 265);
            domainUpDownCapacity.Name = "domainUpDownCapacity";
            domainUpDownCapacity.Size = new Size(219, 27);
            domainUpDownCapacity.TabIndex = 37;
            domainUpDownCapacity.Text = "select up to 500";
            domainUpDownCapacity.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // Venues
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_11_21_165214;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(domainUpDownCapacity);
            Controls.Add(nextpic);
            Controls.Add(backpic);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(locationTb);
            Controls.Add(venueNameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "Venues";
            Size = new Size(638, 424);
            Load += Venues_Load;
            ((System.ComponentModel.ISupportInitialize)nextpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)backpic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private PictureBox nextpic;
        private PictureBox backpic;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox locationTb;
        private TextBox venueNameTb;
        private DomainUpDown domainUpDownCapacity;
    }
}
