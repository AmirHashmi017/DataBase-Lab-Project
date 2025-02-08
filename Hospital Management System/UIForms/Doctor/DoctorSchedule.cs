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
    public partial class DoctorSchedule : Form
    {
        public DoctorSchedule()
        {
            InitializeComponent();
        }

        private void DoctorSchedule_Load(object sender, EventArgs e)
        {
            dateTxt.Value = DateTime.Now.Date;
            starttimeTxt.Value = DateTime.Now;
            endtimeTxt.Value = DateTime.Now.AddHours(1);
            DisplaySchedules();
        }
        private void DisplaySchedules()
        {
            string query = "SELECT s.ScheduleID, s.DoctorID, d.DoctorName, s.AvailableDate,s.StartTime,s.EndTime,s.Status FROM DoctorSchedule as s join Doctor as d on s.DoctorID = d.DoctorID where s.DoctorID = @DoctorID";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorID", Skylines.UIForms.Login.DoctorID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                ScheduleGrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Datetxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Takeofftxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string ScheduleID = IDTxt.Text;
            DateTime ScheduleDate = dateTxt.Value.Date;
            TimeSpan starttime = starttimeTxt.Value.TimeOfDay;
            TimeSpan endtime = endtimeTxt.Value.TimeOfDay;
            string status = "Available";
            if (!string.IsNullOrWhiteSpace(ScheduleID) && ScheduleDate!=null && starttime!=null && endtime!=null)
            {
                using (SqlConnection connect = new SqlConnection(UtilityCLass.getConnectionString()))
                {
                    string query1 = "SELECT COUNT(*) FROM DoctorSchedule WHERE ScheduleID=@ScheduleID";
                    SqlCommand cmd1 = new SqlCommand(query1, connect);
                    cmd1.Parameters.AddWithValue("@ScheduleID", ScheduleID);
                    connect.Open();
                    int count = (int)cmd1.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("ScheduleID already taken.Try Different ScheduleID.");
                        return;
                    }
                    connect.Close();
                }
                using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
                {
                    string query = "INSERT INTO DoctorSchedule (ScheduleID,DoctorID,AvailableDate,StartTime,EndTime,Status) " +
                                   "VALUES (@ScheduleID, @DoctorID, @AvailableDate, @StartTime, @EndTime, @Status)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ScheduleID",ScheduleID);
                        cmd.Parameters.AddWithValue("@DoctorID", Skylines.UIForms.Login.DoctorID);
                        cmd.Parameters.AddWithValue("@AvailableDate", ScheduleDate);
                        cmd.Parameters.AddWithValue("@StartTime", starttime);
                        cmd.Parameters.AddWithValue("@EndTime", endtime);
                        cmd.Parameters.AddWithValue("@Status", status);

                        connection.Open();
                        int rowsaffected = cmd.ExecuteNonQuery();
                        if (rowsaffected > 0)
                        {
                            MessageBox.Show("Schedule Added Successfully");
                            DisplaySchedules();
                        }
                        else
                        {
                            MessageBox.Show("Error Adding Schedule");
                        }
                    }

                    connection.Close();

                }
            }
            else
            {
                MessageBox.Show("Please Fill in all the fields");
            }
        }
        public void Clear()
        {
            IDTxt.Text = "";
        }

        private void FlightGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
