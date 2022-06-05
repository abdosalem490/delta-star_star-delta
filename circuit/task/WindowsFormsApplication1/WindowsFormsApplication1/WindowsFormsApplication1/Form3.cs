using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public Form3()
        {
            InitializeComponent();
            this.MinimumSize = new Size(800, 500);
            this.MaximumSize = new Size(800, 500);
            this.Size = new Size(800, 500);
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(96, 155, 173), 1);
            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(50, 255, 255), Color.FromArgb(255, 255, 255), LinearGradientMode.Vertical);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string R1 = textBox1.Text;
            string R2 = textBox2.Text;
            string R3 = textBox3.Text;
            if (String.IsNullOrEmpty(R1))
            {
                label9.Text = "you cant leave the value of Ra empty";
                label10.Text = "you cant leave the value of Ra empty";
                label11.Text = "you cant leave the value of Ra empty";
            }
            else if (!double.TryParse(R1, out _))
            {
                label9.Text = "you must only enter numbers in Ra";
                label10.Text = "you must only enter numbers in Ra";
                label11.Text = "you must only enter numbers in Ra";
            }
            else if (double.Parse(R1) <= 0)
            {
                label9.Text = "the value of Ra must be positive";
                label10.Text = "the value of Ra must be positive";
                label11.Text = "the value of Ra must be positive";
            }
            else if (String.IsNullOrEmpty(R2))
            {
                label9.Text = "you cant leave the value of Rb empty";
                label10.Text = "you cant leave the value of Rb empty";
                label11.Text = "you cant leave the value of Rb empty";
            }
            else if (!double.TryParse(R2, out _))
            {
                label9.Text = "you must only enter numbers in Rb";
                label10.Text = "you must only enter numbers in Rb";
                label11.Text = "you must only enter numbers in Rb";
            }
            else if (double.Parse(R2) <= 0)
            {
                label9.Text = "the value of Rb must be positive";
                label10.Text = "the value of Rb must be positive";
                label11.Text = "the value of Rb must be positive";
            }
            else if (String.IsNullOrEmpty(R3))
            {
                label9.Text = "you cant leave the value of Rc empty";
                label10.Text = "you cant leave the value of Rc empty";
                label11.Text = "you cant leave the value of Rc empty";
            }
            else if (!double.TryParse(R3, out _))
            {
                label9.Text = "you must only enter numbers in Rc";
                label10.Text = "you must only enter numbers in Rc";
                label11.Text = "you must only enter numbers in Rc";
            }
            else if (double.Parse(R3) <= 0)
            {
                label9.Text = "the value of Rc must be positive";
                label10.Text = "the value of Rc must be positive";
                label11.Text = "the value of Rc must be positive";
            }
            else
            {
                label9.Text = (((Double.Parse(R1) * Double.Parse(R2)) + (Double.Parse(R2) * Double.Parse(R3)) + (Double.Parse(R3) * double.Parse(R1))) / double.Parse(R1)).ToString();
                label10.Text = (((Double.Parse(R1) * Double.Parse(R2)) + (Double.Parse(R2) * Double.Parse(R3)) + (Double.Parse(R3) * double.Parse(R1))) / double.Parse(R2)).ToString();
                label11.Text = (((Double.Parse(R1) * Double.Parse(R2)) + (Double.Parse(R2) * Double.Parse(R3)) + (Double.Parse(R3) * double.Parse(R1))) / double.Parse(R3)).ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string R1 = textBox1.Text;
            string R2 = textBox2.Text;
            string R3 = textBox3.Text;
            if (String.IsNullOrEmpty(R1))
            {
                label9.Text = "you cant leave the value of Ra empty";
                label10.Text = "you cant leave the value of Ra empty";
                label11.Text = "you cant leave the value of Ra empty";
            }
            else if (!double.TryParse(R1, out _))
            {
                label9.Text = "you must only enter numbers in Ra";
                label10.Text = "you must only enter numbers in Ra";
                label11.Text = "you must only enter numbers in Ra";
            }
            else if (double.Parse(R1) <= 0)
            {
                label9.Text = "the value of Ra must be positive";
                label10.Text = "the value of Ra must be positive";
                label11.Text = "the value of Ra must be positive";
            }
            else if (String.IsNullOrEmpty(R2))
            {
                label9.Text = "you cant leave the value of Rb empty";
                label10.Text = "you cant leave the value of Rb empty";
                label11.Text = "you cant leave the value of Rb empty";
            }
            else if (!double.TryParse(R2, out _))
            {
                label9.Text = "you must only enter numbers in Rb";
                label10.Text = "you must only enter numbers in Rb";
                label11.Text = "you must only enter numbers in Rb";
            }
            else if (double.Parse(R2) <= 0)
            {
                label9.Text = "the value of Rb must be positive";
                label10.Text = "the value of Rb must be positive";
                label11.Text = "the value of Rb must be positive";
            }
            else if (String.IsNullOrEmpty(R3))
            {
                label9.Text = "you cant leave the value of Rc empty";
                label10.Text = "you cant leave the value of Rc empty";
                label11.Text = "you cant leave the value of Rc empty";
            }
            else if (!double.TryParse(R3, out _))
            {
                label9.Text = "you must only enter numbers in Rc";
                label10.Text = "you must only enter numbers in Rc";
                label11.Text = "you must only enter numbers in Rc";
            }
            else if (double.Parse(R3) <= 0)
            {
                label9.Text = "the value of Rc must be positive";
                label10.Text = "the value of Rc must be positive";
                label11.Text = "the value of Rc must be positive";
            }
            else
            {
                label9.Text = (((Double.Parse(R1) * Double.Parse(R2)) + (Double.Parse(R2) * Double.Parse(R3)) + (Double.Parse(R3) * double.Parse(R1))) / double.Parse(R1)).ToString();
                label10.Text = (((Double.Parse(R1) * Double.Parse(R2)) + (Double.Parse(R2) * Double.Parse(R3)) + (Double.Parse(R3) * double.Parse(R1))) / double.Parse(R2)).ToString();
                label11.Text = (((Double.Parse(R1) * Double.Parse(R2)) + (Double.Parse(R2) * Double.Parse(R3)) + (Double.Parse(R3) * double.Parse(R1))) / double.Parse(R3)).ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string R1 = textBox1.Text;
            string R2 = textBox2.Text;
            string R3 = textBox3.Text;
            if (String.IsNullOrEmpty(R1))
            {
                label9.Text = "you cant leave the value of Ra empty";
                label10.Text = "you cant leave the value of Ra empty";
                label11.Text = "you cant leave the value of Ra empty";
            }
            else if (!double.TryParse(R1, out _))
            {
                label9.Text = "you must only enter numbers in Ra";
                label10.Text = "you must only enter numbers in Ra";
                label11.Text = "you must only enter numbers in Ra";
            }
            else if (double.Parse(R1) <= 0)
            {
                label9.Text = "the value of Ra must be positive";
                label10.Text = "the value of Ra must be positive";
                label11.Text = "the value of Ra must be positive";
            }
            else if (String.IsNullOrEmpty(R2))
            {
                label9.Text = "you cant leave the value of Rb empty";
                label10.Text = "you cant leave the value of Rb empty";
                label11.Text = "you cant leave the value of Rb empty";
            }
            else if (!double.TryParse(R2, out _))
            {
                label9.Text = "you must only enter numbers in Rb";
                label10.Text = "you must only enter numbers in Rb";
                label11.Text = "you must only enter numbers in Rb";
            }
            else if (double.Parse(R2) <= 0)
            {
                label9.Text = "the value of Rb must be positive";
                label10.Text = "the value of Rb must be positive";
                label11.Text = "the value of Rb must be positive";
            }
            else if (String.IsNullOrEmpty(R3))
            {
                label9.Text = "you cant leave the value of Rc empty";
                label10.Text = "you cant leave the value of Rc empty";
                label11.Text = "you cant leave the value of Rc empty";
            }
            else if (!double.TryParse(R3, out _))
            {
                label9.Text = "you must only enter numbers in Rc";
                label10.Text = "you must only enter numbers in Rc";
                label11.Text = "you must only enter numbers in Rc";
            }
            else if (double.Parse(R3) <= 0)
            {
                label9.Text = "the value of Rc must be positive";
                label10.Text = "the value of Rc must be positive";
                label11.Text = "the value of Rc must be positive";
            }
            else
            {
                label9.Text = (((Double.Parse(R1) * Double.Parse(R2)) + (Double.Parse(R2) * Double.Parse(R3)) + (Double.Parse(R3)*double.Parse(R1)))/double.Parse(R1)).ToString();
                label10.Text = (((Double.Parse(R1) * Double.Parse(R2)) + (Double.Parse(R2) * Double.Parse(R3)) + (Double.Parse(R3) * double.Parse(R1))) / double.Parse(R2)).ToString();
                label11.Text = (((Double.Parse(R1) * Double.Parse(R2)) + (Double.Parse(R2) * Double.Parse(R3)) + (Double.Parse(R3) * double.Parse(R1))) / double.Parse(R3)).ToString();
            }
        }
    }
}
