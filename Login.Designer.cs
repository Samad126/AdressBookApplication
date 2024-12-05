namespace AdressBookApplication
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            usrNameInp = new TextBox();
            passwrdInp = new TextBox();
            authButton = new Button();
            userNamePanel = new Panel();
            passwordPanel = new Panel();
            authSwitcher = new Button();
            loginPanelWrapper = new Panel();
            registerPanelWrapper = new Panel();
            emailRegPanel = new Panel();
            emailInp = new TextBox();
            reptPassPanel = new Panel();
            repeatPassInp = new TextBox();
            passwordRegPanel = new Panel();
            passInp = new TextBox();
            usernameRegPanel = new Panel();
            userNameInp = new TextBox();
            authLabel = new Label();
            extraMsg = new Label();
            pictureBox1 = new PictureBox();
            userNamePanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            loginPanelWrapper.SuspendLayout();
            registerPanelWrapper.SuspendLayout();
            emailRegPanel.SuspendLayout();
            reptPassPanel.SuspendLayout();
            passwordRegPanel.SuspendLayout();
            usernameRegPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usrNameInp
            // 
            usrNameInp.BorderStyle = BorderStyle.None;
            usrNameInp.Location = new Point(11, 14);
            usrNameInp.Name = "usrNameInp";
            usrNameInp.PlaceholderText = "Enter your username";
            usrNameInp.Size = new Size(297, 20);
            usrNameInp.TabIndex = 1;
            // 
            // passwrdInp
            // 
            passwrdInp.BorderStyle = BorderStyle.None;
            passwrdInp.Location = new Point(9, 16);
            passwrdInp.Name = "passwrdInp";
            passwrdInp.PlaceholderText = "Enter password";
            passwrdInp.Size = new Size(297, 20);
            passwrdInp.TabIndex = 2;
            passwrdInp.UseSystemPasswordChar = true;
            // 
            // authButton
            // 
            authButton.BackColor = Color.FromArgb(28, 104, 237);
            authButton.Cursor = Cursors.Hand;
            authButton.FlatAppearance.BorderSize = 0;
            authButton.FlatStyle = FlatStyle.Flat;
            authButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            authButton.ForeColor = Color.White;
            authButton.Location = new Point(544, 363);
            authButton.Name = "authButton";
            authButton.Size = new Size(323, 49);
            authButton.TabIndex = 3;
            authButton.Text = "Log in";
            authButton.UseVisualStyleBackColor = false;
            authButton.Click += authBtn_Click;
            // 
            // userNamePanel
            // 
            userNamePanel.BackColor = SystemColors.ControlLightLight;
            userNamePanel.Controls.Add(usrNameInp);
            userNamePanel.Location = new Point(9, 8);
            userNamePanel.Name = "userNamePanel";
            userNamePanel.Size = new Size(323, 51);
            userNamePanel.TabIndex = 4;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = SystemColors.ControlLightLight;
            passwordPanel.Controls.Add(passwrdInp);
            passwordPanel.Location = new Point(11, 82);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(323, 55);
            passwordPanel.TabIndex = 5;
            // 
            // authSwitcher
            // 
            authSwitcher.BackColor = SystemColors.Control;
            authSwitcher.Cursor = Cursors.Hand;
            authSwitcher.FlatAppearance.BorderSize = 0;
            authSwitcher.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            authSwitcher.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            authSwitcher.FlatStyle = FlatStyle.Flat;
            authSwitcher.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            authSwitcher.ForeColor = Color.FromArgb(28, 104, 237);
            authSwitcher.Location = new Point(791, 431);
            authSwitcher.Name = "authSwitcher";
            authSwitcher.Size = new Size(71, 32);
            authSwitcher.TabIndex = 7;
            authSwitcher.Text = "Sign Up";
            authSwitcher.UseVisualStyleBackColor = false;
            authSwitcher.Click += authSwitcher_Click;
            // 
            // loginPanelWrapper
            // 
            loginPanelWrapper.Controls.Add(passwordPanel);
            loginPanelWrapper.Controls.Add(userNamePanel);
            loginPanelWrapper.Location = new Point(530, 159);
            loginPanelWrapper.Name = "loginPanelWrapper";
            loginPanelWrapper.Size = new Size(346, 146);
            loginPanelWrapper.TabIndex = 8;
            // 
            // registerPanelWrapper
            // 
            registerPanelWrapper.Controls.Add(emailRegPanel);
            registerPanelWrapper.Controls.Add(reptPassPanel);
            registerPanelWrapper.Controls.Add(passwordRegPanel);
            registerPanelWrapper.Controls.Add(usernameRegPanel);
            registerPanelWrapper.Location = new Point(533, 128);
            registerPanelWrapper.Name = "registerPanelWrapper";
            registerPanelWrapper.Size = new Size(339, 216);
            registerPanelWrapper.TabIndex = 14;
            // 
            // emailRegPanel
            // 
            emailRegPanel.BackColor = SystemColors.ControlLightLight;
            emailRegPanel.Controls.Add(emailInp);
            emailRegPanel.Location = new Point(7, 57);
            emailRegPanel.Name = "emailRegPanel";
            emailRegPanel.Size = new Size(323, 39);
            emailRegPanel.TabIndex = 12;
            // 
            // emailInp
            // 
            emailInp.BorderStyle = BorderStyle.None;
            emailInp.Location = new Point(9, 9);
            emailInp.Name = "emailInp";
            emailInp.PlaceholderText = "Enter email";
            emailInp.Size = new Size(298, 20);
            emailInp.TabIndex = 1;
            // 
            // reptPassPanel
            // 
            reptPassPanel.BackColor = SystemColors.ControlLightLight;
            reptPassPanel.Controls.Add(repeatPassInp);
            reptPassPanel.Location = new Point(7, 164);
            reptPassPanel.Name = "reptPassPanel";
            reptPassPanel.Size = new Size(323, 39);
            reptPassPanel.TabIndex = 3;
            // 
            // repeatPassInp
            // 
            repeatPassInp.BorderStyle = BorderStyle.None;
            repeatPassInp.Location = new Point(9, 9);
            repeatPassInp.Name = "repeatPassInp";
            repeatPassInp.PlaceholderText = "Repeat password";
            repeatPassInp.Size = new Size(298, 20);
            repeatPassInp.TabIndex = 3;
            repeatPassInp.UseSystemPasswordChar = true;
            // 
            // passwordRegPanel
            // 
            passwordRegPanel.BackColor = SystemColors.ControlLightLight;
            passwordRegPanel.Controls.Add(passInp);
            passwordRegPanel.Location = new Point(7, 111);
            passwordRegPanel.Name = "passwordRegPanel";
            passwordRegPanel.Size = new Size(323, 39);
            passwordRegPanel.TabIndex = 2;
            // 
            // passInp
            // 
            passInp.BorderStyle = BorderStyle.None;
            passInp.Location = new Point(9, 9);
            passInp.Name = "passInp";
            passInp.PlaceholderText = "Enter password";
            passInp.Size = new Size(298, 20);
            passInp.TabIndex = 2;
            passInp.UseSystemPasswordChar = true;
            // 
            // usernameRegPanel
            // 
            usernameRegPanel.BackColor = SystemColors.ControlLightLight;
            usernameRegPanel.Controls.Add(userNameInp);
            usernameRegPanel.Location = new Point(7, 5);
            usernameRegPanel.Name = "usernameRegPanel";
            usernameRegPanel.Size = new Size(323, 39);
            usernameRegPanel.TabIndex = 0;
            // 
            // userNameInp
            // 
            userNameInp.BorderStyle = BorderStyle.None;
            userNameInp.Location = new Point(9, 9);
            userNameInp.Name = "userNameInp";
            userNameInp.PlaceholderText = "Enter username";
            userNameInp.Size = new Size(298, 20);
            userNameInp.TabIndex = 0;
            // 
            // authLabel
            // 
            authLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            authLabel.ForeColor = Color.FromArgb(51, 53, 61);
            authLabel.Location = new Point(530, 62);
            authLabel.Name = "authLabel";
            authLabel.Size = new Size(346, 52);
            authLabel.TabIndex = 33;
            authLabel.Text = "LOGIN";
            authLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // extraMsg
            // 
            extraMsg.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            extraMsg.ForeColor = Color.FromArgb(51, 53, 61);
            extraMsg.Location = new Point(619, 420);
            extraMsg.Name = "extraMsg";
            extraMsg.Size = new Size(166, 52);
            extraMsg.TabIndex = 34;
            extraMsg.Text = "Don't have account?";
            extraMsg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.authImg1;
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 521);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 519);
            Controls.Add(pictureBox1);
            Controls.Add(extraMsg);
            Controls.Add(authLabel);
            Controls.Add(registerPanelWrapper);
            Controls.Add(loginPanelWrapper);
            Controls.Add(authSwitcher);
            Controls.Add(authButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            userNamePanel.ResumeLayout(false);
            userNamePanel.PerformLayout();
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            loginPanelWrapper.ResumeLayout(false);
            registerPanelWrapper.ResumeLayout(false);
            emailRegPanel.ResumeLayout(false);
            emailRegPanel.PerformLayout();
            reptPassPanel.ResumeLayout(false);
            reptPassPanel.PerformLayout();
            passwordRegPanel.ResumeLayout(false);
            passwordRegPanel.PerformLayout();
            usernameRegPanel.ResumeLayout(false);
            usernameRegPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox usrNameInp;
        private TextBox passwrdInp;
        private Button authButton;
        private Panel userNamePanel;
        private Panel passwordPanel;
        private Button authSwitcher;
        private Panel loginPanelWrapper;
        private Panel registerPanelWrapper;
        private Panel emailRegPanel;
        private TextBox emailInp;
        private Panel reptPassPanel;
        private TextBox repeatPassInp;
        private Panel passwordRegPanel;
        private TextBox passInp;
        private Panel usernameRegPanel;
        private TextBox userNameInp;
        private Label authLabel;
        private Label extraMsg;
        private PictureBox pictureBox1;
    }
}
