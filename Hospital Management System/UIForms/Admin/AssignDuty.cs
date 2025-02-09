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
using System.Xml.Linq;

namespace AMS.UIForms.Admin
{
    public partial class AssignDuty : Form
    {
        public AssignDuty()
        {
            InitializeComponent();
        }

        private void Dutygrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string DepartmentID=DepartmentCombo.Text;
            string NurseID = NurseCombo.Text;
            if (!string.IsNullOrWhiteSpace(DepartmentID) && !string.IsNullOrWhiteSpace(NurseID))
            {
                string query = "UPDATE Nurse SET DepartmentID=@DepartmentID WHERE NurseID=@NurseID;";
                using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                    cmd.Parameters.AddWithValue("@NurseID", NurseID);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }

                MessageBox.Show("Duty Assigned Successfully!");
                DisplayDuties();
            }
            else
            {
                MessageBox.Show("Please Fill in all the required fields");
            }
        }

        private void AssignDuty_Load(object sender, EventArgs e)
        {
            DisplayDuties();
            FillDepartment();
            FillNurse();
        }
        private void DisplayDuties()
        {
            string query = "SELECT n.NurseID, n.NurseName,d.DepartmentID AS DutyDepartmentID,d.DepartmentName AS DutyDepartmentName FROM Nurse as n JOIN Department as d ON n.DepartmentID=d.DepartmentID";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                Dutygrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }
        private void FillDepartment()
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
        private void FillNurse()
        {
            string query = "SELECT NurseID from Nurse";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string reg = reader.GetString(0);
                    NurseCombo.Items.Add(reg);

                }


                reader.Close();
                connection.Close();
            }
        }

        private void NurseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
