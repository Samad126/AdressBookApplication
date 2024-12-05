namespace AdressBookApplication
{
    partial class Register
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
            passInp = new TextBox();
            loginBtn = new Button();
            label2 = new Label();
            registerBtn = new Button();
            userNameInp = new TextBox();
            passwordRegPanel = new Panel();
            usernameRegPanel = new Panel();
            reptPassPanel = new Panel();
            repeatPassInp = new TextBox();
            emailRegPanel = new Panel();
            emailInp = new TextBox();
            registerPanelWrapper = new Panel();
            passwordRegPanel.SuspendLayout();
            usernameRegPanel.SuspendLayout();
            reptPassPanel.SuspendLayout();
            emailRegPanel.SuspendLayout();
            registerPanelWrapper.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(318, 26);
            label1.Name = "label1";
            label1.Size = new Size(159, 50);
            label1.TabIndex = 8;
            label1.Text = "Sign Up";
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
            passInp.TextChanged += passInp_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.Control;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            loginBtn.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.FromArgb(28, 104, 237);
            loginBtn.Location = new Point(433, 391);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(71, 32);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Log in";
            loginBtn.UseVisualStyleBackColor = false;
            //loginBtn.Click += loginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 397);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 12;
            label2.Text = "Already have an account?";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(28, 104, 237);
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(240, 323);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(323, 49);
            registerBtn.TabIndex = 4;
            registerBtn.Text = "Sign Up";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // userNameInp
            // 
            userNameInp.BorderStyle = BorderStyle.None;
            userNameInp.Location = new Point(9, 9);
            userNameInp.Name = "userNameInp";
            userNameInp.PlaceholderText = "Enter username";
            userNameInp.Size = new Size(298, 20);
            userNameInp.TabIndex = 0;
            userNameInp.TextChanged += userNameInp_TextChanged;
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
            // usernameRegPanel
            // 
            usernameRegPanel.BackColor = SystemColors.ControlLightLight;
            usernameRegPanel.Controls.Add(userNameInp);
            usernameRegPanel.Location = new Point(7, 5);
            usernameRegPanel.Name = "usernameRegPanel";
            usernameRegPanel.Size = new Size(323, 39);
            usernameRegPanel.TabIndex = 0;
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
            emailInp.TextChanged += emailInp_TextChanged;
            // 
            // registerPanelWrapper
            // 
            registerPanelWrapper.Controls.Add(emailRegPanel);
            registerPanelWrapper.Controls.Add(reptPassPanel);
            registerPanelWrapper.Controls.Add(passwordRegPanel);
            registerPanelWrapper.Controls.Add(usernameRegPanel);
            registerPanelWrapper.Location = new Point(233, 92);
            registerPanelWrapper.Name = "registerPanelWrapper";
            registerPanelWrapper.Size = new Size(339, 216);
            registerPanelWrapper.TabIndex = 13;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(registerPanelWrapper);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(registerBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            passwordRegPanel.ResumeLayout(false);
            passwordRegPanel.PerformLayout();
            usernameRegPanel.ResumeLayout(false);
            usernameRegPanel.PerformLayout();
            reptPassPanel.ResumeLayout(false);
            reptPassPanel.PerformLayout();
            emailRegPanel.ResumeLayout(false);
            emailRegPanel.PerformLayout();
            registerPanelWrapper.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox passInp;
        private Button loginBtn;
        private Label label2;
        private Button registerBtn;
        private TextBox userNameInp;
        private Panel passwordRegPanel;
        private Panel usernameRegPanel;
        private Panel reptPassPanel;
        private TextBox repeatPassInp;
        private Panel emailRegPanel;
        private TextBox emailInp;
        private Panel registerPanelWrapper;
    }
}