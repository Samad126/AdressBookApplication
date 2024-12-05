using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AdressBookApplication
{
    public partial class Adress : Form
    {
        public Adress(int userId, int contactId)
        {
            InitializeComponent();
            this.userId = userId;
            this.contactId = contactId;
            fetchAddress();
        }

        private int userId, contactId;

        private string GetConnectionStr()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["MyConStr"].ConnectionString;
        }

        private void Adress_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.GridColor = Color.Gray;
        }

        private void fetchAddress()
        {
            try
            {
                const string query = "SELECT * FROM Addresses WHERE user_id = @userId AND contact_id = @contactId";
                using (SqlConnection connection = new SqlConnection(GetConnectionStr()))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", this.userId);
                        cmd.Parameters.AddWithValue("@contactId", this.contactId);

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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form login = new Login();
            //login.Closed += (s, args) => this.Close();
            //login.Show();
        }

        private void backContacts_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form contacts = new Contacts(userId);
            //contacts.Closed += (s, args) => this.Close();
            //contacts.Show();
        }

        private void addAddressBtn_Click(object sender, EventArgs e)
        {
            Form add = new AddUpdateAdress("add", userId, contactId);
            var result = add.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fetchAddress();
            }
        }

        private void updateAddressBtn_Click(object sender, EventArgs e)
        {
            int addressId = -1;
            string street, city, country;
            List<object> arr = new List<object>();

            if (checkSelectedCount() == 1)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["RadioColumn"].Value) == true)
                    {
                        addressId = Convert.ToInt32(row.Cells["id"].Value);
                        street = Convert.ToString(row.Cells["Street"].Value);
                        city = Convert.ToString(row.Cells["City"].Value);
                        country = Convert.ToString(row.Cells["Country"].Value);

                        arr.Add(addressId);
                        arr.Add(street);
                        arr.Add(city);
                        arr.Add(country);

                        Form update = new AddUpdateAdress("update", userId, contactId, addressId, arr);
                        var result = update.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fetchAddress();
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select only one address to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void removeAddressBtn_Click_1(object sender, EventArgs e)
        {
            if (checkSelectedCount() == 0)
            {
                MessageBox.Show("Please select at least one address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the selected addresses?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    const string query = "DELETE FROM Addresses WHERE user_id = @userId AND contact_id = @contactId AND id = @addressId";
                    using (SqlConnection connection = new SqlConnection(GetConnectionStr()))
                    {
                        connection.Open();

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells["RadioColumn"].Value) == true)
                            {
                                int addressId = Convert.ToInt32(row.Cells["id"].Value);

                                using (SqlCommand cmd = new SqlCommand(query, connection))
                                {
                                    cmd.Parameters.AddWithValue("@userId", this.userId);
                                    cmd.Parameters.AddWithValue("@contactId", this.contactId);
                                    cmd.Parameters.AddWithValue("@addressId", addressId);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        fetchAddress();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting addresses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
