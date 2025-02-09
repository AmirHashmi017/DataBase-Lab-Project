
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMS.UIForms.Admin
{
    public partial class Add_Doctor : Form
    {
        public Add_Doctor()
        {
            InitializeComponent();
        }
        
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton24_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            ID.Text = "";
            DoctorName.Text = "";
            Specs.Text = "";
            number.Text = "";
            salary.Text = "";
            email.Text = "";
            pass.Text = "";
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string check = "SELECT * FROM Doctor WHERE DoctorID = '" + ID.Text + "'";
            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                SqlCommand command = new SqlCommand(check, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("DoctorID already taken.Try Different DoctorID.");
                    return;
                }
                reader.Close();
                connection.Close();
            }
            string query = "INSERT INTO Doctor (DoctorID,LoginPassword,DoctorName, Specialization,Email, PhoneNumber, Salary)"
              + "VALUES(@ID,@pass,@DoctorName,@Specs,@Email,@number,@salary)";
            using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", ID.Text);
                    command.Parameters.AddWithValue("@DoctorName", DoctorName.Text);
                    command.Parameters.AddWithValue("@pass", pass.Text);
                    command.Parameters.AddWithValue("@Specs", Specs.Text);
                    command.Parameters.AddWithValue("@Email", email.Text);
                    command.Parameters.AddWithValue("@number", number.Text);
                    command.Parameters.AddWithValue("@salary", salary.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Doctor Added Successfully");
                    Clear();
                    DisplayDoctors();
                }
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DisplayDoctors()
        {
            string query = "SELECT DoctorID, DoctorName,Specialization, Email,PhoneNumber,Salary FROM Doctor";

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

        private void Doctorgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Add_Doctor_Load_1(object sender, EventArgs e)
        {
            DisplayDoctors();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Doctorgrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}