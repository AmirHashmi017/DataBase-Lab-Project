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

namespace AMS.UIForms.Admin
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }
        private void AddAdmin_Load(object sender, EventArgs e)
        {
            DisplayAdmins();
        }
        private bool AdminExists(string adminID)
        {
     
            string query = "SELECT COUNT(*) FROM Admin WHERE AdminID = @ID";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", adminID);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();
                    return count > 0;
                }
            }
        }
        private void Clear()
        {
            ID.Text = "";
            AdminName.Text = "";
            Password.Text = "";
            number.Text = "";
            email.Text = "";
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID.Text) || string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(AdminName.Text) || string.IsNullOrWhiteSpace(number.Text) || string.IsNullOrWhiteSpace(email.Text))
            {
                MessageBox.Show("Please Fill in all the fields.");
                return;
            }

            if (AdminExists(ID.Text))
            {
                MessageBox.Show("Admin already exists.");
                return;
            }

            string query = "INSERT INTO Admin (AdminID, LoginPassword, AdminName, PhoneNumber, Email)"
              + "VALUES(@ID,@Password,@AdminName,@number,@Email)";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", ID.Text);
                    command.Parameters.AddWithValue("@Password", Password.Text);
                    command.Parameters.AddWithValue("@AdminName", AdminName.Text);
                    command.Parameters.AddWithValue("@number", number.Text);
                    command.Parameters.AddWithValue("@Email", email.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Admin Added Successfully");
                    Clear();
                    DisplayAdmins();
                }
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void DisplayAdmins()
        {
            string query = "SELECT AdminID, AdminName,PhoneNumber, Email FROM Admin";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                AdminGrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }
        private void ScheduleGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
