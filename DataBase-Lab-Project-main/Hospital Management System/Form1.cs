using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Skylines.UIForms;
using Login = Skylines.UIForms.Login;
namespace Skylines
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {

            InitializeComponent();
        }
        public void loadForm(object form)
        {
            if(this.MainPanel.Controls.Count>0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //funtions to open forms
     
        private void SignUp_Label_Click(object sender, EventArgs e)
        {
            loadForm(new SignUp());
            
            
           

          
        }

        private void Login_Click(object sender, EventArgs e)
        {
            loadForm(new Login());
        }

        private void AdminPage_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Top -= 1;
            if (label2.Top <= 350)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Top += 1;
            if (label2.Top >= 550)
            {
                timer1.Start();
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            load1.Width += 5;
            if (load1.Width > 550)
            {
                timer3.Stop();
                this.Hide();
                Login l = new Login();
               
                l.Show();
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
