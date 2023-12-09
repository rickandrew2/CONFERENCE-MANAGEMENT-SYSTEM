namespace Conference_Management_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            dataGridViewMyAllData = new DataGridView();
            updateBtn = new Button();
            pictureBox1 = new PictureBox();
            deleteBtn = new Button();
            txtScheduleID = new TextBox();
            txtUserID = new TextBox();
            txtSessionID = new TextBox();
            txtSessionName = new TextBox();
            txtVenueName = new TextBox();
            txtConferenceStatus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            insertBtn = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyAllData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMyAllData
            // 
            dataGridViewMyAllData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMyAllData.Location = new Point(85, 177);
            dataGridViewMyAllData.Name = "dataGridViewMyAllData";
            dataGridViewMyAllData.RowHeadersWidth = 51;
            dataGridViewMyAllData.RowTemplate.Height = 29;
            dataGridViewMyAllData.Size = new Size(628, 261);
            dataGridViewMyAllData.TabIndex = 0;
            dataGridViewMyAllData.CellContentClick += dataGridViewMyAllData_CellContentClick;
            dataGridViewMyAllData.RowHeaderMouseClick += dataGridViewMyAllData_RowHeaderMouseClick;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(738, 274);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(124, 38);
            updateBtn.TabIndex = 7;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(787, 446);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(738, 329);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(124, 38);
            deleteBtn.TabIndex = 13;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // txtScheduleID
            // 
            txtScheduleID.Location = new Point(95, 122);
            txtScheduleID.Name = "txtScheduleID";
            txtScheduleID.ReadOnly = true;
            txtScheduleID.Size = new Size(69, 27);
            txtScheduleID.TabIndex = 15;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(708, 122);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(63, 27);
            txtUserID.TabIndex = 16;
            // 
            // txtSessionID
            // 
            txtSessionID.Location = new Point(627, 122);
            txtSessionID.Name = "txtSessionID";
            txtSessionID.ReadOnly = true;
            txtSessionID.Size = new Size(69, 27);
            txtSessionID.TabIndex = 17;
            // 
            // txtSessionName
            // 
            txtSessionName.Location = new Point(201, 122);
            txtSessionName.Name = "txtSessionName";
            txtSessionName.Size = new Size(114, 27);
            txtSessionName.TabIndex = 18;
            // 
            // txtVenueName
            // 
            txtVenueName.Location = new Point(330, 122);
            txtVenueName.Name = "txtVenueName";
            txtVenueName.Size = new Size(125, 27);
            txtVenueName.TabIndex = 19;
            // 
            // txtConferenceStatus
            // 
            txtConferenceStatus.Location = new Point(483, 122);
            txtConferenceStatus.Name = "txtConferenceStatus";
            txtConferenceStatus.Size = new Size(125, 27);
            txtConferenceStatus.TabIndex = 20;
            txtConferenceStatus.TextChanged += textBox6_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(85, 83);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 21;
            label1.Text = "Schedule ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(708, 83);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 22;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(619, 83);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 23;
            label3.Text = "Session ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(201, 83);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 24;
            label4.Text = "Session Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(340, 83);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 25;
            label5.Text = "Venue Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(480, 83);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 26;
            label6.Text = "Conference Status";
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(738, 220);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(124, 38);
            insertBtn.TabIndex = 27;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.SCHEDUL_WEBSITE_DESIGN__3_2;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(886, 505);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 505);
            Controls.Add(insertBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConferenceStatus);
            Controls.Add(txtVenueName);
            Controls.Add(txtSessionName);
            Controls.Add(txtSessionID);
            Controls.Add(txtUserID);
            Controls.Add(txtScheduleID);
            Controls.Add(deleteBtn);
            Controls.Add(pictureBox1);
            Controls.Add(updateBtn);
            Controls.Add(dataGridViewMyAllData);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyAllData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMyAllData;
        private Button updateBtn;
        private PictureBox pictureBox1;
        private Button deleteBtn;
        private TextBox txtScheduleID;
        private TextBox txtUserID;
        private TextBox txtSessionID;
        private TextBox txtSessionName;
        private TextBox txtVenueName;
        private TextBox txtConferenceStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button insertBtn;
        private PictureBox pictureBox2;
    }
}