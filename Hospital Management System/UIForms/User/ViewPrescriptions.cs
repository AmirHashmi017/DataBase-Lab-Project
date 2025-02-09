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

namespace AMS.UIForms.User
{
    public partial class ViewPrescriptions : Form
    {
        public ViewPrescriptions()
        {
            InitializeComponent();
        }

        private void ViewPrescriptions_Load(object sender, EventArgs e)
        {
            DisplayPrescriptions();
        }
        private void DisplayPrescriptions()
        {
            string query = "SELECT p.PrescriptionID,p.DoctorID,d.DoctorName,p.Dosage,p.Medicine,p.DoctorRemarks FROM Prescription as p JOIN Doctor as d ON p.DoctorID=d.DoctorID WHERE p.PatientID=@PatientID";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientID", Skylines.UIForms.Login.PatientID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                PrescriptionGrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }
        private void PrescriptionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
