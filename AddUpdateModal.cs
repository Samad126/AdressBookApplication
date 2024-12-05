using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdressBookApplication
{
    public partial class AddUpdateModal : Form
    {
        private string GetConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["MyConStr"].ConnectionString;
        }

        private int userId, contactId, addressId;
        private string formType, mainType;
        private List<object> arr;

        public AddUpdateModal(string formType, int userId, string mainType)
        {
            InitializeComponent();
            InitializeDefaultValues(formType, userId, mainType);
        }

        public AddUpdateModal(string formType, int userId, string mainType, int contactId)
        {
            InitializeComponent();
            InitializeDefaultValues(formType, userId, mainType);
            this.contactId = contactId;
        }

        public AddUpdateModal(string formType, int userId, string mainType, int contactId, List<object> arr)
        {
            InitializeComponent();
            InitializeDefaultValues(formType, userId, mainType);
            this.contactId = contactId;
            this.arr = arr;

            if (mainType == "contact")
            {
                this.txtName.Text = arr[1]?.ToString();
                this.txtSurname.Text = arr[2]?.ToString();
                this.txtNickname.Text = arr[3]?.ToString();
                this.txtPhone.Text = arr[4]?.ToString();
                this.txtEmail.Text = arr[5]?.ToString();
                this.dtpBirthday.Value = (DateTime)arr[6];
            }
        }

        public AddUpdateModal(string formType, int userId, string mainType, int contactId, int addressId, List<object> arr)
        {
            InitializeComponent();
            InitializeDefaultValues(formType, userId, mainType);
            this.addressId = addressId;
            this.contactId = contactId;
            this.arr = arr;

            if (mainType == "address")
            {
                this.txtStreet.Text = arr[0]?.ToString();
                this.txtCity.Text = arr[1]?.ToString();
                this.txtCountry.Text = arr[2]?.ToString();
            }
        }

        private void InitializeDefaultValues(string formType, int userId, string mainType)
        {
            this.userId = userId;
            this.formType = formType;
            this.mainType = mainType;

            lblTitle.Text = (formType == "update" ? "Update " : "Add ") + (mainType == "contact" ? "Contact" : "Address");
            this.Text = lblTitle.Text;

            if (this.mainType == "contact")
                ShowContactPanel();
            else
                ShowAddressPanel();
        }

        private void ShowContactPanel()
        {
            contactPanel.Visible = true;
            addressPanel.Visible = false;
        }

        private void ShowAddressPanel()
        {
            contactPanel.Visible = false;
            addressPanel.Visible = true;
        }

        private void SaveContact()
        {
            try
            {
                string query = formType == "add" ?
                    "INSERT INTO Contacts (Name, Surname, Nickname, Phone, Email, Birthday, user_id) VALUES (@Name, @Surname, @Nickname, @Phone, @Email, @Birthday, @userId)" :
                    "UPDATE Contacts SET Name = @Name, Surname = @Surname, Nickname = @Nickname, Phone = @Phone, Email = @Email, Birthday = @Birthday WHERE user_id = @userId AND id = @contactId";

                using (SqlConnection connection = new SqlConnection(GetConnectionStr()))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", this.userId);
                        if (formType == "update")
                        {
                            cmd.Parameters.AddWithValue("@contactId", this.contactId);
                        }
                        cmd.Parameters.AddWithValue("@Name", this.txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Surname", this.txtSurname.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nickname", this.txtNickname.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", this.txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", this.txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Birthday", this.dtpBirthday.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving contact: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveAddress()
        {
            try
            {
                string query = formType == "add" ?
                    "INSERT INTO Addresses (Street, City, Country, user_id, contact_id) VALUES (@Street, @City, @Country, @userId, @contactId)" :
                    "UPDATE Addresses SET Street = @Street, City = @City, Country = @Country WHERE user_id = @userId AND contact_id = @contactId AND id = @addressId";

                using (SqlConnection connection = new SqlConnection(GetConnectionStr()))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", this.userId);
                        cmd.Parameters.AddWithValue("@contactId", this.contactId);
                        if (formType == "update")
                        {
                            cmd.Parameters.AddWithValue("@addressId", this.addressId);
                        }
                        cmd.Parameters.AddWithValue("@Street", this.txtStreet.Text.Trim());
                        cmd.Parameters.AddWithValue("@City", this.txtCity.Text.Trim());
                        cmd.Parameters.AddWithValue("@Country", this.txtCountry.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving address: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (mainType == "contact")
            {
                if (string.IsNullOrEmpty(this.txtName.Text))
                {
                    MessageBox.Show("Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(this.txtSurname.Text))
                {
                    MessageBox.Show("Surname cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(this.txtPhone.Text))
                {
                    MessageBox.Show("Phone cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dtpBirthday.Value == null)
                {
                    MessageBox.Show("Birthday cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!string.IsNullOrEmpty(txtEmail.Text) && !Regex.IsMatch(txtEmail.Text, emailPattern))
                {
                    MessageBox.Show("Email is invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SaveContact();
            }
            else if (mainType == "address")
            {
                if (string.IsNullOrEmpty(this.txtStreet.Text))
                {
                    MessageBox.Show("Street cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(this.txtCity.Text))
                {
                    MessageBox.Show("City cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(this.txtCountry.Text))
                {
                    MessageBox.Show("Country cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SaveAddress();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
