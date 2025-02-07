using SkyLines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Skylines;
using SkyLinesLibrary;


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

            string name = nameTxt.Text;

            string password = passwordTxt.Text;
            if (ObjectHandler.GetAdminDL().CheckValidAdminName(name) && ObjectHandler.GetClientDL().CheckValidClientName(name))
            {
                string role = RoleTxt.Text;

                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(role))
                {
                    if (Validations.CheckCommaandColon(nameTxt.Text) && Validations.CheckCommaandColon(passwordTxt.Text))
                    { 
                        if (role.ToLower() == "admin" || role.ToLower() == "user")
                    {
                        if (role.ToLower() == "admin")
                        {
                            SkyLinesLibrary.Admin newAdmin = new SkyLinesLibrary.Admin(name, password, role);
                            ObjectHandler.GetAdminDL().AddAdmin(newAdmin);
                        }
                        if (role.ToLower() == "user")
                        {
                            Client newClient = new Client(name, password, role);
                            ObjectHandler.GetClientDL().AddClient(newClient);
                        }


                        MessageBox.Show("Successfully Signed Up..");
                        Clear();
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Role..");
                    }
                }
                    else
                    {
                        MessageBox.Show(", and ; is not allowed in any field.");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }

            else
            {
                MessageBox.Show("Username Already Exits.Try any other UseName.");
            }
            Clear();
        }
            private void Clear()
            {
                nameTxt.Text = "";
                passwordTxt.Text = "";
                RoleTxt.Text = "";
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
    }
    }
