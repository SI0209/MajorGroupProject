using BookingSystem.WstGrp2DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DrivingSchoolBookingSystem
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void updatePasswordbtn_Click(object sender, EventArgs e)
        {
            string newPassword = passwordUpdatetxtbox.Text;
            string confirmPass = confirmpasswordtxtbox.Text;
            if (passwordUpdatetxtbox.Text == "" && confirmpasswordtxtbox.Text == "")
            {
                MessageBox.Show("Password not entered", "Password Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passwordUpdatetxtbox.Text == confirmpasswordtxtbox.Text)
            {

               // tblEmployeeTableAdapter1.UpdateEmployeePassword(newPassword, username);
                MessageBox.Show("Your Password has been Successfully Updated", "Password Change Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearbuttonpasswordform.PerformClick();
            }
            else
            {
                MessageBox.Show("Passwords do not match, Please Re-enter", "Password Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordUpdatetxtbox.Focus();
            }
        }

        private void clearbuttonpasswordform_Click(object sender, EventArgs e)
        {
            passwordUpdatetxtbox.Clear();
            confirmpasswordtxtbox.Clear();
            passwordUpdatetxtbox.Focus();

        }

        private void passwordformcheckboc_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordformcheckboc.Checked)
            {
                passwordUpdatetxtbox.PasswordChar = '\0';
                confirmpasswordtxtbox.PasswordChar = '\0';
            }
            else
            {
                passwordUpdatetxtbox.PasswordChar = '*';
                confirmpasswordtxtbox.PasswordChar = '*';
            }

        }

        private void backbtnpasswordform_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm backTologin = new LoginForm();
            backTologin.Show();

        }
    }
}

