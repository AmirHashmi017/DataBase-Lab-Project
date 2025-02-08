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
    public partial class ApplyRoom : Form
    {
        public ApplyRoom()
        {
            InitializeComponent();
            FillRoomsCombo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ApplyRoom_Load(object sender, EventArgs e)
        {
            DisplayRooms();
        }

        private void FillRoomsCombo()
        {
            string query = "SELECT RoomID from Room where AvailableBeds > 0";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string reg = reader.GetString(0);
                    roomCombo.Items.Add(reg);

                }


                reader.Close();
                connection.Close();
            }
        }


        private void DisplayRooms()
        {
            string query = "SELECT r.RoomID, d.DepartmentName, r.TotalBeds, r.AvailableBeds FROM Room as r join Department as d on r.DepartmentID = d.DepartmentID where r.AvailableBeds > 0";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                RoomsGrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateIDCombo())
            {
                return;
            }

            string query = "INSERT INTO PatientRoomBooking (RoomID, PatientID) VALUES (@roomID, @patientID);UPDATE Room SET AvailableBeds = AvailableBeds - 1 WHERE RoomID = @roomID AND AvailableBeds > 0;";

      

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@roomID", roomCombo.Text);
                cmd.Parameters.AddWithValue("@patientID", Skylines.UIForms.Login.PatientID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                RoomsGrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }

            MessageBox.Show("Room Alotting Success!");
            DisplayRooms();


        }


        private bool ValidateIDCombo()
        {
            if(roomCombo.SelectedItem == null)
            {
                MessageBox.Show("ID can't be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (CheckExistence())
            {
                MessageBox.Show("Room Already Booked Against Your ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool CheckExistence()
        {
            SqlConnection con = new SqlConnection(UtilityCLass.getConnectionString());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PatientRoomBooking where RoomID = @roomID and patientID = @patientID", con);
            cmd.Parameters.AddWithValue("@roomID", roomCombo.Text);
            cmd.Parameters.AddWithValue("@patientID", Skylines.UIForms.Login.PatientID);
            int count = (int)(cmd.ExecuteScalar());

            con.Close();

            
            return count > 0;
        }

        private void RoomsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
