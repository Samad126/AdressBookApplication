namespace AdressBookApplication
{
    partial class Adress
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            addAddressBtn = new Button();
            updateAddressBtn = new Button();
            removeAddressBtn = new Button();
            dataGridView1 = new DataGridView();
            Street = new DataGridViewTextBoxColumn();
            country = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            logoutLabel = new Label();
            pictureBox2 = new PictureBox();
            userNameLabel = new Label();
            pictureBox1 = new PictureBox();
            adress_label = new Label();
            backContacts = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addAddressBtn
            // 
            addAddressBtn.BackColor = SystemColors.Highlight;
            addAddressBtn.FlatAppearance.BorderSize = 0;
            addAddressBtn.FlatStyle = FlatStyle.Flat;
            addAddressBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            addAddressBtn.ForeColor = Color.White;
            addAddressBtn.Location = new Point(26, 143);
            addAddressBtn.Name = "addAddressBtn";
            addAddressBtn.Size = new Size(123, 42);
            addAddressBtn.TabIndex = 0;
            addAddressBtn.Text = "+  New";
            addAddressBtn.UseVisualStyleBackColor = false;
            addAddressBtn.Click += addAddressBtn_Click;
            // 
            // updateAddressBtn
            // 
            updateAddressBtn.BackColor = SystemColors.ControlLightLight;
            updateAddressBtn.FlatAppearance.BorderSize = 0;
            updateAddressBtn.FlatStyle = FlatStyle.Flat;
            updateAddressBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            updateAddressBtn.ForeColor = Color.FromArgb(51, 53, 61);
            updateAddressBtn.Location = new Point(181, 143);
            updateAddressBtn.Name = "updateAddressBtn";
            updateAddressBtn.Size = new Size(101, 42);
            updateAddressBtn.TabIndex = 1;
            updateAddressBtn.Text = "Update";
            updateAddressBtn.UseVisualStyleBackColor = false;
            updateAddressBtn.Click += updateAddressBtn_Click;
            // 
            // removeAddressBtn
            // 
            removeAddressBtn.BackColor = SystemColors.ControlLightLight;
            removeAddressBtn.FlatAppearance.BorderSize = 0;
            removeAddressBtn.FlatStyle = FlatStyle.Flat;
            removeAddressBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            removeAddressBtn.ForeColor = Color.FromArgb(51, 53, 61);
            removeAddressBtn.Location = new Point(306, 143);
            removeAddressBtn.Name = "removeAddressBtn";
            removeAddressBtn.Size = new Size(99, 42);
            removeAddressBtn.TabIndex = 2;
            removeAddressBtn.Text = "Remove";
            removeAddressBtn.UseVisualStyleBackColor = false;
            removeAddressBtn.Click += removeAddressBtn_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Street, country, City });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Location = new Point(12, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1135, 452);
            dataGridView1.TabIndex = 5;
            // 
            // Street
            // 
            Street.HeaderText = "Street";
            Street.MinimumWidth = 6;
            Street.Name = "Street";
            Street.ReadOnly = true;
            // 
            // country
            // 
            country.HeaderText = "Country";
            country.MinimumWidth = 6;
            country.Name = "country";
            country.ReadOnly = true;
            // 
            // City
            // 
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            City.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(userNameLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(adress_label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 107);
            panel1.TabIndex = 6;
            panel1.Tag = "asd";
            // 
            // panel2
            // 
            panel2.Controls.Add(logoutLabel);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(991, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(131, 41);
            panel2.TabIndex = 7;
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
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoutimg;
            pictureBox2.Location = new Point(85, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 28);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userNameLabel.Location = new Point(726, 43);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(166, 28);
            userNameLabel.TabIndex = 6;
            userNameLabel.Text = "Samad Alakbarov";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ppImage;
            pictureBox1.Location = new Point(898, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 35);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // adress_label
            // 
            adress_label.AutoSize = true;
            adress_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            adress_label.ForeColor = Color.FromArgb(51, 53, 61);
            adress_label.Location = new Point(29, 33);
            adress_label.Name = "adress_label";
            adress_label.Size = new Size(251, 41);
            adress_label.TabIndex = 1;
            adress_label.Text = "Address Manager";
            // 
            // backContacts
            // 
            backContacts.BackColor = SystemColors.ControlLightLight;
            backContacts.FlatAppearance.BorderSize = 0;
            backContacts.FlatStyle = FlatStyle.Flat;
            backContacts.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            backContacts.ForeColor = Color.FromArgb(51, 53, 61);
            backContacts.Location = new Point(433, 143);
            backContacts.Name = "backContacts";
            backContacts.Size = new Size(163, 42);
            backContacts.TabIndex = 7;
            backContacts.Text = "Back to Contacts";
            backContacts.UseVisualStyleBackColor = false;
            backContacts.Click += backContacts_Click;
            // 
            // Adress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1159, 684);
            Controls.Add(backContacts);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(removeAddressBtn);
            Controls.Add(updateAddressBtn);
            Controls.Add(addAddressBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Adress";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Adress_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button addAddressBtn;
        private Button updateAddressBtn;
        private Button removeAddressBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Street;
        private DataGridViewTextBoxColumn country;
        private DataGridViewTextBoxColumn City;
        private Panel panel1;
        private Label adress_label;
        private Button backContacts;
        private Panel panel2;
        private Label logoutLabel;
        private PictureBox pictureBox2;
        private Label userNameLabel;
        private PictureBox pictureBox1;
    }
}