using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkyLinesLibrary;
namespace Skylines.UIForms.admin
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            this.Size = new Size(950, 800);
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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoadingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton12_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton24_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
