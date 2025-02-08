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
    public partial class Add_Nurse : Form
    {
        public Add_Nurse()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            ID.Text = "";
            NurseName.Text = "";
            DeptID.Text = "";
            number.Text = "";
            salary.Text = "";
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string con = "your_connection_string_here";
            string query = "INSERT INTO Nurse (NurseID, NurseName, DepartmentID, PhoneNumber, Salary)"
                + "VALUES (@ID,@NurseName,@DeptID,@number,@salary)";
            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@ID",ID.Text);
                    command.Parameters.AddWithValue("@NurseName", NurseName.Text);
                    command.Parameters.AddWithValue("@DeptID", DeptID.Text);
                    command.Parameters.AddWithValue("@number", number.Text);
                    command.Parameters.AddWithValue("@salary", salary.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Nurse Added Successfully");
                    Clear();
                }
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }
    }
}
