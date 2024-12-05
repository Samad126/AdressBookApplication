using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace AdressBookApplication
{
    public partial class Login : Form
    {
        public Login(string authType)
        {
            InitializeComponent();
        }

        private string usernameLogin;
        private string passwordLogin;

        private string GetConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["MyConStr"].ConnectionString;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.usernameLogin))
                {
                    throw new Exception("Username cannot be empty");
                }
                else if (string.IsNullOrWhiteSpace(this.passwordLogin))
                {
                    throw new Exception("Password cannot be empty");
                }
                else
                {
                    const string query = "SELECT id from Users where username = @username and password = @password";
                    using (SqlConnection connection = new SqlConnection(GetConnectionStr()))
                    {
                        try
                        {
                            connection.Open();

                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@username", this.usernameLogin);
                                cmd.Parameters.AddWithValue("@password", this.passwordLogin);

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
                                    MessageBox.Show("Incorrect username or password");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Database connection failed: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form register = new Register();
            register.Closed += (s, args) => this.Close();
            register.Show();
        }

        private void usrNameInp_TextChanged(object sender, EventArgs e)
        {
            this.usernameLogin = usrNameInp.Text;
        }

        private void passwrdInp_TextChanged(object sender, EventArgs e)
        {
            this.passwordLogin = passwrdInp.Text;
        }
    }
}
