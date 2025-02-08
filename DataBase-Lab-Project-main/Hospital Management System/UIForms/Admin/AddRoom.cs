using Guna.UI2.WinForms;
using Skylines.UIForms.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AMS.UIForms.Admin
{
    public partial class AddRoom : Form
    {
        private string connectionString = "Data Source=DESKTOP-KHTABAF\\SQLEXPRESS;Initial Catalog=Skylines Hospital;Integrated Security=True";

        public AddRoom()
        {
            InitializeComponent();
            fillDepartmentCombo();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }


        private void fillDepartmentCombo()
        {


            string query = "SELECT * FROM Room";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string reg = reader.GetString(1);
                    guna2ComboBox1.Items.Add(reg);

                }


                reader.Close();
                connection.Close();
            }
        }
        private void fillAvailableBeds()
        {
            if (guna2ComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a department first.");
                return;
            }

            string selectedDepartmentID = guna2ComboBox1.SelectedItem.ToString();
            string query = "SELECT AvailableBeds FROM Room WHERE DepartmentID = @DepartmentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DepartmentID", selectedDepartmentID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) // If data exists
                {
                    guna2TextBox2.Text = reader["AvailableBeds"].ToString(); // Assign to TextBox
                }
                else
                {
                    guna2TextBox2.Text = "0"; // No available beds found
                }

                reader.Close();
                connection.Close();
            }
        }
        private void fillTotalBeds()
        {
            if (guna2ComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a department first.");
                return;
            }

            string selectedDepartmentID = guna2ComboBox1.SelectedItem.ToString();
            string query = "SELECT TotalBeds FROM Room WHERE DepartmentID = @DepartmentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DepartmentID", selectedDepartmentID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    guna2TextBox1.Text = reader["TotalBeds"].ToString();
                }
                else
                {
                    guna2TextBox1.Text = "0";
                }

                reader.Close();
                connection.Close();
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillAvailableBeds();
            fillTotalBeds();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();

        }

        private void InsertRoom()
        {
            string query = "INSERT INTO Room (RoomID, DepartmentID, TotalBeds, AvailableBeds) "
                         + "VALUES (@RoomID, @DepartmentID, @TotalBeds, @AvailableBeds)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@RoomID", ID.Text);
                    command.Parameters.AddWithValue("@DepartmentID", guna2ComboBox1.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@TotalBeds", guna2TextBox2.Text);
                    command.Parameters.AddWithValue("@AvailableBeds", guna2TextBox1.Text);

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Room Added Successfully");
                    Clear();
                }
            }
        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            InsertRoom();

        }


        private void Clear()
        {
            ID.Text = "";
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
        }

    }
}
