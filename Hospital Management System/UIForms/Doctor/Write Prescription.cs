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
    public partial class Write_Prescription : Form
    {
        public Write_Prescription()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void FillPatient()
        {
            string query = "SELECT DISTINCT(PatientID) from Appointment WHERE DoctorID=@DoctorID";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorID", Skylines.UIForms.Login.DoctorID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string reg = reader.GetString(0);
                    PatientCombo.Items.Add(reg);

                }


                reader.Close();
                connection.Close();
            }
        }

        private void DisplayDoctorPrescriptions()
        {
            string query = "SELECT p.PrescriptionID,p.PatientID,pa.PatientName,p.Dosage,p.Medicine,p.DoctorRemarks FROM Prescription as p JOIN Patient as pa ON p.PatientID=pa.PatientID WHERE p.DoctorID=@DoctorID";

            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorID", Skylines.UIForms.Login.DoctorID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                prescriptionGrid.DataSource = dataTable;
                reader.Close();
                connection.Close();
            }
        }
        private void Write_Prescription_Load(object sender, EventArgs e)
        {
            FillPatient();
            DisplayDoctorPrescriptions();
        }

        private void PatientCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prescriptionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string PrescriptionID=IDTxt.Text;
            string PatientID=PatientCombo.Text;
            String Dosage=DosageTxt.Text;
            String Medicine=medicineTxt.Text;
            string DoctorRemarks=remarksTxt.Text;
            if (!string.IsNullOrEmpty(PrescriptionID) && !string.IsNullOrEmpty(PatientID) && !string.IsNullOrWhiteSpace(Dosage) && !string.IsNullOrEmpty(Medicine) && !string.IsNullOrEmpty(DoctorRemarks))
            {
                using (SqlConnection connect = new SqlConnection(UtilityCLass.getConnectionString()))
                {
                    string query1 = "SELECT COUNT(*) FROM Prescription WHERE PrescriptionID=@PrescriptionID";
                    SqlCommand cmd1 = new SqlCommand(query1, connect);
                    cmd1.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
                    connect.Open();
                    int count = (int)cmd1.ExecuteScalar();
                    connect.Close();
                    if (count > 0)
                    {
                        MessageBox.Show("PrescriptionID already taken.Try Different PrescriptionID.");
                        return;
                    }
                }
                string query = "INSERT INTO Prescription (PrescriptionID, PatientID, DoctorID,Dosage,Medicine,DoctorRemarks) " +
                                  "VALUES (@PrescriptionID, @PatientID, @DoctorID, @Dosage, @Medicine,@DoctorRemarks)";
                using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
                        cmd.Parameters.AddWithValue("@PatientID", PatientID);
                        cmd.Parameters.AddWithValue("@DoctorID", Skylines.UIForms.Login.DoctorID);
                        cmd.Parameters.AddWithValue("@Dosage", Dosage);
                        cmd.Parameters.AddWithValue("@Medicine", Medicine);
                        cmd.Parameters.AddWithValue("@DoctorRemarks", DoctorRemarks);

                        connection.Open();
                        int rowsaffected = cmd.ExecuteNonQuery();
                        if (rowsaffected > 0)
                        {
                            MessageBox.Show("Prescription Added Successfully");
                            Clear();
                            DisplayDoctorPrescriptions();


                        }
                        else
                        {
                            MessageBox.Show("Error Adding Prescription.");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Please Fill in all the fields.");
            }
        }
        public void Clear()
        {
            IDTxt.Text = "";
            DosageTxt.Text = "";
            medicineTxt.Text = "";
            remarksTxt.Text = "";
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
