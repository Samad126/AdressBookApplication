using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressBookApplication
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private string usernameReg, passwordReg, emailReg;

        private string GetConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["MyConStr"].ConnectionString;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            try
            {
                if (string.IsNullOrEmpty(userNameInp.Text))
                {
                    throw new Exception("Username cannot be empty");
                }
                else if (!Regex.IsMatch(emailInp.Text, emailPattern))
                {
                    throw new Exception("Email is not valid");
                }
                else if (passInp.Text.Trim().Length < 8)
                {
                    throw new Exception("Password must be at least 8 characters long");
                }
                else if (repeatPassInp.Text.Trim() != passInp.Text.Trim())
                {
                    throw new Exception("Passwords do not match");
                }

                const string query = "INSERT INTO Users (username, password, email) VALUES (@username, @password, @email)";

                using (SqlConnection connection = new SqlConnection(GetConnectionStr()))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", usernameReg);
                        cmd.Parameters.AddWithValue("@password", passwordReg);
                        cmd.Parameters.AddWithValue("@email", emailReg);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registration successful! Redirecting to login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            moveToLogin();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            moveToLogin();
        }

        void moveToLogin()
        {
            this.Hide();
            Form login = new Login("");
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void userNameInp_TextChanged(object sender, EventArgs e)
        {
            this.usernameReg = userNameInp.Text;
        }

        private void emailInp_TextChanged(object sender, EventArgs e)
        {
            this.emailReg = emailInp.Text;
        }

        private void passInp_TextChanged(object sender, EventArgs e)
        {
            this.passwordReg = passInp.Text;
        }
    }
}
