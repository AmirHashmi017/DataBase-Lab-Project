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
using AMS;
using Skylines;


namespace Skylines.UIForms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string PatientID = IDTxt.Text;
            string LoginPassword = passwordTxt.Text;
            string PatientName = nameTxt.Text;
            DateTime DOB = dateTxt.Value.Date;
            string Gender=genderTxt.Text;
            string PhoneNumber=phoneTxt.Text;
            if (!string.IsNullOrWhiteSpace(PatientID) &&
    !string.IsNullOrWhiteSpace(LoginPassword) &&
    !string.IsNullOrWhiteSpace(PatientName) &&
    DOB != null && !string.IsNullOrWhiteSpace(Gender) &&
    !string.IsNullOrWhiteSpace(PhoneNumber))
            {
                using (SqlConnection connect = new SqlConnection(UtilityCLass.getConnectionString()))
                {
                    string query1 = "SELECT COUNT(*) FROM Patient WHERE PatientID=@PatientID";
                    SqlCommand cmd1 = new SqlCommand(query1, connect);
                    cmd1.Parameters.AddWithValue("@PatientID",PatientID);
                    connect.Open();
                    int count = (int)cmd1.ExecuteScalar();
                    if (count> 0)
                    {
                        MessageBox.Show("PatientID already taken.Try Different PatientID.");
                        return;
                    }
                    string query2 = "SELECT COUNT(*) FROM Doctor WHERE DoctorID=@PatientID";
                    SqlCommand cmd2 = new SqlCommand(query2, connect);
                    cmd2.Parameters.AddWithValue("@PatientID", PatientID);
                    count = (int)cmd2.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("PatientID already taken.Try Different PatientID.");
                        return;
                    }
                    string query3 = "SELECT COUNT(*) FROM Admin WHERE AdminID=@PatientID";
                    SqlCommand cmd3 = new SqlCommand(query3, connect);
                    cmd3.Parameters.AddWithValue("@PatientID", PatientID);
                    count = (int)cmd3.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("PatientID already taken.Try Different PatientID.");
                        return;
                    }
                    connect.Close();
                }
                using (SqlConnection connection = new SqlConnection(UtilityCLass.getConnectionString()))
                {
                    string query = "INSERT INTO Patient (PatientID, LoginPassword, PatientName, DOB, Gender, PhoneNumber) " +
                                   "VALUES (@PatientID, @LoginPassword, @PatientName, @DOB, @Gender, @PhoneNumber)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", PatientID);
                        cmd.Parameters.AddWithValue("@LoginPassword", LoginPassword);
                        cmd.Parameters.AddWithValue("@PatientName", PatientName);
                        cmd.Parameters.AddWithValue("@DOB", DOB);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

                        connection.Open();
                        int rowsaffected = cmd.ExecuteNonQuery();
                        if (rowsaffected > 0)
                        {
                            MessageBox.Show("Patient Added Successfully");
                            Clear();
                            this.Hide();
                            Login f = new Login();
                            f.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error Adding Patient");
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

        private void Clear()
            {
                nameTxt.Text = "";
                passwordTxt.Text = "";
                phoneTxt.Text = "";
                IDTxt.Text = "";
            dateTxt.Text = "";
            genderTxt.Text = "";
            }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f=new Login();
            f.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
