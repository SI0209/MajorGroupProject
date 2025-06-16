using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingSchoolBookingSystem
{
    public partial class HomeForm : Form
    {
        LoginForm loginForm;
        public string Employee_Name, Employee_Surname, Employee_Type, Employee_Username;
        public HomeForm(LoginForm Loginform)
        {
            InitializeComponent();
            loginForm = Loginform;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lblUsernameInfo.Text = "Welcome " + Employee_Name + " " + Employee_Surname + "!";
              lblUserType.Text = Employee_Type;
        }
        

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorSchedule instructorschedule = new InstructorSchedule(loginForm);
            instructorschedule.ShowDialog();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageBooking lesson = new ManageBooking();
            lesson.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageLearners learnerform = new ManageLearners();
            learnerform.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageVehiclesForm vehicles = new ManageVehiclesForm();
            vehicles.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            LearnerProgressForm LearnerProgress = new LearnerProgressForm();
            LearnerProgress.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnalyticsForm analytics = new AnalyticsForm();
            analytics.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageInstruc instructor = new ManageInstruc();
            instructor.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnavailableTimeSlots unavailableTimeSlots = new UnavailableTimeSlots();
            unavailableTimeSlots.ShowDialog();
        }
    }
}
