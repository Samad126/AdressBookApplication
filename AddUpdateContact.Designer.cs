namespace AdressBookApplication
{
    partial class AddUpdateContact
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
        // AddContactForm.Designer.cs
        private void InitializeComponent()
        {
            addressPanel = new Panel();
            lblStreet = new Label();
            lblCountry = new Label();
            lblCity = new Label();
            txtStreet = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            contactPanel = new Panel();
            lblName = new Label();
            lblSurname = new Label();
            lblNickname = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblBirthday = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtNickname = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            dtpBirthday = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            addressPanel.SuspendLayout();
            contactPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addressPanel
            // 
            addressPanel.Controls.Add(lblStreet);
            addressPanel.Controls.Add(lblCountry);
            addressPanel.Controls.Add(lblCity);
            addressPanel.Controls.Add(txtStreet);
            addressPanel.Controls.Add(txtCountry);
            addressPanel.Controls.Add(txtCity);
            addressPanel.Location = new Point(27, 60);
            addressPanel.Name = "addressPanel";
            addressPanel.Size = new Size(386, 254);
            addressPanel.TabIndex = 9;
            // 
            // lblStreet
            // 
            lblStreet.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblStreet.Location = new Point(14, 13);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(74, 23);
            lblStreet.TabIndex = 7;
            lblStreet.Text = "Street:";
            // 
            // lblCountry
            // 
            lblCountry.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountry.Location = new Point(14, 92);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(95, 23);
            lblCountry.TabIndex = 8;
            lblCountry.Text = "Country:";
            // 
            // lblCity
            // 
            lblCity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCity.Location = new Point(14, 178);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(48, 23);
            lblCity.TabIndex = 9;
            lblCity.Text = "City:";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(14, 39);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(352, 27);
            txtStreet.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(14, 120);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(352, 27);
            txtCountry.TabIndex = 11;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(14, 206);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(352, 27);
            txtCity.TabIndex = 12;
            // 
            // contactPanel
            // 
            contactPanel.Controls.Add(lblName);
            contactPanel.Controls.Add(lblSurname);
            contactPanel.Controls.Add(lblNickname);
            contactPanel.Controls.Add(lblEmail);
            contactPanel.Controls.Add(lblPhone);
            contactPanel.Controls.Add(lblBirthday);
            contactPanel.Controls.Add(txtName);
            contactPanel.Controls.Add(txtSurname);
            contactPanel.Controls.Add(txtNickname);
            contactPanel.Controls.Add(txtEmail);
            contactPanel.Controls.Add(txtPhone);
            contactPanel.Controls.Add(dtpBirthday);
            contactPanel.Location = new Point(12, 73);
            contactPanel.Name = "contactPanel";
            contactPanel.Size = new Size(383, 449);
            contactPanel.TabIndex = 0;
            contactPanel.Visible = false;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(29, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 27);
            lblName.TabIndex = 16;
            lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            lblSurname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurname.Location = new Point(29, 83);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(105, 25);
            lblSurname.TabIndex = 17;
            lblSurname.Text = "Surname:";
            // 
            // lblNickname
            // 
            lblNickname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNickname.Location = new Point(29, 160);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(105, 23);
            lblNickname.TabIndex = 18;
            lblNickname.Text = "Nickname:";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(29, 237);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(74, 23);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(26, 313);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(74, 23);
            lblPhone.TabIndex = 20;
            lblPhone.Text = "Phone:";
            // 
            // lblBirthday
            // 
            lblBirthday.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthday.Location = new Point(29, 382);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(105, 23);
            lblBirthday.TabIndex = 21;
            lblBirthday.Text = "Birthday:";
            // 
            // txtName
            // 
            txtName.Location = new Point(29, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(337, 27);
            txtName.TabIndex = 22;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(29, 111);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(337, 27);
            txtSurname.TabIndex = 23;
            // 
            // txtNickname
            // 
            txtNickname.Location = new Point(29, 186);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(337, 27);
            txtNickname.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(29, 263);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(337, 27);
            txtEmail.TabIndex = 25;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(26, 339);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(337, 27);
            txtPhone.TabIndex = 26;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(29, 409);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(337, 27);
            dtpBirthday.TabIndex = 27;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(209, 556);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 30;
            btnSave.Text = "OK";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(51, 53, 61);
            btnCancel.Location = new Point(315, 556);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 30);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(51, 53, 61);
            lblTitle.Location = new Point(38, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 30);
            lblTitle.TabIndex = 32;
            lblTitle.Text = "Add Contact";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddUpdateContact
            // 
            ClientSize = new Size(420, 609);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(contactPanel);
            Controls.Add(addressPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddUpdateContact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Contact";
            addressPanel.ResumeLayout(false);
            addressPanel.PerformLayout();
            contactPanel.ResumeLayout(false);
            contactPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel addressPanel;
        private Panel contactPanel;
        private Label lblName;
        private Label lblSurname;
        private Label lblNickname;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblBirthday;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtNickname;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private DateTimePicker dtpBirthday;
        private Label lblStreet;
        private Label lblCountry;
        private Label lblCity;
        private TextBox txtStreet;
        private TextBox txtCountry;
        private TextBox txtCity;
        private Button btnSave;
        private Button btnCancel;
        private Label lblTitle;
    }
}