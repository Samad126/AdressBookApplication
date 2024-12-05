namespace AdressBookApplication
{
    partial class Login
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
            label1 = new Label();
            usrNameInp = new TextBox();
            passwrdInp = new TextBox();
            loginBtn = new Button();
            userNamePanel = new Panel();
            passwordPanel = new Panel();
            label2 = new Label();
            signUpBtn = new Button();
            loginPanelWrapper = new Panel();
            userNamePanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            loginPanelWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(334, 37);
            label1.Name = "label1";
            label1.Size = new Size(120, 50);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // usrNameInp
            // 
            usrNameInp.BorderStyle = BorderStyle.None;
            usrNameInp.Location = new Point(11, 14);
            usrNameInp.Name = "usrNameInp";
            usrNameInp.PlaceholderText = "Enter your username";
            usrNameInp.Size = new Size(297, 20);
            usrNameInp.TabIndex = 1;
            usrNameInp.TextChanged += usrNameInp_TextChanged;
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
            passwrdInp.TextChanged += passwrdInp_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(28, 104, 237);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(242, 282);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(323, 49);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Log in";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 356);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 6;
            label2.Text = "Don't have account?";
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = SystemColors.Control;
            signUpBtn.Cursor = Cursors.Hand;
            signUpBtn.FlatAppearance.BorderSize = 0;
            signUpBtn.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            signUpBtn.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            signUpBtn.FlatStyle = FlatStyle.Flat;
            signUpBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            signUpBtn.ForeColor = Color.FromArgb(28, 104, 237);
            signUpBtn.Location = new Point(429, 350);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(71, 32);
            signUpBtn.TabIndex = 7;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // loginPanelWrapper
            // 
            loginPanelWrapper.Controls.Add(passwordPanel);
            loginPanelWrapper.Controls.Add(userNamePanel);
            loginPanelWrapper.Location = new Point(231, 109);
            loginPanelWrapper.Name = "loginPanelWrapper";
            loginPanelWrapper.Size = new Size(346, 146);
            loginPanelWrapper.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginPanelWrapper);
            Controls.Add(signUpBtn);
            Controls.Add(label2);
            Controls.Add(loginBtn);
            Controls.Add(label1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usrNameInp;
        private TextBox passwrdInp;
        private Button loginBtn;
        private Panel userNamePanel;
        private Panel passwordPanel;
        private Label label2;
        private Button signUpBtn;
        private Panel loginPanelWrapper;
    }
}