namespace AdressBookApplication
{
    partial class Main
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            dataGridView1 = new DataGridView();
            first_name = new DataGridViewTextBoxColumn();
            last_name = new DataGridViewTextBoxColumn();
            nickname = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            birthday = new DataGridViewTextBoxColumn();
            removeContactBtn = new Button();
            updateContactBtn = new Button();
            addContactBtn = new Button();
            headerPanel = new Panel();
            userPanelWrapper = new Panel();
            userNameLabel = new Label();
            logoutWrapperPanel = new Panel();
            logoutLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            mainLabel = new Label();
            addressSwitcherBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            headerPanel.SuspendLayout();
            userPanelWrapper.SuspendLayout();
            logoutWrapperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { first_name, last_name, nickname, email, phone, birthday });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = SystemColors.ControlLightLight;
            dataGridView1.Location = new Point(12, 231);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1135, 441);
            dataGridView1.TabIndex = 10;
            // 
            // first_name
            // 
            first_name.HeaderText = "Name";
            first_name.MinimumWidth = 6;
            first_name.Name = "first_name";
            // 
            // last_name
            // 
            last_name.HeaderText = "Surname";
            last_name.MinimumWidth = 6;
            last_name.Name = "last_name";
            // 
            // nickname
            // 
            nickname.HeaderText = "Nickname";
            nickname.MinimumWidth = 6;
            nickname.Name = "nickname";
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            // 
            // phone
            // 
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            // 
            // birthday
            // 
            birthday.HeaderText = "Birthday";
            birthday.MinimumWidth = 6;
            birthday.Name = "birthday";
            // 
            // removeContactBtn
            // 
            removeContactBtn.BackColor = SystemColors.ControlLightLight;
            removeContactBtn.Cursor = Cursors.Hand;
            removeContactBtn.FlatAppearance.BorderSize = 0;
            removeContactBtn.FlatStyle = FlatStyle.Flat;
            removeContactBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            removeContactBtn.ForeColor = Color.FromArgb(51, 53, 61);
            removeContactBtn.Location = new Point(285, 148);
            removeContactBtn.Name = "removeContactBtn";
            removeContactBtn.Size = new Size(100, 42);
            removeContactBtn.TabIndex = 9;
            removeContactBtn.Text = "Remove";
            removeContactBtn.UseVisualStyleBackColor = false;
            removeContactBtn.Click += removItem_Click;
            // 
            // updateContactBtn
            // 
            updateContactBtn.BackColor = SystemColors.ControlLightLight;
            updateContactBtn.Cursor = Cursors.Hand;
            updateContactBtn.FlatAppearance.BorderSize = 0;
            updateContactBtn.FlatStyle = FlatStyle.Flat;
            updateContactBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            updateContactBtn.ForeColor = Color.FromArgb(51, 53, 61);
            updateContactBtn.Location = new Point(168, 148);
            updateContactBtn.Name = "updateContactBtn";
            updateContactBtn.Size = new Size(101, 42);
            updateContactBtn.TabIndex = 8;
            updateContactBtn.Text = "Update";
            updateContactBtn.UseVisualStyleBackColor = false;
            updateContactBtn.Click += updateItem_Click;
            // 
            // addContactBtn
            // 
            addContactBtn.BackColor = SystemColors.Highlight;
            addContactBtn.Cursor = Cursors.Hand;
            addContactBtn.FlatAppearance.BorderSize = 0;
            addContactBtn.FlatStyle = FlatStyle.Flat;
            addContactBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            addContactBtn.ForeColor = Color.White;
            addContactBtn.Location = new Point(25, 148);
            addContactBtn.Name = "addContactBtn";
            addContactBtn.Size = new Size(130, 42);
            addContactBtn.TabIndex = 7;
            addContactBtn.Text = "New +";
            addContactBtn.UseVisualStyleBackColor = false;
            addContactBtn.Click += addItem_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = SystemColors.ControlLightLight;
            headerPanel.Controls.Add(userPanelWrapper);
            headerPanel.Controls.Add(mainLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1159, 109);
            headerPanel.TabIndex = 11;
            headerPanel.Tag = "asd";
            // 
            // userPanelWrapper
            // 
            userPanelWrapper.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userPanelWrapper.Controls.Add(userNameLabel);
            userPanelWrapper.Controls.Add(logoutWrapperPanel);
            userPanelWrapper.Controls.Add(pictureBox1);
            userPanelWrapper.Location = new Point(731, 33);
            userPanelWrapper.Name = "userPanelWrapper";
            userPanelWrapper.Size = new Size(396, 45);
            userPanelWrapper.TabIndex = 5;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userNameLabel.Location = new Point(50, 9);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(166, 28);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "Samad Alakbarov";
            userNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // logoutWrapperPanel
            // 
            logoutWrapperPanel.Controls.Add(logoutLabel);
            logoutWrapperPanel.Controls.Add(pictureBox2);
            logoutWrapperPanel.Cursor = Cursors.Hand;
            logoutWrapperPanel.Location = new Point(257, 2);
            logoutWrapperPanel.Name = "logoutWrapperPanel";
            logoutWrapperPanel.Size = new Size(131, 41);
            logoutWrapperPanel.TabIndex = 4;
            logoutWrapperPanel.Click += logoutPanelClick;
            // 
            // logoutLabel
            // 
            logoutLabel.AutoSize = true;
            logoutLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logoutLabel.Location = new Point(4, 6);
            logoutLabel.Name = "logoutLabel";
            logoutLabel.Size = new Size(75, 28);
            logoutLabel.TabIndex = 1;
            logoutLabel.Text = "Logout";
            logoutLabel.Click += logoutLabel_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoutimg;
            pictureBox2.Location = new Point(85, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 28);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ppImage;
            pictureBox1.Location = new Point(7, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 35);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            mainLabel.ForeColor = Color.FromArgb(51, 53, 61);
            mainLabel.Location = new Point(25, 33);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(247, 41);
            mainLabel.TabIndex = 1;
            mainLabel.Text = "Contact Manager";
            // 
            // addressSwitcherBtn
            // 
            addressSwitcherBtn.BackColor = SystemColors.ControlLightLight;
            addressSwitcherBtn.Cursor = Cursors.Hand;
            addressSwitcherBtn.FlatAppearance.BorderSize = 0;
            addressSwitcherBtn.FlatStyle = FlatStyle.Flat;
            addressSwitcherBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            addressSwitcherBtn.ForeColor = Color.FromArgb(51, 53, 61);
            addressSwitcherBtn.Location = new Point(402, 148);
            addressSwitcherBtn.Name = "addressSwitcherBtn";
            addressSwitcherBtn.Size = new Size(185, 42);
            addressSwitcherBtn.TabIndex = 12;
            addressSwitcherBtn.Text = "View Adress";
            addressSwitcherBtn.UseVisualStyleBackColor = false;
            addressSwitcherBtn.Click += addressSwitcherBtn_Click;
            // 
            // Contacts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 684);
            Controls.Add(addressSwitcherBtn);
            Controls.Add(dataGridView1);
            Controls.Add(removeContactBtn);
            Controls.Add(updateContactBtn);
            Controls.Add(addContactBtn);
            Controls.Add(headerPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1177, 731);
            Name = "Contacts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contacts";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            userPanelWrapper.ResumeLayout(false);
            userPanelWrapper.PerformLayout();
            logoutWrapperPanel.ResumeLayout(false);
            logoutWrapperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button removeContactBtn;
        private Button updateContactBtn;
        private Button addContactBtn;
        private Panel headerPanel;
        private Label mainLabel;
        private Button addressSwitcherBtn;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn nickname;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn birthday;
        private Label userNameLabel;
        private PictureBox pictureBox1;
        private Panel logoutWrapperPanel;
        private Label logoutLabel;
        private PictureBox pictureBox2;
        private Panel userPanelWrapper;
    }
}