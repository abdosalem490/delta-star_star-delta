using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(800, 500);
            this.MaximumSize = new Size(800, 500);
            this.Size = new Size(800, 500);
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(50, 255, 255), Color.FromArgb(255, 255, 255),LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
           
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
           
            label1.BackColor = Color.Transparent;
            
        }

 
        private void button_WOC3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC2_MouseHover(object sender, EventArgs e)
        {
            groupBox2.BackColor = Color.Yellow;
        }

        private void button_WOC2_MouseLeave(object sender, EventArgs e)
        {
            groupBox2.BackColor = Color.Transparent;
        }

        private void button_WOC1_MouseHover(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Yellow;
   
        }

        private void button_WOC1_MouseLeave(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Transparent;

        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
