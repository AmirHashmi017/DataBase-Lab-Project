using Guna.UI2.WinForms;
using Skylines.UIForms.admin;
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
    public partial class AddDepartment : Form
    {

        private string connectionString = "Data Source=DESKTOP-KHTABAF\\SQLEXPRESS;Initial Catalog=Skylines Hospital;Integrated Security=True";
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

            this.Close();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            InsertDepartment();


        }

        private void InsertDepartment()
        {
            string query = "INSERT INTO Department (DepartmentID, DepartmentName) VALUES (@DepartmentID, @DepartmentName)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@DepartmentID", DepartmentID.Text);
                    command.Parameters.AddWithValue("@DepartmentName", DepartmentName.Text);

                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Department Added Successfully");
                    Clear();
                }
            }
        }


        private void Clear()
        {
            DepartmentID.Text = "";
            DepartmentName.Text = "";
        }

    }
}
