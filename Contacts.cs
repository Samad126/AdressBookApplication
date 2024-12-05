using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AdressBookApplication
{
    public partial class Contacts : Form
    {
        private int userId, contactId, addressId;
        private string mainType;

        public Contacts(int userId, string mainType)
        {
            InitializeComponent();
            this.userId = userId;
            this.mainType = mainType;
            fetchData(mainType);
            fetchUserName(userId);
            textChanger();
        }

        private string GetConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["MyConStr"].ConnectionString;
        }

        private void fetchUserName(int id)
        {
            const string query = "SELECT username FROM Users WHERE id = @userId";
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionStr()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", id);
                        string username = (string)cmd.ExecuteScalar();
                        this.userNameLabel.Text = username;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to fetch user info: {ex.Message}");
            }
        }

        private void fetchData(string type)
        {
            try
            {
                string query;
                if (type == "contact")
                {
                    query = "SELECT * FROM Contacts WHERE user_id = @userId";
                }
                else
                {
                    query = "SELECT * FROM Addresses WHERE user_id = @userId AND contact_id = @contactId";
                }

                using (SqlConnection connection = new SqlConnection(GetConnectionStr()))
                {

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", this.userId);
                        if (type == "address")
                        {
                            cmd.Parameters.AddWithValue("@contactId", this.contactId);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            this.dataGridView1.Columns.Clear();
                            this.dataGridView1.DataSource = dataTable;

                            this.dataGridView1.ReadOnly = true;
                            this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

                            DataGridViewCheckBoxColumn radioColumn = new DataGridViewCheckBoxColumn
                            {
                                HeaderText = "Selection",
                                Width = 30,
                                Name = "RadioColumn",
                                FalseValue = false,
                                TrueValue = true,
                                ReadOnly = false
                            };

                            this.dataGridView1.Columns.Insert(0, radioColumn);

                            if (this.dataGridView1.Columns.Contains("id"))
                            {
                                this.dataGridView1.Columns["id"].Visible = false;
                            }
                            if (this.dataGridView1.Columns.Contains("user_id"))
                            {
                                this.dataGridView1.Columns["user_id"].Visible = false;
                            }
                            if (this.dataGridView1.Columns.Contains("contact_id"))
                            {
                                this.dataGridView1.Columns["contact_id"].Visible = false;
                            }

                            this.dataGridView1.CellContentClick -= DataGridView1_CellContentClick;
                            this.dataGridView1.CellContentClick += DataGridView1_CellContentClick;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == this.dataGridView1.Columns["RadioColumn"].Index)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells["RadioColumn"];
                bool isChecked = (bool)checkbox.EditedFormattedValue;
                checkbox.Value = !isChecked;
            }
        }

        private void addressSwitcherBtn_Click(object sender, EventArgs e)
        {
            if (this.mainType == "contact")
            {
                if (checkSelectedCount() == 1)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["RadioColumn"].Value) == true)
                        {
                            this.contactId = Convert.ToInt32(row.Cells["id"].Value);
                            this.mainType = "address";
                            fetchData(this.mainType);
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select only one contact to view addresses", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.mainType = "contact";
                fetchData(this.mainType);
            }
            textChanger();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.GridColor = Color.White;
        }

        private void textChanger()
        {
            this.mainLabel.Text = this.mainType == "contact" ? "Contact Manager" : "Address Manager";
            this.addressSwitcherBtn.Text = this.mainType == "contact" ? "View Address" : "Back To Contacts";
        }

        private void addContactBtn_Click(object sender, EventArgs e)
        {
            Form add;
            if (this.mainType == "contact")
            {
                add = new AddUpdateContact("add", this.userId, this.mainType);
            }
            else
            {
                add = new AddUpdateContact("add", this.userId, this.mainType, this.contactId);
            }

            var result = add.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fetchData(mainType);
            }
        }

        private void updateContactBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectedCount() == 1)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["RadioColumn"].Value) == true)
                    {
                        List<object> arr = new List<object>();

                        if (this.mainType == "contact")
                        {
                            int contactId = Convert.ToInt32(row.Cells["id"].Value);
                            string phone = Convert.ToString(row.Cells["Phone"].Value);
                            string name = Convert.ToString(row.Cells["Name"].Value);
                            string surname = Convert.ToString(row.Cells["Surname"].Value);
                            string nickname = Convert.ToString(row.Cells["Nickname"].Value);
                            string email = Convert.ToString(row.Cells["Email"].Value);
                            DateTime birthday = Convert.ToDateTime(row.Cells["Birthday"].Value);

                            arr.Add(contactId);
                            arr.Add(name);
                            arr.Add(surname);
                            arr.Add(nickname);
                            arr.Add(phone);
                            arr.Add(email);
                            arr.Add(birthday);

                            Form update = new AddUpdateContact("update", this.userId, this.mainType, contactId, arr);
                            var result = update.ShowDialog();

                            if (result == DialogResult.OK)
                            {
                                MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fetchData(mainType);
                            }
                        }
                        else if (this.mainType == "address")
                        {
                            this.addressId = Convert.ToInt32(row.Cells["id"].Value);
                            this.contactId = Convert.ToInt32(row.Cells["contact_id"].Value);
                            string street = Convert.ToString(row.Cells["Street"].Value);
                            string city = Convert.ToString(row.Cells["City"].Value);
                            string country = Convert.ToString(row.Cells["Country"].Value);

                            arr.Add(street);
                            arr.Add(city);
                            arr.Add(country);

                            Form update = new AddUpdateContact("update", this.userId, this.mainType, contactId, this.addressId, arr);
                            var result = update.ShowDialog();

                            if (result == DialogResult.OK)
                            {
                                MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fetchData(mainType);
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show($"Please select only one {this.mainType} to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int checkSelectedCount()
        {
            int selects = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["RadioColumn"].Value) == true)
                {
                    selects++;
                }
            }

            return selects;
        }

        private void removeContactBtn_Click(object sender, EventArgs e)
        {
            if (checkSelectedCount() == 0)
            {
                MessageBox.Show($"Please select at least one {this.mainType}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the selected {this.mainType}(s)?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query;
                    if (this.mainType == "contact")
                    {
                        query = "DELETE FROM Contacts WHERE user_id = @userId AND id = @contactId";
                    }
                    else
                    {
                        query = "DELETE FROM Addresses WHERE user_id = @userId AND contact_id = @contactId AND id = @addressId";
                    }

                    using (SqlConnection connection = new SqlConnection(GetConnectionStr()))
                    {
                        connection.Open();

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells["RadioColumn"].Value) == true)
                            {
                                if (this.mainType == "contact")
                                {
                                    this.contactId = Convert.ToInt32(row.Cells["id"].Value);

                                    using (SqlCommand cmd = new SqlCommand(query, connection))
                                    {
                                        cmd.Parameters.AddWithValue("@userId", this.userId);
                                        cmd.Parameters.AddWithValue("@contactId", this.contactId);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    this.addressId = Convert.ToInt32(row.Cells["id"].Value);
                                    this.contactId = Convert.ToInt32(row.Cells["contact_id"].Value);

                                    using (SqlCommand cmd = new SqlCommand(query, connection))
                                    {
                                        cmd.Parameters.AddWithValue("@userId", this.userId);
                                        cmd.Parameters.AddWithValue("@contactId", this.contactId);
                                        cmd.Parameters.AddWithValue("@addressId", this.addressId);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        fetchData(this.mainType);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting {this.mainType}(s): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void moveToLogin()
        {
            this.Hide();
            Form login = new Login("login");
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            moveToLogin();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            moveToLogin();
        }

        private void logoutPanelClick(object sender, EventArgs e)
        {
            moveToLogin();
        }
    }
}
