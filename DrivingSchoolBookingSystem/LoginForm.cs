using DrivingSchoolBookingSystem;
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
    public partial class LoginForm : Form
    {
        public string Employee_Username;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
           

    }

    private void usernametextBox_TextChanged(object sender, EventArgs e)
        {
            Employee_Username = usernametextBox.Text;
            string passwordID = passwordtextBox.Text;
            Boolean isFound = false;
            Boolean isManager = false;

            if (passwordtextBox.Text == "" || usernametextBox.Text == "")
            {
                MessageBox.Show("Please Enter missing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataRow row in wstGrp2DataSet1.tblEmployee.Rows)
                {
                    if (row["Employee_Username"].ToString().Equals("Employee_Username") && row["Employee_Password"].ToString().Equals(passwordID))
                    {
                        if (row["Employee_Type"].ToString().Equals("Manager"))
                        {
                            isManager = true;
                        }
                        isFound = true;
                        break;
                    }

                }
                if (isFound)
                {
                    if (isManager)
                    {
                        MessageBox.Show("Welcome to the Araf's Driving School Booking System! ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ManageInstruc mngEmployee = new ManageInstruc();
                        mngEmployee.Show();

                    }
                    else
                    {
                      
                        MessageBox.Show("Instructor Access Denied", "Security", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("Invalid Log In Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            /*this.Hide();
            ManageInstruc mngEmployee = new ManageInstruc();
            mngEmployee.Show();*/
        }

        private void viewpasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (viewpasswordcheckBox.Checked)
            {
                passwordtextBox.PasswordChar = '\0';
            }
            else
            {
                passwordtextBox.PasswordChar = '*';
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            passwordtextBox.Text = "";
            usernametextBox.Text = "";
            usernametextBox.Focus();

        }

        private void FgtPassbtn_Click(object sender, EventArgs e)
        {
            if (usernametextBox.Text == "")
                MessageBox.Show("Please enter a gmail address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Boolean isUsernameValid = false;
                string Employee_Username = usernametextBox.Text;
                foreach (DataRow row in wstGrp2DataSet1.tblEmployee.Rows)
                {
                    if (row["Employee_Username"].ToString().Equals("Employee_Username"))
                    {
                        isUsernameValid = true;
                        break;
                    }

                }
                if (isUsernameValid)
                {
                    this.Hide();
                    Password newPassword = new Password();
                    newPassword.Show();
                }
                else
                    MessageBox.Show("Please enter an existing gmail address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

