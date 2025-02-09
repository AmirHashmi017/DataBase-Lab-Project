
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            DepartmentCombo.Text = "";
            number.Text = "";
            salary.Text = "";
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string check = "SELECT * FROM Nurse WHERE NurseID = '" + ID.Text + "'";
            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(check, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("NurseID Already Exists");
                    connection.Close();
                    Clear();
                    return;
                }
                connection.Close();
            }
            string query = "INSERT INTO Nurse (NurseID, NurseName, DepartmentID, PhoneNumber, Salary)"
                + "VALUES (@ID,@NurseName,@DeptID,@number,@salary)";
            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", ID.Text);
                    command.Parameters.AddWithValue("@NurseName", NurseName.Text);
                    command.Parameters.AddWithValue("@DeptID", DepartmentCombo.Text);
                    command.Parameters.AddWithValue("@number", number.Text);
                    command.Parameters.AddWithValue("@salary", salary.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Nurse Added Successfully");
                    Clear();
                    DisplayNurse();
                }
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void Nursegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Doctorgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DisplayNurse()
        {
            string query = "SELECT n.NurseID, n.NurseName,d.DepartmentID,d.DepartmentName, n.PhoneNumber,n.Salary FROM Nurse as n JOIN Department as d ON n.DepartmentID=d.DepartmentID";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Doctorgrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }
        private void Add_Nurse_Load(object sender, EventArgs e)
        {
            DisplayNurse();
            FillDepartments();
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

        private void DepartmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
