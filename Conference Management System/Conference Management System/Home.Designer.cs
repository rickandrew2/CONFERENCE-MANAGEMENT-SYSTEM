namespace Conference_Management_System
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            attendeesBtn = new Button();
            speakerBtn = new Button();
            exitPic = new PictureBox();
            sponsorsBtn = new Button();
            venueBtn = new Button();
            sessionBtn = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            bindingSource1 = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            sponsor1 = new Sponsor();
            venues1 = new Venues();
            session1 = new Session();
            attendees1 = new Attendees();
            speakers1 = new Speakers();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exitPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(attendeesBtn);
            panel1.Controls.Add(speakerBtn);
            panel1.Controls.Add(exitPic);
            panel1.Controls.Add(sponsorsBtn);
            panel1.Controls.Add(venueBtn);
            panel1.Controls.Add(sessionBtn);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 420);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // attendeesBtn
            // 
            attendeesBtn.Location = new Point(12, 188);
            attendeesBtn.Name = "attendeesBtn";
            attendeesBtn.Size = new Size(147, 29);
            attendeesBtn.TabIndex = 12;
            attendeesBtn.Text = "Attendees ";
            attendeesBtn.UseVisualStyleBackColor = true;
            attendeesBtn.Click += attendeesBtn_Click;
            // 
            // speakerBtn
            // 
            speakerBtn.Location = new Point(12, 141);
            speakerBtn.Name = "speakerBtn";
            speakerBtn.Size = new Size(147, 29);
            speakerBtn.TabIndex = 11;
            speakerBtn.Text = "Speaker";
            speakerBtn.UseVisualStyleBackColor = true;
            speakerBtn.Click += speakerBtn_Click;
            // 
            // exitPic
            // 
            exitPic.Image = (Image)resources.GetObject("exitPic.Image");
            exitPic.Location = new Point(36, 368);
            exitPic.Name = "exitPic";
            exitPic.Size = new Size(75, 47);
            exitPic.SizeMode = PictureBoxSizeMode.StretchImage;
            exitPic.TabIndex = 10;
            exitPic.TabStop = false;
            exitPic.Click += exitPic_Click;
            // 
            // sponsorsBtn
            // 
            sponsorsBtn.Location = new Point(13, 331);
            sponsorsBtn.Name = "sponsorsBtn";
            sponsorsBtn.Size = new Size(147, 29);
            sponsorsBtn.TabIndex = 7;
            sponsorsBtn.Text = "Sponsors";
            sponsorsBtn.UseVisualStyleBackColor = true;
            sponsorsBtn.Click += sponsorsBtn_Click;
            // 
            // venueBtn
            // 
            venueBtn.Location = new Point(12, 287);
            venueBtn.Name = "venueBtn";
            venueBtn.Size = new Size(147, 29);
            venueBtn.TabIndex = 8;
            venueBtn.Text = "Venue";
            venueBtn.UseVisualStyleBackColor = true;
            venueBtn.Click += venueBtn_Click;
            // 
            // sessionBtn
            // 
            sessionBtn.Location = new Point(13, 237);
            sessionBtn.Name = "sessionBtn";
            sessionBtn.Size = new Size(147, 29);
            sessionBtn.TabIndex = 7;
            sessionBtn.Text = "Session";
            sessionBtn.UseVisualStyleBackColor = true;
            sessionBtn.Click += sessionBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(12, 96);
            button2.Name = "button2";
            button2.Size = new Size(147, 29);
            button2.TabIndex = 4;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkSlateGray;
            pictureBox2.Image = Properties.Resources.Screenshot_2023_11_21_170910;
            pictureBox2.Location = new Point(741, 357);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.SCHEDUL_WEBSITE_DESIGN__5_;
            pictureBox3.Location = new Point(-30, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(833, 420);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // sponsor1
            // 
            sponsor1.BackgroundImage = (Image)resources.GetObject("sponsor1.BackgroundImage");
            sponsor1.BackgroundImageLayout = ImageLayout.Stretch;
            sponsor1.Location = new Point(166, -16);
            sponsor1.Name = "sponsor1";
            sponsor1.Size = new Size(645, 436);
            sponsor1.TabIndex = 13;
            // 
            // venues1
            // 
            venues1.BackgroundImage = (Image)resources.GetObject("venues1.BackgroundImage");
            venues1.BackgroundImageLayout = ImageLayout.Stretch;
            venues1.Location = new Point(166, 0);
            venues1.Name = "venues1";
            venues1.Size = new Size(645, 420);
            venues1.TabIndex = 14;
            // 
            // session1
            // 
            session1.BackgroundImage = (Image)resources.GetObject("session1.BackgroundImage");
            session1.BackgroundImageLayout = ImageLayout.Stretch;
            session1.Location = new Point(165, 0);
            session1.Name = "session1";
            session1.Size = new Size(645, 420);
            session1.TabIndex = 15;
            // 
            // attendees1
            // 
            attendees1.BackgroundImage = (Image)resources.GetObject("attendees1.BackgroundImage");
            attendees1.BackgroundImageLayout = ImageLayout.Stretch;
            attendees1.Location = new Point(165, 0);
            attendees1.Name = "attendees1";
            attendees1.Size = new Size(646, 420);
            attendees1.sponsor = null;
            attendees1.TabIndex = 16;
            // 
            // speakers1
            // 
            speakers1.BackgroundImage = (Image)resources.GetObject("speakers1.BackgroundImage");
            speakers1.BackgroundImageLayout = ImageLayout.Stretch;
            speakers1.Location = new Point(166, -3);
            speakers1.Name = "speakers1";
            speakers1.Size = new Size(644, 423);
            speakers1.TabIndex = 17;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(807, 420);
            Controls.Add(speakers1);
            Controls.Add(attendees1);
            Controls.Add(session1);
            Controls.Add(venues1);
            Controls.Add(sponsor1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)exitPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button sponsorsBtn;
        private Button venueBtn;
        private Button sessionBtn;
        private Button button2;
        private PictureBox exitPic;
        private PictureBox pictureBox2;
        private Button speakerBtn;
        private Speakers speakers2;
        private Button attendeesBtn;
        private PictureBox pictureBox3;
        private BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Sponsor sponsor1;
        private Venues venues1;
        private Session session1;
        private Attendees attendees1;
        private Speakers speakers1;
    }
}