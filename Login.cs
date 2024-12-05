using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdressBookApplication
{
    public partial class Login : Form
    {
        public Login(string authType)
        {
            InitializeComponent();
            this.authType = authType;
            visibilityChanger();

            this.usrNameInp.TextChanged += usrNameInp_TextChanged;
            this.passwrdInp.TextChanged += passwrdInp_TextChanged;

            this.userNameInp.TextChanged += userNameInp_TextChanged;
            this.passInp.TextChanged += passInp_TextChanged;
            this.emailInp.TextChanged += emailInp_TextChanged;
            this.repeatPassInp.TextChanged += repeatPassInp_TextChanged;
        }

        private string username, password, email, repeatPassword, authType;

        private string GetConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["MyConStr"].ConnectionString;
        }

        private void textChanger()
        {
            this.authLabel.Text = this.authType.ToUpper();
            this.extraMsg.Text = this.authType == "login" ? "Don't have an account?" : "Already have an account?";
            this.authButton.Text = this.authType == "login" ? "Login" : "Sign Up";
            this.authSwitcher.Text = this.authType == "login" ? "Sign Up" : "Log In";
        }

        private void visibilityChanger()
        {
            bool isRegister = this.authType == "register";

            this.loginPanelWrapper.Visible = !isRegister;
            this.registerPanelWrapper.Visible = isRegister;

            this.extraMsg.Size = new Size(this.authType == "login" ? 190 : 210, this.extraMsg.Height);
            this.extraMsg.Location = new Point(this.authType == "login" ? 610 : 595, 420);

            textChanger();
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.authType == "login")
                {
                    if (string.IsNullOrWhiteSpace(this.username))
                    {
                        throw new Exception("Username cannot be empty");
                    }
                    else if (string.IsNullOrWhiteSpace(this.password))
                    {
                        throw new Exception("Password cannot be empty");
                    }
                    else
                    {
                        const string query = "SELECT id FROM Users WHERE username = @username AND password = @password";
                        using (SqlConnection connection = new SqlConnection(GetConnectionStr()))
                        {
                            connection.Open();
                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@username", this.username);
                                cmd.Parameters.AddWithValue("@password", this.password);
                                object result = cmd.ExecuteScalar();

                                if (result != null)
                                {
                                    int userId = Convert.ToInt32(result);
                                    this.Hide();
                                    Form contact = new Contacts(userId, "contact");
                                    contact.Closed += (s, args) => this.Close();
                                    contact.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                else if (this.authType == "register")
                {
                    string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                    if (string.IsNullOrWhiteSpace(this.username))
                    {
                        throw new Exception("Username cannot be empty");
                    }
                    else if (!Regex.IsMatch(this.email, emailPattern))
                    {
                        throw new Exception("Email is not valid");
                    }
                    else if (string.IsNullOrWhiteSpace(this.password) || this.password.Trim().Length < 8)
                    {
                        throw new Exception("Password must be at least 8 characters long");
                    }
                    else if (this.password.Trim() != this.repeatPassword.Trim())
                    {
                        throw new Exception("Passwords do not match");
                    }

                    const string query = "INSERT INTO Users (username, password, email) VALUES (@username, @password, @email)";
                    using (SqlConnection connection = new SqlConnection(GetConnectionStr()))
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@username", this.username);
                            cmd.Parameters.AddWithValue("@password", this.password);
                            cmd.Parameters.AddWithValue("@email", this.email);

                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Registration successful! Redirecting to login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.authType = "login";
                                visibilityChanger();
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Number == 2627 || ex.Number == 2601)
                                {
                                    MessageBox.Show("This username or email is already registered. Please choose another.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show($"An SQL error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void authSwitcher_Click(object sender, EventArgs e)
        {
            this.authType = this.authType == "login" ? "register" : "login";
            visibilityChanger();
        }

        private void usrNameInp_TextChanged(object sender, EventArgs e)
        {
            this.username = usrNameInp.Text;
        }

        private void passwrdInp_TextChanged(object sender, EventArgs e)
        {
            this.password = passwrdInp.Text;
        }

        private void userNameInp_TextChanged(object sender, EventArgs e)
        {
            this.username = userNameInp.Text;
        }

        private void passInp_TextChanged(object sender, EventArgs e)
        {
            this.password = passInp.Text;
        }

        private void emailInp_TextChanged(object sender, EventArgs e)
        {
            this.email = emailInp.Text;
        }

        private void repeatPassInp_TextChanged(object sender, EventArgs e)
        {
            this.repeatPassword = repeatPassInp.Text;
        }
    }
}
