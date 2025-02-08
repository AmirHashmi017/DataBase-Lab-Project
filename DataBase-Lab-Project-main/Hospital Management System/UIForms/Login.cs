using Skylines.UIForms.admin;
using AMS.UIForms.User;
using AMS.UIForms.Doctor;
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
namespace Skylines.UIForms
{
    public partial class Login : Form
    {
        public static int Index;
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
            nameTxt.Text = "";
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
           
            string result = "";
            string name = nameTxt.Text;
            string password = passwordTxt.Text;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password))
            {
                if (name=="ali" && password=="123")
                { 
                    result = "patient";
                }
                else if (name == "amir" && password == "191")
                {
                    result = "admin";
                }
                else if (name == "mobeen" && password == "123")
                {
                    result = "doctor";
                }
                if (result != "")
                {
                    MessageBox.Show($"{name}! successfully Signed In.");
                }
                if (result == "")
                {
                    MessageBox.Show("No Such Person Exist.");
                }
                if (result.ToLower() == "admin")
                {
                    this.Hide();
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                }
                else if (result.ToLower() == "patient")
                {
                    this.Hide();
                    UserPanel userPanel = new UserPanel();
                    userPanel.Show();
                }
                else if(result.ToLower()=="doctor")
                 {
                    this.Hide();
                    DoctorPanel doctorPanel = new DoctorPanel();
                    doctorPanel.Show();
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
