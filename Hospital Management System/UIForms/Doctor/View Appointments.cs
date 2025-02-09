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

namespace AMS.UIForms.Doctor
{
    public partial class View_Appointments : Form
    {
        public View_Appointments()
        {
            InitializeComponent();
        }

        private void DisplayDoctorAppointments()
        {
            string query = "SELECT a.AppointmentID,a.DoctorID,p.PatientID,p.PatientName,a.AppointmentDate,a.AppointmentTime FROM Appointment as a JOIN Patient as p ON a.PatientID=p.PatientID WHERE a.DoctorID=@DoctorID";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorID", Skylines.UIForms.Login.DoctorID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                AppGrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }
        private void FlightGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Appointments_Load(object sender, EventArgs e)
        {
            DisplayDoctorAppointments();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
