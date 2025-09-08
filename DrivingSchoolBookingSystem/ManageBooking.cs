using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingSchoolBookingSystem
{
    public partial class ManageBooking : Form
    {
        LoginForm loginform;
        public int BookingID = -1;
        public int VehicleID;
        public int EmployeeID;
        public int LearnerID;
        public int LessonCodeID;
        public int dashIndex;
        ErrorControl errorControl = new ErrorControl();
        private decimal originalTotalCost;
        public string employeeName, employeeSurname, employeeType;
        public ManageBooking(LoginForm loginForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            taBooking.Fill(dsBookingSystem.tblBooking);
            taLessonCode.Fill(dsBookingSystem.tblLessonCode);
            taEmployee.Fill(dsBookingSystem.tblEmployee);
            taVehicle.Fill(dsBookingSystem.tblVehicle);
            taLearner.Fill(dsBookingSystem.tblLearner);
            taBookingInnerJoin.Fill(dsBookingSystem.tblBookingInnerJoin);
            loginform = loginForm;
            foreach (DataRow row in dsBookingSystem.tblLessonCode.Rows)
            {
                LessonCodeID = Convert.ToInt16(row["Code_Type"]);
                string displayText = $"{row["Code_Type"]}";
                cbxLessonCodes.Items.Add(displayText);
            }
            foreach (DataRow row in dsBookingSystem.tblEmployee.Rows)
            {
                if (row["Employee_Type"].ToString().Equals("Instructor"))
                {
                    string displayText = $"{row["EmployeeID"]} - {row["Employee_Name"]} {row["Employee_Surname"]} ";
                    cbxEmployeeID.Items.Add(displayText);
                }
            }

            foreach (DataRow row in dsBookingSystem.tblVehicle.Rows)
            {
                if (row["Vehicle_Status"].ToString().Equals("Available"))
                {
                    if (cbxLessonCodes.SelectedIndex == 0 && row["Vehicle_Size"].ToString().Equals("Small"))
                    {
                        string displayText = $"{row["VehicleID"]} - {row["Vehicle_Make"]} {row["Vehicle_Model"]} - {row["Vehicle_Size"]} ";
                        cbxVehicleID.Items.Add(displayText);
                    }
                    else if (cbxLessonCodes.SelectedIndex == 1 && row["Vehicle_Size"].ToString().Equals("Medium"))
                    {
                        string displayText = $"{row["VehicleID"]} - {row["Vehicle_Make"]} {row["Vehicle_Model"]} - {row["Vehicle_Size"]} ";
                        cbxVehicleID.Items.Add(displayText);
                    }

                }
            }
        }


        private void ManageBooking_Load(object sender, EventArgs e)
        {
            taBooking.Fill(dsBookingSystem.tblBooking);
            taLessonCode.Fill(dsBookingSystem.tblLessonCode);
            taEmployee.Fill(dsBookingSystem.tblEmployee);
            taVehicle.Fill(dsBookingSystem.tblVehicle);
            taLearner.Fill(dsBookingSystem.tblLearner);
            taBookingInnerJoin.Fill(dsBookingSystem.tblBookingInnerJoin);
            radioButton2.Checked = true;
            dtpBooking.MinDate = DateTime.Today;
            if (dtpBooking.Value == DateTime.Today)
            {
                if (DateTime.Now.Minute == 0)
                {
                    nudStartTime.Minimum = DateTime.Now.Hour;
                }
                else if (DateTime.Now.Minute > 0)
                {
                    nudStartTime.Minimum = DateTime.Now.Hour + 1;
                }
            }
            else 
            { 
               nudStartTime.Minimum = 11;
            }
            nudStartTime.Maximum = nudEndTime.Maximum - 1;
            nudEndTime.Minimum = nudStartTime.Value + 1;
            nudEndTime.Maximum = 17;
        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label16.ForeColor = Color.DarkRed; // or a hover color you prefer
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label16.ForeColor = Color.Blue;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!AllDataEntered())
            {
                MessageBox.Show("Please enter data in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string message = null;
                DateTime date = dtpBooking.Value.Date;
                int startTime = Convert.ToInt16(nudStartTime.Value);
                int endTime = Convert.ToInt16(nudEndTime.Value);
                string bookingStatus = cbxBookingStatus.Text.ToString();
                int lessonCodeID = Convert.ToInt16(cbxLessonCodes.Text);
                int learnerID;
                int vehicleID;
                int employeeID;
                try
                {
                    if (cbxLearnerID.Text.ToString().Contains("-"))
                       dashIndex = cbxLearnerID.Text.ToString().IndexOf("-");
                        learnerID = Convert.ToInt32(cbxLearnerID.Text.Substring(0, dashIndex).Trim());


                    if (cbxVehicleID.Text.ToString().Contains("-"))
                        dashIndex = cbxVehicleID.Text.ToString().IndexOf("-");
                        vehicleID = Convert.ToInt32(cbxVehicleID.Text.Substring(0, dashIndex).Trim());
                    
                     if (cbxEmployeeID.Text.ToString().Contains("-"))                   
                        dashIndex = cbxEmployeeID.Text.ToString().IndexOf("-");
                        employeeID = Convert.ToInt32(cbxEmployeeID.Text.Substring(0, dashIndex).Trim());
                    
                        
                }
                catch
                {
                    MessageBox.Show("Please select options from the options provided,Do not enter text when there are options to choose from!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                    return;
                }

                
                TimeSpan tStartTime = TimeSpan.FromHours(startTime);
                TimeSpan tEndTime = TimeSpan.FromHours(endTime);

                if (errorControl.ValidateTimes(startTime, endTime) != null)
                    message += errorControl.ValidateTimes(startTime, endTime) + "\n";
                if (errorControl.ValidateBookingDate(date) != null)
                    message += errorControl.ValidateBookingDate(date);
                if (message == null)
                {
                    if (isEmployeeUnavailable(date.ToShortDateString(), tStartTime.ToString(), tEndTime.ToString(), employeeID) != null)
                    {
                        message += isEmployeeUnavailable(date.ToShortDateString(), tStartTime.ToString(), tEndTime.ToString(), employeeID) + "\n";
                    }
                    if (message == null)
                    {
                        if (isEmployeeBooked(date.ToShortDateString(), tEndTime.ToString(), tStartTime.ToString(), employeeID) != null)
                            message += isEmployeeBooked(date.ToShortDateString(), tEndTime.ToString(), tStartTime.ToString(), employeeID) + "\n";
                        if (isVehicleBooked(date.ToShortDateString(), tEndTime.ToString(), tStartTime.ToString(), vehicleID) != null)
                            message += isVehicleBooked(date.ToShortDateString(), tEndTime.ToString(), tStartTime.ToString(), vehicleID) + "\n";
                        if (isLearnerBooked(date.ToShortDateString(), tEndTime.ToString(), tStartTime.ToString(), learnerID) != null)
                            message += isLearnerBooked(date.ToShortDateString(), tEndTime.ToString(), tStartTime.ToString(), learnerID) + "\n";
                    }
                    if (message == null)
                    {
                        if (isVehicleAvailable(vehicleID) != null)
                            message += isVehicleAvailable(vehicleID);
                    }
                }

                if (message == null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to add this Booking?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        taBooking.Insert(date, tStartTime, tEndTime, bookingStatus, learnerID.ToString(), lessonCodeID, vehicleID, employeeID);
                        taBooking.Fill(dsBookingSystem.tblBooking);
                        btnClear.PerformClick();
                        taBookingInnerJoin.Fill(dsBookingSystem.tblBookingInnerJoin);
                        MessageBox.Show("Booking has been confirmed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Booking not added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Clear()
        {
            cbxBookingStatus.Text = "";
            cbxEmployeeID.Text = "";
            cbxLearnerID.Text = "";
            cbxLessonCodes.Text = "";
            cbxVehicleID.Text = "";
            BookingID = -1;
            taBooking.Fill(dsBookingSystem.tblBooking);
            taBookingInnerJoin.Fill(dsBookingSystem.tblBookingInnerJoin);
            taLearner.Fill(dsBookingSystem.tblLearner);
            cbxVehicleID.Items.Clear();
            foreach (DataRow row in dsBookingSystem.tblVehicle.Rows)
            {
                if (row["Vehicle_Status"].ToString().Equals("Available"))
                {
                    string displayText = $"{row["VehicleID"]} - {row["Vehicle_Make"]} {row["Vehicle_Model"]} - {row["Vehicle_Size"]} ";
                    cbxVehicleID.Items.Add(displayText);
                }

            }

        }

        public Boolean AllDataEntered()
        {
            if (cbxBookingStatus.Text != "" && cbxEmployeeID.Text != "" && cbxLearnerID.Text != "" && cbxLessonCodes.Text != ""
               && cbxVehicleID.Text != "")
            {
                return true;
            }
            return false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            taBookingInnerJoin.FillBy(dsBookingSystem.tblBookingInnerJoin, dateTimePicker1.Value.Date.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvBooking_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((int)dgvBooking.CurrentRow.Cells[0].Value < 0)
                return;
            BookingID = (int)dgvBooking.CurrentRow.Cells[0].Value;
            dtpBooking.Text = dgvBooking.CurrentRow.Cells[1].Value.ToString();
            nudStartTime.Text = dgvBooking.CurrentRow.Cells[2].Value.ToString().Substring(0, 2);
            nudEndTime.Text = dgvBooking.CurrentRow.Cells[3].Value.ToString().Substring(0, 2);
            cbxBookingStatus.Text = dgvBooking.CurrentRow.Cells[4].Value.ToString();
            cbxLearnerID.Text = dgvBooking.CurrentRow.Cells[8].Value.ToString() + " ";
            cbxLessonCodes.Text = dgvBooking.CurrentRow.Cells[5].Value.ToString() + " ";
            cbxVehicleID.Text = dgvBooking.CurrentRow.Cells[6].Value.ToString() + " ";
            cbxEmployeeID.Text = dgvBooking.CurrentRow.Cells[7].Value.ToString() + " ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BookingID != -1)
            {
                if (!AllDataEntered())
                {
                    MessageBox.Show("Please enter data in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string message = null;
                    string date = dtpBooking.Value.Date.ToShortDateString();
                    string startTime = TimeSpan.FromHours(Convert.ToInt16(nudStartTime.Value)).ToString();
                    string endTime = TimeSpan.FromHours(Convert.ToInt16(nudEndTime.Value)).ToString();
                    string bookingStatus = cbxBookingStatus.SelectedItem.ToString();
                    int lessonCodeID = Convert.ToInt32(cbxLessonCodes.Text);
                    int learnerID;
                    int vehicleID;
                    int employeeID;
                    try
                    {
                        if (cbxLearnerID.Text.ToString().Contains("-"))
                            dashIndex = cbxLearnerID.Text.ToString().IndexOf("-");
                        learnerID = Convert.ToInt32(cbxLearnerID.Text.Substring(0, dashIndex));

                        if (cbxVehicleID.Text.ToString().Contains("-"))
                            dashIndex = cbxVehicleID.Text.ToString().IndexOf("-");
                        vehicleID = Convert.ToInt32(cbxVehicleID.Text.Substring(0, dashIndex));

                        if (cbxEmployeeID.Text.ToString().Contains("-"))
                            dashIndex = cbxEmployeeID.Text.ToString().IndexOf("-");
                        employeeID = Convert.ToInt32(cbxEmployeeID.Text.Substring(0, dashIndex));
                    }
                    catch
                    {
                        MessageBox.Show("Please select  an option from the options provided,Do not enter text when there are options to choose from!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clear();
                        return;
                    }

                    decimal pricePerHour = 0;
                    foreach (DataRow row in dsBookingSystem.tblLessonCode.Rows)
                    {
                        if (Convert.ToInt16(row["Code_Type"]) == lessonCodeID)
                        {
                            pricePerHour = (decimal)row["Code_PricePerHour"];
                            break;
                        }
                    }
                    if (errorControl.ValidateTimes(Convert.ToInt16(nudStartTime.Value), Convert.ToInt16(nudEndTime.Value)) != null)
                        message += errorControl.ValidateTimes(Convert.ToInt16(nudStartTime.Value), Convert.ToInt16(nudEndTime.Value)) + "\n";
                    if (message == null)
                    {
                        if (isEmployeeUnavailable(date, startTime, endTime, employeeID) != null)
                        {
                            message += isEmployeeUnavailable(date, startTime, endTime, employeeID) + "\n";
                        }
                        if (message == null)
                        {
                            if (isEmployeeBookedForUpdate(date, endTime, startTime, employeeID) != null)
                                message += isEmployeeBooked(date, endTime, startTime, employeeID) + "\n";
                            if (isVehicleBookedForUpdate(date, endTime, startTime, vehicleID) != null)
                                message += isVehicleBookedForUpdate(date, endTime, startTime, vehicleID) + "\n";
                            if (isLearnerBookedForUpdate(date, endTime, startTime, learnerID) != null)
                                message += isLearnerBookedForUpdate(date, endTime, startTime, learnerID) + "\n";
                        }

                    }
                    if (message == null)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you would like to update this Booking details?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            taBooking.UpdateBooking(date, startTime, endTime, bookingStatus, learnerID, lessonCodeID, vehicleID, employeeID, BookingID);
                            taBooking.Fill(dsBookingSystem.tblBooking);
                            taBookingInnerJoin.Fill(dsBookingSystem.tblBookingInnerJoin);
                            btnClear.PerformClick();
                            MessageBox.Show("Booking details successfully updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Booking details remain unchanged!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnClear.PerformClick();
                    }


                }
            }
            else
                MessageBox.Show("Please select a Booking you want to update from the Booking list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BookingID != -1)
            {
                if (!AllDataEntered())
                {
                    MessageBox.Show("Please enter data in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                        DialogResult result = MessageBox.Show("Are you sure you would like to DELETE this Booking details?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {

                            taBooking.DeleteBooking(BookingID);
                            taBooking.Fill(dsBookingSystem.tblBooking);
                            taBookingInnerJoin.Fill(dsBookingSystem.tblBookingInnerJoin);
                            btnClear.PerformClick();
                            MessageBox.Show("Booking details successfully deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Booking details not deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
                        }
                    }
                    
                }
            else
            {
                MessageBox.Show("Please select a Booking you want to delete from the booking list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string isEmployeeBookedForUpdate(string BookingDate, string endTime, string startTime, int employeeID)
        {
            string message = null;
            int count = 0;
            count = (int)taBooking.CheckEmployeeBookedAlreadyForUpdate(BookingDate, endTime, startTime, employeeID, BookingID);
            if (count > 0)
                message = "The Employee chosen is already booked during the chosen date and times!";
            return message;
        }
        private string isEmployeeBooked(string BookingDate, string endTime, string startTime, int employeeID)
        {
            string message = null;
            int count = 0;
            count = (int)taBooking.CheckEmployeeBookedAlready(BookingDate, endTime, startTime, employeeID);
            if (count > 0)
                message = "The Employee chosen is already booked during the chosen date and times!";
            return message;
        }

        private string isVehicleBookedForUpdate(string BookingDate, string endTime, string startTime, int VehicleID)
        {
            string message = null;
            int count = 0;
            count = (int)taBooking.CheckVehicleBookedAlreadyForUpdate(BookingDate, endTime, startTime, VehicleID, BookingID);
            if (count > 0)
                message = "The Vehicle chosen is already booked during the chosen date and times!";
            return message;
        }
        private string isVehicleBooked(string BookingDate, string endTime, string startTime, int VehicleID)
        {
            string message = null;
            int count = 0;
            count = (int)taBooking.CheckVehicleBookedAlready(BookingDate, endTime, startTime, VehicleID);
            if (count > 0)
                message = "The Vehicle chosen is already booked during the chosen date and times!";
            return message;
        }

        private string isLearnerBookedForUpdate(string BookingDate, string endTime, string startTime, int learnerID)
        {
            string message = null;
            int count = 0;
            count = (int)taBooking.CheckLearnerBookedAlreadyForUpdate(BookingDate, endTime, startTime, learnerID.ToString(), BookingID);
            if (count > 0)
                message = "The Learner chosen is already booked during the chosen date and times!";
            return message;
        }
        private string isLearnerBooked(string BookingDate, string endTime, string startTime, int learnerID)
        {
            string message = null;
            int count = 0;
            count = (int)taBooking.CheckLearnerBookedAlready(BookingDate, endTime, startTime, learnerID.ToString());
            if (count > 0)
                message = "The Learner chosen is already booked during the chosen date and times!";
            return message;
        }

        private string isEmployeeUnavailable(string bookingDate, string bookingEndTime, string bookingStartTime, int employeeID)
        {
            string message = null;
            int count = 0;
            count = (int)taUnavailableSlot1.CheckEmployeeUnavailable(employeeID, bookingDate, bookingEndTime, bookingStartTime);
            if (count > 0)
                message = "The Employee chosen is unavailable during the chosen date and times!";
            return message;
        }

       
        private string isVehicleAvailable(int vehicleID)
        {
            string message = null;
            foreach (DataRow row in dsBookingSystem.tblVehicle.Rows)
                if (Convert.ToInt16(row["VehicleID"]) == vehicleID)
                    if (row["Vehicle_Status"].ToString().Equals("Unavailable"))
                        message = "Vehicle chosen is unavailable at the moment!";
            return message;
        }

    

        

        private void cbxLessonCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(cbxLessonCodes.Text) <= 8)
            {
                cbxVehicleID.Items.Clear();
                foreach (DataRow row in dsBookingSystem.tblVehicle.Rows)
                {
                    if (row["Vehicle_Status"].ToString().Equals("Available") && row["Vehicle_Size"].ToString().Equals("Small"))
                    {
                        string displayText = $"{row["VehicleID"]} - {row["Vehicle_Make"]} {row["Vehicle_Model"]} - {row["Vehicle_Size"]} ";
                        cbxVehicleID.Items.Add(displayText);
                    }

                }
            }
            else if (Convert.ToInt16(cbxLessonCodes.Text) < 14)
            {
                cbxVehicleID.Items.Clear();
                foreach (DataRow row in dsBookingSystem.tblVehicle.Rows)
                {
                    if (row["Vehicle_Status"].ToString().Equals("Available") && row["Vehicle_Size"].ToString().Equals("Medium"))
                    {
                        string displayText = $"{row["VehicleID"]} - {row["Vehicle_Make"]} {row["Vehicle_Model"]} - {row["Vehicle_Size"]} ";
                        cbxVehicleID.Items.Add(displayText);
                    }
                }
            }
            else
            {
                cbxVehicleID.Items.Clear();
                foreach (DataRow row in dsBookingSystem.tblVehicle.Rows)
                {
                    if (row["Vehicle_Status"].ToString().Equals("Available") && row["Vehicle_Size"].ToString().Equals("Large"))
                    {
                        string displayText = $"{row["VehicleID"]} - {row["Vehicle_Make"]} {row["Vehicle_Model"]} - {row["Vehicle_Size"]} ";
                        cbxVehicleID.Items.Add(displayText);
                    }
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(loginform);
            home.Employee_Name = loginform.Employee_Name;
            home.Employee_Surname = loginform.Employee_Surname;
            home.Employee_Type = loginform.Employee_Type;
            home.ShowDialog();
            this.Hide();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {
            string helpText = "Manage Bookings Help:\n\n" +
                      "Add Booking: Fill in the booking details and click 'Add' to create a new booking.\n" +
                      "Update Booking: Select a booking from the list, make changes to the booking details, and click 'Update' to save changes.\n" +
                      "Delete Booking: Select a booking from the list and click 'Delete' to remove it.\n" +
                      "Clear Fields: Click 'Clear' to reset all booking details fields.\n" +
                      "Search Booking: Use the search box or date time picker to find bookings. The results update as you type or select a date.\n\n" +
                      "Possible Errors:\n" +
                      "- 'Please fill in all fields.': Ensure all booking details fields are filled out before submitting.\n" +
                      "- 'Invalid booking date. Please enter a valid date.': Ensure the booking date is in the correct format and is a valid date.\n" +
                      "- 'Booking conflict. This slot is already booked.': Ensure the booking slot is not already taken.\n" +
                      "- 'No changes detected. Please modify at least one field before updating.': Ensure you have made some changes before trying to update.\n" +
                      "- 'The Employee chosen is already booked during the chosen date and times!': Ensure the selected employee is available during the specified times.\n" +
                      "- 'The Vehicle chosen is already booked during the chosen date and times!': Ensure the selected vehicle is available during the specified times.\n" +
                      "- 'The Learner chosen is already booked during the chosen date and times!': Ensure the selected learner is available during the specified times.\n" +
                      "- 'The Employee chosen is unavailable during the chosen date and times!': Ensure the selected employee is not marked as unavailable during the specified times.\n" +
                      "- 'Vehicle chosen is unavailable at the moment!': Ensure the selected vehicle is marked as available.\n";

            MessageBox.Show(helpText, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();  
        }

        private void label3_Enter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.DarkRed;
        }

        private void label3_Leave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Blue;
        }

        private void nudStartTime_ValueChanged(object sender, EventArgs e)
        {
            nudEndTime.Minimum = nudStartTime.Value + 1;
        }

        private void dtpBooking_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBooking.Value == DateTime.Today)
            {
                if (DateTime.Now.Minute == 0)
                {
                    nudStartTime.Minimum = DateTime.Now.Hour;
                }
                else if (DateTime.Now.Minute > 0)
                {
                    nudStartTime.Minimum = DateTime.Now.Hour + 1;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
               nudStartTime.Enabled = true;
               nudEndTime.Enabled = true;
               dtpBooking.Enabled = true;
                cbxBookingStatus.Enabled = true;
                cbxLessonCodes.Enabled = true;
                cbxLearnerID.Enabled = true;
                cbxVehicleID.Enabled = true;
                cbxEmployeeID.Enabled = true;
                btnAdd.Visible = true;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnClear.Visible = true;
            }
            else
            {
                nudStartTime.Enabled = false;
                nudEndTime.Enabled = false;
                dtpBooking.Enabled = false;
                cbxBookingStatus.Enabled = false;
                cbxLessonCodes.Enabled = false;
                cbxLearnerID.Enabled = false;
                cbxVehicleID.Enabled = false;
                cbxEmployeeID.Enabled = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnClear.Visible= false;
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton2.Checked)
            {
                nudStartTime.Enabled = false;
                nudEndTime.Enabled = false;
                dtpBooking.Enabled = false;
                cbxBookingStatus.Enabled = false;
                cbxLessonCodes.Enabled = false;
                cbxLearnerID.Enabled = false;
                cbxVehicleID.Enabled = false;
                cbxEmployeeID.Enabled = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnClear.Visible = false;
            }
            }
    }
}
