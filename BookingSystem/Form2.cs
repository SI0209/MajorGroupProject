using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = null; // Remove the default background image
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(50, 50, 50);
            this.TransparencyKey = Color.FromArgb(50, 50, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private bool isPainting = false;

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            if (isPainting) return;

            isPainting = true;
            base.OnPaint(e);

            // Create a gradient background
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb((255/2), 1, 0, 69),  // Dark blue (left side)
                Color.FromArgb((255/2), 2, 0, 196), // Lighter but dark blue (right side)
                45F))  // Angle of the gradient
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            isPainting = false;
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a gradient background
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 1, 0, 69),  // Dark blue (left side)
                Color.FromArgb(255, 2, 0, 196), // Lighter but dark blue (right side)
                0F))  // Angle of the gradient
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
    }
