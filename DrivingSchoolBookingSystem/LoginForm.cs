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
using System.Globalization;

namespace DrivingSchoolBookingSystem
{
    public partial class LoginForm : Form
    {
        public string Employee_username, Employee_Name, Employee_Surname, Employee_Type;
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            taEmployee.Fill(wstGrp2DataSet.tblEmployee);
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            Employee_username = usernametextBox.Text;
            string passwordID = passwordtextBox.Text;
            Boolean isFound = false;
            Boolean isManager = false;

            if (passwordtextBox.Text == "" || usernametextBox.Text == "")
            {
                MessageBox.Show("Please Enter missing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataRow row in wstGrp2DataSet.tblEmployee.Rows)
                {
                    if (row["Employee_Username"].ToString().Equals(Employee_username) && row["Employee_Password"].ToString().Equals(passwordID))
                    {
                        if (row["Employee_Type"].ToString().Equals("Manager"))
                        {
                            isManager = true;
                            Employee_Name = row["Employee_Name"].ToString();
                            Employee_Surname = row["Employee_Surname"].ToString();
                            Employee_username = row["Employee_Username"].ToString();
                        }
                        isFound = true;
                        Employee_Name = row["Employee_Name"].ToString();
                        Employee_Surname = row["Employee_Surname"].ToString();
                        Employee_username = row["Employee_Username"].ToString();
                        break;
                    }

                }
                if (isFound)
                {
                    if (isManager)
                    {
                        MessageBox.Show("Welcome to Araf's Driving School! ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        HomeForm homepage = new HomeForm(this);
                        homepage.Employee_Username = Employee_username;
                        homepage.Employee_Name = Employee_Name;
                        homepage.Employee_Surname = Employee_Surname;
                        homepage.Employee_Type = "Manager";
                        homepage.Show();

                    }
                    else
                    {
                        this.Hide();
                        HomeForm homepage = new HomeForm(this);
                        homepage.Employee_Username = Employee_username;
                        homepage.Employee_Name = Employee_Name;
                        homepage.Employee_Surname = Employee_Surname;
                        homepage.Employee_Type = "Instructor";

                        //MessageBox.Show("Instructor Access Denied", "Security", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void chkBxShowPas_CheckedChanged(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            passwordtextBox.Text = "";
            usernametextBox.Text = "";
            usernametextBox.Focus();
        }

        private void btnForgetPas_Click(object sender, EventArgs e)
        {
            if (usernametextBox.Text == "")
                MessageBox.Show("Please enter a gmail address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Boolean isUsernameValid = false;
                Employee_username = usernametextBox.Text;
                foreach (DataRow row in wstGrp2DataSet.tblEmployee.Rows)
                {
                    if (row["Employee_Username"].ToString().Equals(Employee_username))
                    {
                        isUsernameValid = true;
                        break;
                    }

                }
                if (isUsernameValid)
                {
                    this.Hide();
                    Password newPassword = new Password(this);
                    newPassword.Show();
                }
                else
                    MessageBox.Show("Please enter an existing gmail address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        /* private void button1_Click(object sender, EventArgs e)
         {
             AnalyticsForm a1 = new AnalyticsForm();
                 a1.Show();
         }*/
    }
}

