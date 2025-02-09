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
    public partial class TakeAppointment : Form
    {
        public TakeAppointment()
        {
            InitializeComponent();
        }

        private void TakeAppointment_Load(object sender, EventArgs e)
        {
            DisplayAppointments();
            FillSpecCombo();
        }

        private void DepartmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateCombo.Items.Clear();
            FillDate();
        }
        private void FillSpecCombo()
        {
            string query = "SELECT DISTINCT(Specialization) FROM Doctor";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string reg = reader.GetString(0);
                    SpecCombo.Items.Add(reg);

                }


                reader.Close();
                connection.Close();
            }
        }
        private void FillDoctor()
        {
            string Specialization=SpecCombo.Text;
            if (!string.IsNullOrWhiteSpace(Specialization)) {
                string query = "SELECT DoctorID, DoctorName FROM Doctor where Specialization=@Specialization and DoctorID IN (SELECT DoctorID FROM DoctorSchedule)";

                using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Specialization", Specialization);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string doctorID = reader["DoctorID"].ToString();
                        string doctorName = reader["DoctorName"].ToString();
                        DoctorCombo.Items.Add(new ComboBoxItem { Text = $"{doctorName} ({doctorID})", Value = doctorID });

                    }


                    reader.Close();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Select any Specialization First.");
            }
        }
        private void NurseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoctorCombo.Items.Clear();
            FillDoctor();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string AppointmentID = IDTxt.Text;
            string DoctorID = (DoctorCombo.SelectedItem as ComboBoxItem)?.Value;
            DateTime AppointmentDate;
            TimeSpan AppointmentTime=TimeSpan.Zero;
            if (dateCombo.SelectedItem != null)
            {
                AppointmentDate = DateTime.ParseExact(dateCombo.SelectedItem.ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Please select a date.");
                return;
            }
            if (TimeCombo.SelectedItem != null)
            {
                AppointmentTime = DateTime.ParseExact(TimeCombo.SelectedItem.ToString(), "hh:mm tt",
                    System.Globalization.CultureInfo.InvariantCulture).TimeOfDay;
            }
            else
            {
                MessageBox.Show("Please select a time.");
            }
            if (!string.IsNullOrWhiteSpace(AppointmentID) && !string.IsNullOrWhiteSpace(DoctorID) && AppointmentDate != null && AppointmentTime != null)
            {
                using (SqlConnection connect = new SqlConnection(UtilityCLass.getConnectionString()))
                {
                    string query1 = "SELECT COUNT(*) FROM Appointment WHERE AppointmentID=@AppointmentID";
                    SqlCommand cmd1 = new SqlCommand(query1, connect);
                    cmd1.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    connect.Open();
                    int count = (int)cmd1.ExecuteScalar();
                    connect.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("AppointmentID already taken.Try Different AppointmentID.");
                        return;
                    }
                }
                if (IsTimeSlotAvailable(DoctorID, AppointmentDate, AppointmentTime))
                {
                    string query = "INSERT INTO Appointment (AppointmentID, PatientID, DoctorID, AppointmentDate, AppointmentTime) " +
                                   "VALUES (@AppointmentID, @PatientID, @DoctorID, @AppointmentDate, @AppointmentTime)";
                    using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                            cmd.Parameters.AddWithValue("@PatientID", Skylines.UIForms.Login.PatientID);
                            cmd.Parameters.AddWithValue("@DoctorID", DoctorID);
                            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                            cmd.Parameters.AddWithValue("@AppointmentTime", AppointmentTime);

                            connection.Open();
                            int rowsaffected = cmd.ExecuteNonQuery();
                            if (rowsaffected > 0)
                            {
                                MessageBox.Show("Appointment Booked Successfully");
                                DisplayAppointments();


                            }
                            else
                            {
                                MessageBox.Show("Error Booking Appointment.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Time Slot Not Available.");
                }
            }
            else
            {
                MessageBox.Show("Please Fill in all the fields.");
            }

        }
        public bool IsTimeSlotAvailable(string DoctorID,DateTime AppointmentDate,TimeSpan AppointmentTime)
        {
            string query = "SELECT COUNT(*) FROM Appointment WHERE DoctorID=@DoctorID and AppointmentDate=@AppointmentDate and AppointmentTime=@AppointmentTime";
            using (SqlConnection connect = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@DoctorID", DoctorID);
                cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                cmd.Parameters.AddWithValue("@AppointmentTime", AppointmentTime);
                connect.Open();
                int count = (int)cmd.ExecuteScalar();
                connect.Close();
                if (count > 0)
                {
                    return false;
                }
                return true;
            }
        }
        public void FillDate()
        {
            string DoctorID= (DoctorCombo.SelectedItem as ComboBoxItem)?.Value;
            if (DoctorID != null)
            {
                string query = "SELECT AvailableDate FROM DoctorSchedule WHERE DoctorID=@DoctorID";

                using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DoctorID", DoctorID);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime availableDate = reader.GetDateTime(0);
                        dateCombo.Items.Add(availableDate.ToString("yyyy-MM-dd"));

                    }


                    reader.Close();
                    connection.Close();
                }
            }
        }
        public void FillTime()
        {
            string DoctorID = (DoctorCombo.SelectedItem as ComboBoxItem)?.Value;
            DateTime selectedDate;
            if (dateCombo.SelectedItem != null)
            {
                selectedDate = DateTime.ParseExact(dateCombo.SelectedItem.ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Please select a date.");
                return; 
            }
            if (DoctorID != null && selectedDate!=null)
            {
                string query = "SELECT StartTime,EndTime FROM DoctorSchedule WHERE DoctorID=@DoctorID and AvailableDate=@AvailableDate";

                using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DoctorID", DoctorID);
                    command.Parameters.AddWithValue("@AvailableDate", selectedDate);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan startTime = reader.GetTimeSpan(0);
                        TimeSpan endTime = reader.GetTimeSpan(1);

                        for (TimeSpan slot = startTime; slot < endTime; slot = slot.Add(TimeSpan.FromMinutes(30)))
                        {
                            TimeCombo.Items.Add(DateTime.Today.Add(slot).ToString("hh:mm tt"));
                        }
                    }


                    reader.Close();
                    connection.Close();
                }
            }
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void DisplayAppointments()
        {
            string query = "SELECT a.AppointmentID,a.PatientID,d.DoctorID,d.DoctorName,a.AppointmentDate,a.AppointmentTime FROM Appointment as a JOIN Doctor as d ON a.DoctorID=d.DoctorID WHERE a.PatientID=@PatientID";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientID",Skylines.UIForms.Login.PatientID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                AppointmentGrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }
        private void dateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeCombo.Items.Clear();
            FillTime();
        }

        private void AppointmentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
