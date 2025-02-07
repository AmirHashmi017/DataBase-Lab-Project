using Skylines.UIForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Skylines.UIForms.User
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            
            InitializeComponent();
            this.Size = new Size(850, 700);
        }
        public void loadForm(object form)
        {
            if (this.LoadingPanel.Controls.Count > 0)
            {
                this.LoadingPanel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.LoadingPanel.Controls.Add(f);
            this.LoadingPanel.Tag = f;
            f.Show();


        }
        private void LoadingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserPanel_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
     
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
