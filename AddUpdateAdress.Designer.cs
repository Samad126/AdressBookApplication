namespace AdressBookApplication
{
    partial class AddUpdateAdress
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
        // AddAddressForm.Designer.cs
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            addressPanel = new Panel();
            lblStreet = new Label();
            lblCountry = new Label();
            lblCity = new Label();
            txtStreet = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            addressPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(51, 53, 61);
            lblTitle.Location = new Point(26, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Address";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(354, 382);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 37);
            btnSave.TabIndex = 7;
            btnSave.Text = "OK";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.FromArgb(51, 53, 61);
            btnCancel.Location = new Point(248, 382);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 37);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // addressPanel
            // 
            addressPanel.Controls.Add(lblStreet);
            addressPanel.Controls.Add(lblCountry);
            addressPanel.Controls.Add(lblCity);
            addressPanel.Controls.Add(txtStreet);
            addressPanel.Controls.Add(txtCountry);
            addressPanel.Controls.Add(txtCity);
            addressPanel.Location = new Point(12, 78);
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
            // AddUpdateAdress
            // 
            ClientSize = new Size(454, 444);
            Controls.Add(addressPanel);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddUpdateAdress";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Address";
            addressPanel.ResumeLayout(false);
            addressPanel.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Label lblTitle;

        private Button btnSave;
        private Button btnCancel;
        private Panel addressPanel;
        private Label lblStreet;
        private Label lblCountry;
        private Label lblCity;
        private TextBox txtStreet;
        private TextBox txtCountry;
        private TextBox txtCity;
    }
}