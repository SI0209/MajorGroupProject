﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingSchoolBookingSystem
{
    public partial class AnalyticsForm : Form
    {
        LoginForm loginform;
        public AnalyticsForm()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm home = new HomeForm(loginform);
            home.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm home = new HomeForm(loginform);
            home.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
