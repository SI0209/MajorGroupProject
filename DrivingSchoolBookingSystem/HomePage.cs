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


            toolTip1.SetToolTip(pictureBox8, "Manage all learner records");
            toolTip1.SetToolTip(pictureBox14, "Manage all employee records");
            toolTip1.SetToolTip(pictureBox10, "Manage all vehicle records");
            toolTip1.SetToolTip(pictureBox1, "Create and assign lesson bookings to learners");
            toolTip1.SetToolTip(pictureBox12, "Track learner performance");
            toolTip1.SetToolTip(pictureBox3, "View instructor unavailable time slots");
            toolTip1.SetToolTip(pictureBox4, "View all instructor schedules");
            toolTip1.SetToolTip(pictureBox2, "Generate analytics and progress reports");

           
            toolTip1.IsBalloon = true;
            toolTip1.AutoPopDelay = 3000;   // Tooltip stays visible for 3 seconds
            toolTip1.InitialDelay = 500;    // Wait 0.5 seconds before showing tooltip
            toolTip1.ReshowDelay = 500;     // Delay before showing again when moving quickly


           


        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            lblUsernameInfo.Text = "Welcome " + Employee_Name + " " + Employee_Surname + "!";
              lblUserType.Text = "Role:" + " " +  Employee_Type;

            if (Employee_Type == "Admin")
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox12.Enabled = true;
                pictureBox4.Enabled = false;                                                                
                pictureBox10.Enabled = false;
                pictureBox14.Enabled = false;
                
            }

            if (Employee_Type == "Manager")
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox12.Enabled = true;
                pictureBox4.Enabled = true;                                                                
                pictureBox10.Enabled = true;
                pictureBox14.Enabled = true;
            }

            if (Employee_Type == "Instructor")
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = true;
                pictureBox8.Enabled = false;
                pictureBox12.Enabled = true;
                pictureBox4.Enabled = true;                                                                
                pictureBox10.Enabled = false;
                pictureBox14.Enabled = false;
            }

        }
       


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorSchedule instructorschedule = new InstructorSchedule(loginForm);
            instructorschedule.ShowDialog();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageLearners learnerform = new ManageLearners(loginForm);
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

        private void lblUserType_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageBooking lesson = new ManageBooking(loginForm);
            lesson.ShowDialog();
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
            ManageInstruc instructor = new ManageInstruc(loginForm);
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
