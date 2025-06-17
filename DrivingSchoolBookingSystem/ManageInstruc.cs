using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters;

namespace DrivingSchoolBookingSystem
{
    public partial class ManageInstruc : Form
    {
        private int employeeID = -1;
        private string originalName;
        private string originalSurname;
        private string originalIDNum;
        private int originalAge;
        private string originalGender;
        private string originalRace;
        private string originalPhone;
        private string originalAddress;
        private string originalSuburb;
        private string originalEmployeeType;
        private string originalEmail;
        public string employeename;
        public string employeesurname;
        public string employeetype;

        private LoginForm loginForm1;

        public ManageInstruc(LoginForm loginForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            loginForm1 = loginForm;
            string username = loginForm1.Employee_username;
            this.tblEmployeeTableAdapter.Fill(this.dsBookingSystem.tblEmployee);
            /*foreach (DataRow row in dsBookingSystem.tblEmployee.Rows)
            {
                if (row["Employee_Username"].ToString() == username)
                {
                    label1.Text = row["Employee_Name"].ToString() + " " + row["Employee_Surname"].ToString();
                    break;
                }
            }*/


        }
        public ManageInstruc()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.tblEmployeeTableAdapter.Fill(this.dsBookingSystem.tblEmployee);
        }


       

        private void dgvEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((int)dgvEmployee.CurrentRow.Cells[0].Value < 0)
            {
                return;
            }
            employeeID = (int)dgvEmployee.CurrentRow.Cells[0].Value;
            txtName.Text = originalName = (string)dgvEmployee.CurrentRow.Cells[1].Value;
            txtSurname.Text = originalSurname = (string)dgvEmployee.CurrentRow.Cells[2].Value;
            txtIDNum.Text = originalIDNum = (string)dgvEmployee.CurrentRow.Cells[3].Value;
            txtPhoneNum.Text = originalPhone = (string)dgvEmployee.CurrentRow.Cells[7].Value;
            txtStreetAddress.Text = originalAddress = (string)dgvEmployee.CurrentRow.Cells[8].Value;
            txtSuburb.Text = originalSuburb = (string)dgvEmployee.CurrentRow.Cells[9].Value;
            cbxType.Text = originalEmployeeType = (string)dgvEmployee.CurrentRow.Cells[10].Value;
            cbxGender.Text = originalGender = (string)dgvEmployee.CurrentRow.Cells[5].Value;
            cbxRace.Text = originalRace = (string)dgvEmployee.CurrentRow.Cells[6].Value;
            numericUpDownAge.Value = originalAge = (int)(dgvEmployee.CurrentRow.Cells[4].Value);
            txtUsername.Text = originalEmail = (string)dgvEmployee.CurrentRow.Cells[11].Value;

        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtIDNum.Text = "";
            txtPhoneNum.Text = "";
            txtStreetAddress.Text = "";
            txtSuburb.Text = "";
            cbxType.SelectedIndex = -1; // Reset combo box selection
            cbxGender.SelectedIndex = -1; // Reset combo box selection
            cbxRace.SelectedIndex = -1;
            numericUpDownAge.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            employeeID = -1;
            txtSearch.Text = "";
        }

        private bool AreAllFieldsFilled()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtIDNum.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNum.Text) ||
                string.IsNullOrWhiteSpace(txtStreetAddress.Text) ||
                string.IsNullOrWhiteSpace(txtSuburb.Text) ||
                cbxType.Text == null ||
                cbxGender.Text == null ||
                cbxRace.Text == null ||
                numericUpDownAge.Value == 0 ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                return false;
            }
            return true;
        }
        private bool AreAllFieldsFilledForUpdateandDelete()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtIDNum.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNum.Text) ||
                string.IsNullOrWhiteSpace(txtStreetAddress.Text) ||
                string.IsNullOrWhiteSpace(txtSuburb.Text) ||
                cbxType.Text == null ||
                cbxGender.Text == null ||
                cbxRace.Text == null ||
                numericUpDownAge.Value == 0)

            {
                return false;
            }
            return true;
        }

        private bool ValidateID(string idNum)
        {
            // Add logic to validate the ID number based on your specific requirements
            // For example, checking length, format, etc.
            return idNum.Length == 13 && idNum.All(char.IsDigit);
        }

        private bool ValidatePhone(string phone)
        {
            // Add logic to validate the phone number based on your specific requirements
            // For example, checking format, length, etc.
            return phone.Length == 10 && Regex.IsMatch(phone, @"^\d{10}$");
        }
        private bool ValidateNoDupEmployeeIDNum(string idNum)
        {
            foreach (var employee in dsBookingSystem.tblEmployee)
            {
                if (employee.Employee_IDNumber == idNum)
                {
                    return false;
                }
            }
            return true;
        }

        private bool validateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
        private bool ValidateNoDupUsername(string username, int currentEmployeeID)
        {
            var existingEmployee = dsBookingSystem.tblEmployee
                .AsEnumerable()
                .FirstOrDefault(emp => emp.Field<string>("Employee_Username") == username && emp.Field<int>("EmployeeID") != currentEmployeeID);

            return existingEmployee == null;
        }




        private bool HaveFieldsChanged()
        {
            return txtName.Text != originalName ||
                   txtSurname.Text != originalSurname ||
                   txtIDNum.Text != originalIDNum ||
                   txtPhoneNum.Text != originalPhone ||
                   txtStreetAddress.Text != originalAddress ||
                   txtSuburb.Text != originalSuburb ||
                   cbxType.SelectedItem.ToString() != originalEmployeeType ||
                   cbxGender.SelectedItem.ToString() != originalGender ||
                   cbxRace.SelectedItem.ToString() != originalRace ||
                   numericUpDownAge.Value != originalAge || txtUsername.Text != originalEmail;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkRed; // or a hover color you prefer
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string idNum = txtIDNum.Text;
                string phone = txtPhoneNum.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                if (!ValidateNoDupEmployeeIDNum(idNum))
                {
                    MessageBox.Show("This ID number already exists. Please enter a unique ID number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateID(idNum))
                {
                    MessageBox.Show("Invalid ID number. Please enter a valid 13-digit ID number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidatePhone(phone))
                {
                    MessageBox.Show("Invalid phone number. Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!validateEmail(username))
                {
                    MessageBox.Show("Invalid Gmail address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!ValidateNoDupUsername(username, -1))
                {
                    MessageBox.Show("This email already exists. Please enter a unique email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                DialogResult result = MessageBox.Show("Are you sure you want to add this employee?", "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                string name = txtName.Text;
                string surname = txtSurname.Text;
                string address = txtStreetAddress.Text;
                string suburb = txtSuburb.Text;
                string cbxTypeEmployee = cbxType.Text.ToString();
                string cbxEmployeeGender = cbxGender.Text.ToString();
                string cbxEmployeeRace = cbxRace.Text.ToString();
                int age = (int)(numericUpDownAge.Value);


                tblEmployeeTableAdapter.InsertNewEmployeeQuery(name, surname, idNum, age, cbxEmployeeGender, cbxEmployeeRace, phone, address, suburb, cbxTypeEmployee, username, password);
                tblEmployeeTableAdapter.Fill(dsBookingSystem.tblEmployee);
                MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding a new employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (employeeID != -1)
            {
                if (!AreAllFieldsFilledForUpdateandDelete())
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!HaveFieldsChanged())
                {
                    MessageBox.Show("No changes detected. Please modify at least one field before updating.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    string idNum = txtIDNum.Text;
                    string phone = txtPhoneNum.Text;
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    string email = txtUsername.Text;

                    if (!ValidateID(idNum))
                    {
                        MessageBox.Show("Invalid ID number. Please enter a valid 13-digit ID number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!ValidatePhone(phone))
                    {
                        MessageBox.Show("Invalid phone number. Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!ValidateNoDupUsername(username, employeeID))
                    {
                        MessageBox.Show("This email already exists. Please enter a unique email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    if (!validateEmail(email))
                    {
                        MessageBox.Show("Invalid gmail address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show("Are you sure you want to update this employee?", "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }

                    string name = txtName.Text;
                    string surname = txtSurname.Text;
                    string address = txtStreetAddress.Text;
                    string suburb = txtSuburb.Text;
                    string cbxTypeEmployee = cbxType.Text.ToString();
                    string cbxEmployeeGender = cbxGender.Text.ToString();
                    string cbxEmployeeRace = cbxRace.Text.ToString();
                    int age = (int)(numericUpDownAge.Value);



                    tblEmployeeTableAdapter.UpdateEmployeeQuery(name, surname, idNum, age, cbxEmployeeGender, cbxEmployeeRace, phone, address, suburb, cbxTypeEmployee, email, employeeID);
                    tblEmployeeTableAdapter.Fill(dsBookingSystem.tblEmployee);
                    MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a employee to update from the employee list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearFields();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (employeeID != -1)
            {
                if (!AreAllFieldsFilledForUpdateandDelete())
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    string message = null;
                    string idNum = txtIDNum.Text;
                    string phone = txtPhoneNum.Text;
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;



                    if (!ValidateID(idNum))
                    {
                        MessageBox.Show("Invalid ID number. Please enter a valid 13-digit ID number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!ValidatePhone(phone))
                    {
                        MessageBox.Show("Invalid phone number. Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (isEmployeeRelatedInABooking())
                        message += "Please delete all booking records containing the employee you want to delete, first!" + '\n';
                    if (isEmployeeRelatedInAnUnavailableSlot())
                        message += "Please delete all unavailable slots relating to this employee you want to delete, first!";
                    if (message == null)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            return;
                        }

                        string name = txtName.Text;
                        string surname = txtSurname.Text;
                        string address = txtStreetAddress.Text;
                        string suburb = txtSuburb.Text;
                        string cbxTypeEmployee = cbxType.Text.ToString();
                        string cbxEmployeeGender = cbxGender.Text.ToString();
                        string cbxEmployeeRace = cbxRace.Text.ToString();
                        int age = (int)(numericUpDownAge.Value);


                        tblEmployeeTableAdapter.DeleteEmployeeQuery(employeeID);
                        tblEmployeeTableAdapter.Fill(dsBookingSystem.tblEmployee);
                        MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a employee to delete from the employee list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearFields();
            }
        }

        private Boolean isEmployeeRelatedInABooking()
        {
            taBooking.Fill(dsBookingSystem.tblBooking);
            foreach (DataRow row in dsBookingSystem.tblBooking.Rows)
            {
                if (Convert.ToInt16(row["EmployeeID"]) == employeeID)
                {
                    return true;
                }
            }
            return false;
        }

        private Boolean isEmployeeRelatedInAnUnavailableSlot()
        {
            taUnavailableSlot1.Fill(dsBookingSystem.tblUnavailableSlot);
            foreach (DataRow row in dsBookingSystem.tblUnavailableSlot.Rows)
            {
                if (Convert.ToInt16(row["EmployeeID"]) == employeeID)
                {
                    return true;
                }
            }
            return false;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string surname = txtSearch.Text;
            tblEmployeeTableAdapter.SearchBySurname(dsBookingSystem.tblEmployee, surname);
        }

      
        private int CalculateAge(string idNumber)
        {
            if (idNumber.Length != 13)
                throw new ArgumentException("Invalid ID number length");

            string yearPrefix = idNumber.Substring(0, 2);
            int birthYear;
            int currentYear = DateTime.Now.Year % 100;
            int century = (int.Parse(yearPrefix) <= currentYear) ? 2000 : 1900;

            birthYear = century + int.Parse(yearPrefix);

            int age = DateTime.Now.Year - birthYear;
            if (DateTime.Now.Month < 1 || (DateTime.Now.Month == 1 && DateTime.Now.Day < 1))
                age--;

            return age;
        }

        private void txtIDNum_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtIDNum.Text.Length == 13)
                {
                    int age = CalculateAge(txtIDNum.Text);

                    if (age < 18)
                    {
                        MessageBox.Show("The employee must be at least 18 years old.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        numericUpDownAge.Value = 0;
                    }
                    else
                    {
                        numericUpDownAge.Value = age;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid 13-digit ID number.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while calculating the employee's age. Please ensure the ID number is valid and try again.", "Age Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ManageInstruc_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtIDNum.Enabled = false;
                txtPhoneNum.Enabled = false;
                txtStreetAddress.Enabled = false;
                txtSuburb.Enabled = false;
                cbxType.Enabled = false;
                cbxGender.Enabled = false;
                cbxRace.Enabled = false;
                numericUpDownAge.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                button2.Visible = false;
            }
            else
            {
                txtName.Enabled = true;
                txtSurname.Enabled = true;
                txtIDNum.Enabled = true;
                txtPhoneNum.Enabled = true;
                txtStreetAddress.Enabled = true;
                txtSuburb.Enabled = true;
                cbxType.Enabled = true;
                cbxGender.Enabled = true;
                cbxRace.Enabled = true;
                numericUpDownAge.Enabled = true;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                btnAdd.Visible = true;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                button2.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtName.Enabled = true;
                txtSurname.Enabled = true;
                txtIDNum.Enabled = true;
                txtPhoneNum.Enabled = true;
                txtStreetAddress.Enabled = true;
                txtSuburb.Enabled = true;
                cbxType.Enabled = true;
                cbxGender.Enabled = true;
                cbxRace.Enabled = true;
                numericUpDownAge.Enabled = true;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                btnAdd.Visible = true;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                button2.Visible = true;
            }
            else
            {
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtIDNum.Enabled = false;
                txtPhoneNum.Enabled = false;
                txtStreetAddress.Enabled = false;
                txtSuburb.Enabled = false;
                cbxType.Enabled = false;
                cbxGender.Enabled = false;
                cbxRace.Enabled = false;
                numericUpDownAge.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                button2.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(loginForm1);
            home.Employee_Name = loginForm1.Employee_Name;
            home.Employee_Surname = loginForm1.Employee_Surname;
            home.Employee_Type = loginForm1.Employee_Type;
            home.ShowDialog();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string helpText = "Manage Instructors Help:\n\n" +
                      "Add: Fills in the form fields and click 'Add' to add a new instructor.\n" +
                      "Update: Select an instructor from the list, make changes to the form fields, and click 'Update' to save changes.\n" +
                      "Delete: Select an instructor from the list and click 'Delete' to remove them.\n" +
                      "Clear: Click 'Clear' to reset all form fields.\n" +
                      "Search: Type in the search box to find instructors by surname. The results update as you type.\n\n" +
                      "Possible Errors:\n" +
                      "- 'Please fill in all fields.': Ensure all fields are filled out before submitting.\n" +
                      "- 'Invalid ID number. Please enter a valid 13-digit ID number.': Ensure the ID number is exactly 13 digits.\n" +
                      "- 'Invalid phone number. Please enter a valid 10-digit phone number.': Ensure the phone number is exactly 10 digits.\n" +
                      "- 'This ID number already exists. Please enter a unique ID number.': Use a unique ID number not already in use.\n" +
                      "- 'This username already exists. Please enter a unique username.': Use a unique username not already in use.\n" +
                      "- 'This password already exists. Please enter a unique password.': Use a unique password not already in use.\n" +
                      "- 'No changes detected. Please modify at least one field before updating.': Ensure you have made some changes before trying to update.\n";

            MessageBox.Show(helpText, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            
        }
    }
}
