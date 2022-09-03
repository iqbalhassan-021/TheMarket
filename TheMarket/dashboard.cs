using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheMarket
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Are you sure about clossing the application?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            

            if(results == DialogResult.Yes)         {


                auth auth = new auth();
                this.Close();
                auth.Close();
            }
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void products2_Load(object sender, EventArgs e)
        {
            
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            about1.Hide();
            browser1.Hide();
            help1.Hide();
            staff1.Hide();
         
            products1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           about1.Hide();
           browser1.Hide();
           help1.Hide();
           staff1.Hide();
          
           products1.Hide();
           dashb1.Show();
         dashb1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           about1.Hide();
           browser1.Hide();
           help1.Hide();
         staff1.Hide();
         
           dashb1.Hide();
           products1.Show();
          products1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void products1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            auth auth = new auth();
            this.Close();
            auth.Show();
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

            about1.Hide();
            browser1.Hide();
            help1.Hide();
      
           products1.Hide();
           dashb1.Hide();
          staff1.Show();
           staff1.BringToFront();
        
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
          about1.Hide();
           browser1.Hide();
          help1.Hide();

            
         products1.Hide();
          dashb1.Hide();
          staff1.Hide();

        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            about1.Hide();
       
          help1.Hide();
      

          products1.Hide();
        dashb1.Hide();
      staff1.Hide();
 
      browser1.Show();
      browser1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          about1.Hide();

       


           products1.Hide();
           dashb1.Hide();
           staff1.Hide();
        
           browser1.Hide();
         help1.Show();
         help1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
   




          products1.Hide();
          dashb1.Hide();
         staff1.Hide();
 
         browser1.Hide();
         help1.Hide();
         about1.Show();
        about1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dashb1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_KeyDown(object sender, KeyEventArgs e)
        {
     
        }

        private void browser1_Load(object sender, EventArgs e)
        {
            
        }

        private void dashboard_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Q)
            {
                this.Close();
            }
                
        }
        private bool mousedown;
        private Point lastlocation;
        private void dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            lastlocation = e.Location;
        }

        private void dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Location = new Point((this.Location.X - lastlocation.X)+e.X,(this.Location.Y - lastlocation.Y)+e.Y);
                this.Update();

            }
        }

        private void dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void dashb1_Load_1(object sender, EventArgs e)
        {

        }

        private void dashb1_Load_2(object sender, EventArgs e)
        {

        }

        private void dashb1_Load_3(object sender, EventArgs e)
        {

        }
    }
}
