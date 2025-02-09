using AMS.UIForms.User;
using AMS.UIForms.Doctor;
using AMS.UIForms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMS;
using System.Data.SqlClient;
namespace Skylines.UIForms
{
    public partial class Login : Form
    {
        public static string PatientID;
        public static string DoctorID;
        public Login()
        {
           
            InitializeComponent();
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            idTxt.Text = "";
            passwordTxt.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string id = idTxt.Text;
            string password = passwordTxt.Text;
            string role = "";
            if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(password))
            {
                using (SqlConnection connect = new SqlConnection(UtilityCLass.getConnectionString()))
                {
                    string query1 = "SELECT COUNT(*) FROM Patient WHERE PatientID=@PatientID and LoginPassword=@LoginPassword";
                    SqlCommand cmd1 = new SqlCommand(query1, connect);
                    cmd1.Parameters.AddWithValue("@PatientID", id);
                    cmd1.Parameters.AddWithValue("@LoginPassword", password);
                    connect.Open();
                    int count = (int)cmd1.ExecuteScalar();
                    if (count > 0)
                    {
                        role = "Patient";
                        PatientID = id;
                    }
                    if (role == "")
                    {
                        string query2 = "SELECT COUNT(*) FROM Doctor WHERE DoctorID=@PatientID and LoginPassword=@LoginPassword";
                        SqlCommand cmd2 = new SqlCommand(query2, connect);
                        cmd2.Parameters.AddWithValue("@PatientID", id);
                        cmd2.Parameters.AddWithValue("@LoginPassword", password);
                        count = (int)cmd2.ExecuteScalar();
                        if (count > 0)
                        {
                            role = "Doctor";
                            DoctorID= id;
                        }
                    }
                    if (role == "")
                    {
                        string query3 = "SELECT COUNT(*) FROM Admin WHERE AdminID=@PatientID and LoginPassword=@LoginPassword";
                        SqlCommand cmd3 = new SqlCommand(query3, connect);
                        cmd3.Parameters.AddWithValue("@PatientID", id);
                        cmd3.Parameters.AddWithValue("@LoginPassword", password);
                        count = (int)cmd3.ExecuteScalar();
                        if (count > 0)
                        {
                            role = "Admin";
                        }
                    }
                    connect.Close();
                }
                if (role.ToLower() == "admin")
                {
                    this.Hide();
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                }
                else if (role.ToLower() == "patient")
                {
                    this.Hide();
                    UserPanel userPanel = new UserPanel();
                    userPanel.Show();
                }
                else if(role.ToLower()=="doctor")
                 {
                    this.Hide();
                    DoctorPanel doctorPanel = new DoctorPanel();
                    doctorPanel.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials.");
                }
            }
            else
            {
                MessageBox.Show("Please Fill In all the required fields.");
            }
            Clear();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp adminPanel = new SignUp();
            adminPanel.Show();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
