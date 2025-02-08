using Skylines.UIForms.admin;
using System;
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
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string con = "your_connection_string_here";
            string query = "INSERT INTO Doctor (DoctorID, DoctorName, Specialization, PhoneNumber, Salary)"
              + "VALUES(@ID,@DoctorName,@Specs,@number,@salary)";
            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", ID.Text);
                    command.Parameters.AddWithValue("@DoctorName", DoctorName.Text);
                    command.Parameters.AddWithValue("@Specs", Specs.Text);
                    command.Parameters.AddWithValue("@number", number.Text);
                    command.Parameters.AddWithValue("@salary", salary.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Doctor Added Successfully");
                    Clear();
                }
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }
    }
}
