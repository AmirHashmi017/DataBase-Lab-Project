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
    public partial class ViewRooms : Form
    {
        public ViewRooms()
        {
            InitializeComponent();
        }

        private void ViewRooms_Load(object sender, EventArgs e)
        {
            DisplayRooms();
        }

        private void DisplayRooms()
        {
            string query = "SELECT prb.RoomID, r.DepartmentID, d.DepartmentName FROM PatientRoomBooking AS prb JOIN Room AS r ON prb.RoomID = r.RoomID  JOIN Department AS d ON r.DepartmentID = d.DepartmentID;";

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
