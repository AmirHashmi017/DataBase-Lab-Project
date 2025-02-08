using AMS.UIForms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            this.Hide();
            AddDepartment Add_Dept = new AddDepartment();
            Add_Dept.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRoom Add_Room = new AddRoom();
            Add_Room.Show();

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
            this.Hide();
            Add_Doctor add_Doctor = new Add_Doctor();
            add_Doctor.Show();

        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Nurse add_Nurse = new Add_Nurse();
            add_Nurse.Show();
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

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton10_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton12_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton13_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton14_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton15_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton16_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton17_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton18_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton19_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton20_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton21_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton22_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton23_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton25_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton26_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton27_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton28_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton29_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton30_Click(object sender, EventArgs e)
        {

        }
    }
}
