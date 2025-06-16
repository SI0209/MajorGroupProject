using System;
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
    public partial class InstructorSchedule : Form
    {
        LoginForm loginform;
        string name;
        string surname;
        int EmployeeID;
        public InstructorSchedule(LoginForm login)
        {
            InitializeComponent();
            loginform = login;
            taEmployee.Fill(dsBookingSystem.tblEmployee);
            foreach (DataRow row in dsBookingSystem.tblEmployee.Rows)
            {
                if (row["Employee_Username"].ToString().Equals(login.Employee_username))
                {
                    name = row["Employee_Name"].ToString();
                    surname = row["Employee_Surname"].ToString();
                    EmployeeID = Convert.ToInt16(row["EmployeeID"]);
                    break;
                }
            }
            string today = DateTime.Now.Date.ToString("yyyy-MM-dd");
            //MessageBox.Show(today);
            taInstructorSchedule.Fill(dsBookingSystem.tblInstuctorSchedule, EmployeeID, today);
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        

        

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            string searchDate = dtpDate.Value.Date.ToShortDateString();
            taInstructorSchedule.SearchByDate(dsBookingSystem.tblInstuctorSchedule, EmployeeID, dtpDate.Value.ToShortDateString());
        }

        private void pbBack_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(loginform);
            home.lblUsernameInfo.Text = "Welcome " + loginform.Employee_Name + " " + loginform.Employee_Surname + "!";
            home.lblUserType.Text = loginform.Employee_Type;
            home.Show();
            this.Hide();
        }


        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
