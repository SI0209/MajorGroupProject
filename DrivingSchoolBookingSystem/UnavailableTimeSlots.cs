using DrivingSchoolBookingSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingSchoolBookingSystem
{
    public partial class UnavailableTimeSlots : Form
    {
        LoginForm loginform;
        ErrorControl errorControl = new ErrorControl();
        int unavailableSlotId = -1;
        public UnavailableTimeSlots()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            taUnavailableSlot.Fill(dsBookingSystem.tblUnavailableSlot);
            taUnavailableSlotInnerJoin.Fill(dsBookingSystem.tblUnavailableSlotInnerJoin);
            taEmployee.Fill(dsBookingSystem.tblEmployee);
            foreach (DataRow row in dsBookingSystem.tblEmployee.Rows)
            {
                if (row["Employee_Type"].ToString().Equals("Instructor"))
                {
                    string displayText = $"{row["EmployeeID"]} - {row["Employee_Name"]} {row["Employee_Surname"]} ";
                    cbxEmployeeID.Items.Add(displayText);
                }
            }
        }

        private void pbLessonCode_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*LessonCode lessonCode = new LessonCode();
            lessonCode.Show();*/
        }


        public Boolean AllDataEntered()
        {
            if (cbxEmployeeID.Text != "" && rtbReason.Text != "")

            {
                return true;
            }
            return false;
        }

        private void Clear()
        {
            cbxEmployeeID.SelectedIndex = -1;
            rtbReason.Text = "";
            taUnavailableSlot.Fill(dsBookingSystem.tblUnavailableSlot);
            taUnavailableSlotInnerJoin.Fill(dsBookingSystem.tblUnavailableSlotInnerJoin);
            txtSearch.Clear();
            unavailableSlotId = -1;
        }
        //Correct add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int employeeID = -1; // Initialize employeeID to -1 to handle cases where no employee is selected
            if (!AllDataEntered())
            {
                MessageBox.Show("Please enter data in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string message = null;
                DateTime startDate = dtpDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;
                int startTime = Convert.ToInt16(nudStartTime.Value);
                int endTime = Convert.ToInt16(nudEndTime.Value);
                TimeSpan tStartTime = TimeSpan.FromHours(startTime);
                TimeSpan tEndTime = TimeSpan.FromHours(endTime);
                string reason = rtbReason.Text;

                if (cbxEmployeeID.SelectedIndex != -1)
                {
                    if (cbxEmployeeID.Text.ToString().Contains("-"))
                    { 
                       int dashIndex = cbxEmployeeID.Text.IndexOf('-');
                       employeeID = Convert.ToInt32(cbxEmployeeID.Text.Substring(0, dashIndex)); // Extract only the EmployeeID part
                    }
                    if (errorControl.ValidateUnavailableSlotStartDate(startDate) != null)
                        message += errorControl.ValidateUnavailableSlotStartDate(startDate) + "\n";
                    if (errorControl.validateUnavailbleSlotDates(startDate, endDate) != null)
                        message += errorControl.validateUnavailbleSlotDates(startDate, endDate) + "\n";
                    if (errorControl.ValidateUnavailableSlotTimes(startTime, endTime) != null)
                        message += errorControl.ValidateUnavailableSlotTimes(startTime, endTime) + "\n";
                    if (errorControl.ValidateUnavailableSlotReason(reason) != null)
                        message += errorControl.ValidateUnavailableSlotReason(reason) + "\n";
                    if (message == null)
                    {
                        if (doesRecordExist(startDate.ToShortDateString(), endDate.ToShortDateString(), tStartTime.ToString(), tEndTime.ToString(), reason, employeeID))
                            message += "Unavailable slot for employee already exists!";
                    }
                    if (message == null)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you would like to add this Unvailable slot?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            taUnavailableSlot.Insert(startDate, endDate, tStartTime, tEndTime, reason, employeeID);
                            taUnavailableSlot.Fill(dsBookingSystem.tblUnavailableSlot);
                            taUnavailableSlotInnerJoin.Fill(dsBookingSystem.tblUnavailableSlotInnerJoin);
                            MessageBox.Show("Unavailable slot successfully added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Unavailable slot not added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please select an Employee from the options provided", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (unavailableSlotId != -1)
            {
                if (!AllDataEntered())
                {
                    MessageBox.Show("Please enter data in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string message = null;
                    string startDate = dtpDate.Value.Date.ToString();
                    string endDate = dtpEndDate.Value.Date.ToString();
                    int startTime = Convert.ToInt16(nudStartTime.Value);
                    int endTime = Convert.ToInt16(nudEndTime.Value);
                    string tStartTime = TimeSpan.FromHours(startTime).ToString();
                    string tEndTime = TimeSpan.FromHours(endTime).ToString();
                    string reason = rtbReason.Text;
                    int employeeID;
                    try
                    {
                        employeeID = Convert.ToInt32(cbxEmployeeID.Text.ToString().Substring(0, 2));
                    }
                    catch
                    {
                        MessageBox.Show("Please select an employee from the options provided! Do not enter any text", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clear();
                        return;
                    }

                    if (errorControl.validateUnavailbleSlotDates(dtpDate.Value.Date, dtpEndDate.Value.Date) != null)
                        message += errorControl.validateUnavailbleSlotDates(dtpDate.Value.Date, dtpEndDate.Value.Date) + "\n";
                    if (errorControl.ValidateUnavailableSlotTimes(startTime, endTime) != null)
                        message += errorControl.ValidateUnavailableSlotTimes(startTime, endTime) + "\n";
                    if (errorControl.ValidateUnavailableSlotReason(reason) != null)
                        message += errorControl.ValidateUnavailableSlotReason(reason) + "\n";
                    if (message == null)
                    {
                        if (doesRecordExistForUpdate(startDate, endDate, tStartTime.ToString(), tEndTime.ToString(), reason, employeeID))
                            message += "Unavailable slot for employee already exists!";
                    }
                    if (message == null)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you would like to update this Unvailable slot details?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            taUnavailableSlot.UpdateUnavailableSlot(startDate, endDate, tStartTime, tEndTime, reason, employeeID, unavailableSlotId);
                            taUnavailableSlot.Fill(dsBookingSystem.tblUnavailableSlot);
                            taUnavailableSlotInnerJoin.Fill(dsBookingSystem.tblUnavailableSlotInnerJoin);
                            MessageBox.Show("Unavailable slot details successfully updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Unavailable slot details not updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
                        }
                    }
                    else
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please select a Unavailable slot to update from the unavailable slots list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnClear.PerformClick();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (unavailableSlotId != -1)
            {
                if (!AllDataEntered())
                {
                    MessageBox.Show("Please enter data in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you would like to delete this Unvailable slot?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        taUnavailableSlot.DeleteUnavailableSlot(unavailableSlotId);
                        taUnavailableSlot.Fill(dsBookingSystem.tblUnavailableSlot);
                        taUnavailableSlotInnerJoin.Fill(dsBookingSystem.tblUnavailableSlotInnerJoin);
                        MessageBox.Show("Unavailable slot successfully deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Unavailable slot not deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClear.PerformClick();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Unavailable slot to delete from the unavailable slots list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUnavailableSlot_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Convert.ToInt16(dgvUnavailableSlot.CurrentRow.Cells[0].Value) < 0)
                return;
            unavailableSlotId = Convert.ToInt16(dgvUnavailableSlot.CurrentRow.Cells[0].Value);
            dtpDate.Text = dgvUnavailableSlot.CurrentRow.Cells[1].Value.ToString();
            dtpEndDate.Text = dgvUnavailableSlot.CurrentRow.Cells[2].Value.ToString();
            nudStartTime.Text = dgvUnavailableSlot.CurrentRow.Cells[3].Value.ToString().Substring(0, 2);
            nudEndTime.Text = dgvUnavailableSlot.CurrentRow.Cells[4].Value.ToString().Substring(0, 2);
            rtbReason.Text = dgvUnavailableSlot.CurrentRow.Cells[5].Value.ToString();
            cbxEmployeeID.Text = dgvUnavailableSlot.CurrentRow.Cells[6].Value.ToString() + " ";
        }

        private Boolean doesRecordExist(string startDate, string endDate, string startTime, string endTime, string reason, int employeeID)
        {
            int count = 0;
            count = (int)taUnavailableSlot.CheckDuplicateRecords(startDate, endDate, startTime, endTime, reason, employeeID);
            if (count != 0)
                return true;
            return false;

        }

        private Boolean doesRecordExistForUpdate(string startDate, string endDate, string startTime, string endTime, string reason, int employeeID)
        {
            int count = 0;
            count = (int)taUnavailableSlot.CheckDuplicateRecordsForUpdate(startDate, endDate, startTime, endTime, reason, employeeID, unavailableSlotId);
            if (count != 0)
                return true;
            return false;

        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = Color.DarkRed; // or a hover color you prefer
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Blue;
        }

        private void dgvUnavailableSlot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbHelpUnavSlots_Click(object sender, EventArgs e)
        {

        }

        private void cbxEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            taUnavailableSlotInnerJoin.FillBySurname(dsBookingSystem.tblUnavailableSlotInnerJoin, txtSearch.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            string helpText = "Unavailable Time Slots Form Help:\n\n" +
         "Add Unavailable Time Slot: Enter the start date, end date, start time, end time, reason, and select an employee. Then click 'Add' to record a new unavailable time slot.\n" +
         "Update Unavailable Time Slot: Select a time slot from the list, make changes to the details, and click 'Update' to save the changes.\n" +
         "Delete Unavailable Time Slot: Select a time slot from the list and click 'Delete' to remove it.\n" +
         "Clear Fields: Click 'Clear' to reset all fields.\n\n" +
         "Possible Errors:\n" +
         "- 'Please enter data in all fields!': Ensure all fields are filled out before submitting.\n" +
         "- 'Unavailable slot for employee already exists!': This error occurs when attempting to add a time slot that overlaps with an existing one for the same employee.\n" +
         "- 'Please select a Unavailable slot to update from the unavailable slots list!': This error occurs when trying to update without selecting a time slot.\n" +
         "- 'Please select a Unavailable slot to delete from the unavailable slots list!': This error occurs when trying to delete without selecting a time slot.\n" +
         "- 'Invalid dates, Unavailable end date cannot be before the start date!': Ensure that the end date of the unavailable slot is not before the start date.\n" +
         "- 'Unavailable slot end time has to be greater than the start time!': The end time of the unavailable slot must be greater than the start time.\n" +
         "- 'Unavailable slot end time cannot be the same as the start time!': The end time of the unavailable slot cannot be the same as the start time.\n" +
         "- 'Invalid Reason!,Please enter only letters!': Please ensure that the reason for the unavailable slot contains only letters.";
            MessageBox.Show(helpText, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        { 
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
           
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(loginform);
            home.Employee_Name = loginform.Employee_Name;
            home.Employee_Surname = loginform.Employee_Surname;
            home.Employee_Type = loginform.Employee_Type;
            home.ShowDialog();
            this.Hide();
        }
    }
}
