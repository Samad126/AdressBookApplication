using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdressBookApplication
{
    public partial class AddUpdateAdress : Form
    {
        private string GetConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["MyConStr"].ConnectionString;
        }

        public AddUpdateAdress(string formType, int userId, int contactId)
        {
            InitializeComponent();
            InitializeDefaults(formType, userId, contactId);
        }

        public AddUpdateAdress(string formType, int userId, int contactId, int addressId, List<object> arr)
        {
            InitializeComponent();
            InitializeDefaults(formType, userId, contactId);
            this.addressId = addressId;

            this.txtStreet.Text = arr[1]?.ToString();
            this.txtCity.Text = arr[2]?.ToString();
            this.txtCountry.Text = arr[3]?.ToString();
        }

        private void InitializeDefaults(string formType, int userId, int contactId)
        {
            if (formType == "update")
            {
                lblTitle.Text = "Update Address";
                this.Text = lblTitle.Text;
            }
            else
            {
                lblTitle.Text = "Add Address";
                this.Text = lblTitle.Text;
            }
            this.userId = userId;
            this.contactId = contactId;
            this.formType = formType;
        }

        private int userId, contactId, addressId;
        private string formType;

        private void btnSave_Click(object sender, EventArgs e)
        {
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
                        cmd.Parameters.AddWithValue("@Street", this.txtStreet.Text.Trim());
                        cmd.Parameters.AddWithValue("@City", this.txtCity.Text.Trim());
                        cmd.Parameters.AddWithValue("@Country", this.txtCountry.Text.Trim());
                        cmd.Parameters.AddWithValue("@userId", this.userId);
                        cmd.Parameters.AddWithValue("@contactId", this.contactId);

                        if (formType == "update")
                        {
                            cmd.Parameters.AddWithValue("@addressId", this.addressId);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving address: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
