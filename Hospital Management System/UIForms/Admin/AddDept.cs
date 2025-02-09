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
    public partial class AddDept : Form
    {
        public AddDept()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (!ValidateID())
            {
                return;
            }

            if (!ValidateName())
            {
                return;
            }

            string query = "INSERT INTO Department (DepartmentID, DepartmentName) VALUES (@deptID, @deptName);";



            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@deptID", ID.Text);
                cmd.Parameters.AddWithValue("@deptName", name.Text);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                connection.Close();
            }

            MessageBox.Show("Department Added Successfully!");
            DisplayDepartments();
            Clear();


        }

        public void Clear()
        {
            ID.Text = "";
            name.Text = "";
        }
        private bool ValidateID()
        {
            if(ID.Text == "")
            {
                MessageBox.Show("ID can't be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (CheckExistence())
            {
                MessageBox.Show("Department ID Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private bool ValidateName()
        {
            if (name.Text == "")
            {
                MessageBox.Show("Name can't be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (CheckExistence())
            {
                MessageBox.Show("Department Name Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckName()
        {
            SqlConnection con = new SqlConnection(UtilityCLass.getConnectionString());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Department where DepartmentName = @deptName ", con);
            cmd.Parameters.AddWithValue("@deptID", name.Text);

            int count = (int)(cmd.ExecuteScalar());

            con.Close();


            return count > 0;
        }

        private bool CheckExistence()
        {
            SqlConnection con = new SqlConnection(UtilityCLass.getConnectionString());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Department where DepartmentID = @deptID ", con);
            cmd.Parameters.AddWithValue("@deptID", ID.Text);
           
            int count = (int)(cmd.ExecuteScalar());

            con.Close();


            return count > 0;
        }

        private void AddDept_Load(object sender, EventArgs e)
        {
            DisplayDepartments();
        }
        private void DisplayDepartments()
        {
            string query = "SELECT DepartmentID, DepartmentName FROM Department";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                DeptGrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }
        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeptGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
