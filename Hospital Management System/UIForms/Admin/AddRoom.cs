using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        

        public AddRoom()
        {
            InitializeComponent();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }


        
        private void fillAvailableBeds()
        {
            if (DepartmentCombo.SelectedItem == null)
            {
                MessageBox.Show("Please select a department first.");
                return;
            }

            string selectedDepartmentID = DepartmentCombo.SelectedItem.ToString();
            string query = "SELECT AvailableBeds FROM Room WHERE DepartmentID = @DepartmentID";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
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
            if (DepartmentCombo.SelectedItem == null)
            {
                MessageBox.Show("Please select a department first.");
                return;
            }

            string selectedDepartmentID = DepartmentCombo.SelectedItem.ToString();
            string query = "SELECT TotalBeds FROM Room WHERE DepartmentID = @DepartmentID";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
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
            Clear();

        }

        private void InsertRoom()
        {
            string query = "INSERT INTO Room (RoomID, DepartmentID, TotalBeds, AvailableBeds) "
                         + "VALUES (@RoomID, @DepartmentID, @TotalBeds, @AvailableBeds)";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@RoomID", ID.Text);
                    command.Parameters.AddWithValue("@DepartmentID", DepartmentCombo.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@TotalBeds", guna2TextBox2.Text);
                    command.Parameters.AddWithValue("@AvailableBeds", guna2TextBox1.Text);

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Room Added Successfully");
                    Clear();
                    DisplayRooms();
                }
            }
        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            

        }


        private void Clear()
        {
            ID.Text = "";
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
        }
        private void DisplayRooms()
        {
            string query = "SELECT r.RoomID, d.DepartmentID,d.DepartmentName, r.TotalBeds,r.AvailableBeds FROM Room as r JOIN Department as d ON r.DepartmentID=d.DepartmentID";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Roomgrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            DisplayRooms();
            FillDepartments();
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            InsertRoom();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void FillDepartments()
        {
            string query = "SELECT DepartmentID from Department";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string reg = reader.GetString(0);
                    DepartmentCombo.Items.Add(reg);

                }


                reader.Close();
                connection.Close();
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Roomgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DepartmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
