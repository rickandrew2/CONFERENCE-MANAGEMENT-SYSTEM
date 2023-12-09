namespace Conference_Management_System
{
    partial class Session
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Session));
            dateAndTime = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            titleTb = new TextBox();
            pictureBox2 = new PictureBox();
            backpic = new PictureBox();
            descriptionRTB = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backpic).BeginInit();
            SuspendLayout();
            // 
            // dateAndTime
            // 
            dateAndTime.CalendarFont = new Font("Segoe UI", 4.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateAndTime.Location = new Point(259, 293);
            dateAndTime.Name = "dateAndTime";
            dateAndTime.Size = new Size(259, 27);
            dateAndTime.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(77, 293);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 41;
            label4.Text = "Date and Time :";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 175);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 39;
            label2.Text = "Description :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 143);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 38;
            label1.Text = "Title :";
            // 
            // titleTb
            // 
            titleTb.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            titleTb.Location = new Point(259, 138);
            titleTb.Name = "titleTb";
            titleTb.Size = new Size(259, 30);
            titleTb.TabIndex = 36;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.image_removebg_preview__7_1;
            pictureBox2.Location = new Point(577, 372);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // backpic
            // 
            backpic.BackColor = Color.Transparent;
            backpic.ErrorImage = (Image)resources.GetObject("backpic.ErrorImage");
            backpic.Image = Properties.Resources.image_removebg_preview__5_2;
            backpic.Location = new Point(523, 372);
            backpic.Name = "backpic";
            backpic.Size = new Size(48, 36);
            backpic.SizeMode = PictureBoxSizeMode.StretchImage;
            backpic.TabIndex = 44;
            backpic.TabStop = false;
            backpic.Click += pictureBox1_Click;
            // 
            // descriptionRTB
            // 
            descriptionRTB.Location = new Point(259, 185);
            descriptionRTB.Name = "descriptionRTB";
            descriptionRTB.Size = new Size(259, 102);
            descriptionRTB.TabIndex = 46;
            descriptionRTB.Text = "";
            descriptionRTB.TextChanged += descriptionRTB_TextChanged;
            // 
            // Session
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_11_21_164059;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(descriptionRTB);
            Controls.Add(pictureBox2);
            Controls.Add(backpic);
            Controls.Add(dateAndTime);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(titleTb);
            DoubleBuffered = true;
            Name = "Session";
            Size = new Size(638, 424);
            Load += Session_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)backpic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateAndTime;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox titleTb;
        private PictureBox pictureBox2;
        private PictureBox backpic;
        private RichTextBox descriptionRTB;
    }
}
