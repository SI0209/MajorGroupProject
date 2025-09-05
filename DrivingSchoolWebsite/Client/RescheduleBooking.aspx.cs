using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace DrivingSchoolWebsite.Client
{
    public partial class ResceduleBooking : System.Web.UI.Page
    {
        int bookingID = 0;
        decimal originalTotalCost= 0;
        decimal originalFeeDue =0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Server=146.230.177.46;Database=WstGrp2;User ID= WstGrp2;Password=d9jdh");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Id FROM AspNetUsers Where Email = @Email", con);
            cmd.Parameters.AddWithValue("@Email", User.Identity.Name.ToString());
            cmd.CommandType = CommandType.Text;
            string id = cmd.ExecuteScalar().ToString();
            SqlDataSource1.SelectParameters["LearnerID"].DefaultValue = id;
            string codeType = getCodeType();
            if (codeType.Equals("Code1"))
                txtCodeType.Text = "8";
            else if (codeType.Equals("Code2"))
                txtCodeType.Text = "10";
            else
                txtCodeType.Text = "14";
            if (!txtCodeType.Text.Equals(""))
            {
                if (txtCodeType.Text.Equals("8"))
                    SqlDataSource3.SelectParameters["Vehicle_Size"].DefaultValue = "Small";
                else if (txtCodeType.Text.Equals("10"))
                    SqlDataSource3.SelectParameters["Vehicle_Size"].DefaultValue = "Medium";
                else if (txtCodeType.Text.Equals("14"))
                    SqlDataSource3.SelectParameters["Vehicle_Size"].DefaultValue = "Large";
            }
        }

        public String getCodeType()
        {
            SqlConnection con = new SqlConnection("Server=146.230.177.46;Database=WstGrp2;User ID= WstGrp2;Password=d9jdh");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select LessonCode FROM AspNetUsers Where Email = @Email", con);
            cmd.Parameters.AddWithValue("@Email", User.Identity.Name.ToString());
            cmd.CommandType = CommandType.Text;
            string CodeType = cmd.ExecuteScalar().ToString();
            return CodeType;
        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            decimal pricePerHour = 0;
            int startTime = Convert.ToInt32(TimeSlotDropDown.Text.Substring(0, 2));
            int endTime = Convert.ToInt32(DropDownList1.Text.Substring(0, 2));
            TimeSpan tStartTime = TimeSpan.FromHours(startTime);
            TimeSpan tEndTime = TimeSpan.FromHours(endTime);
            SqlDSUpdate.UpdateParameters["Booking_StartTime"].DefaultValue = tStartTime.ToString();
            SqlDSUpdate.UpdateParameters["Booking_EndTime"].DefaultValue = tEndTime.ToString();
            SqlConnection con = new SqlConnection("Server=146.230.177.46;Database=WstGrp2;User ID= WstGrp2;Password=d9jdh");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Code_PricePerHour FROM tblLessonCode Where Code_Type = @Code_Type", con);
            cmd.Parameters.AddWithValue("@Code_type", txtCodeType.Text);
            cmd.CommandType = CommandType.Text;
            pricePerHour = Convert.ToDecimal(cmd.ExecuteScalar());
            decimal totalCost = pricePerHour * (endTime - startTime);
            decimal feeDue = originalFeeDue + (totalCost - originalTotalCost);
            SqlDSUpdate.UpdateParameters["Booking_TotalCost"].DefaultValue = totalCost.ToString(CultureInfo.InvariantCulture);
            SqlDSUpdate.UpdateParameters["Booking_FeeDue"].DefaultValue = feeDue.ToString(CultureInfo.InvariantCulture);
            GridViewRow row = gvBookingDetails.SelectedRow;
            bookingID = Convert.ToInt32(row.Cells[1].Text);
            SqlDSUpdate.UpdateParameters["BookingID"].DefaultValue = bookingID.ToString();

            if (ValidateBooking())
            {
                SqlDSUpdate.Update();
                Response.Redirect(Request.RawUrl);
            }

            
        }

        protected void gvBookingDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvBookingDetails.SelectedRow;
            bookingID = Convert.ToInt32(row.Cells[1].Text);
            originalTotalCost = Decimal.Parse(row.Cells[5].Text.Substring(1));
            originalFeeDue = Decimal.Parse(row.Cells[6].Text.Substring(1));
            lblBookingID.Text = "You are currently rescheduling/cancelling the booking with the BookingID = " + bookingID;
            SqlDataSource2.SelectParameters["BookingID"].DefaultValue = bookingID.ToString();
            SqlDataSource3.SelectParameters["BookingID"].DefaultValue = bookingID.ToString();
            
        }

        protected Boolean ValidateBooking()
        {
            // Clear previous error messages
            lblDateError.Text = "";
            lblStartTimeError.Text = "";
            lblEndTimeError.Text = "";

            // Parse and validate the date
            DateTime selectedDate;
            if (!DateTime.TryParse(bookingDate.Text, out selectedDate))
            {
                lblDateError.Text = "Invalid date format.";
                return false;
            }

            DateTime today = DateTime.Today;
            if (selectedDate < today)
            {
                lblDateError.Text = "The selected date cannot be before today's date.";
                return false;
            }

            // Parse and validate start time
            DateTime selectedStartTime;
            if (!DateTime.TryParse(TimeSlotDropDown.Text, out selectedStartTime))
            {
                lblStartTimeError.Text = "Invalid start time format.";
                return false;
            }

            if (selectedDate == today && selectedStartTime.TimeOfDay < DateTime.Now.TimeOfDay)
            {
                lblStartTimeError.Text = "The selected start time cannot be before the current time.";
                return false;
            }

            // Parse and validate end time
            DateTime selectedEndTime;
            if (!DateTime.TryParse(DropDownList1.Text, out selectedEndTime))
            {
                lblEndTimeError.Text = "Invalid end time format.";
                return false;
            }

            if (selectedEndTime <= selectedStartTime)
            {
                lblEndTimeError.Text = "The end time must be after the start time.";
                return false;
            }

            return true;
        }

        protected void bookingDate_TextChanged(object sender, EventArgs e)
        {
            lblDateError.Text = "";
        }

        protected void TimeSlotDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStartTimeError.Text = "";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEndTimeError.Text = "";
        }

        protected void SqlDataSource1_Updated(object sender, SqlDataSourceStatusEventArgs e)
        {
           /* if (e.AffectedRows > 0)
            {
                // Rebind the GridView to show the updated data
                gvBookingDetails.DataSource = SqlDataSource1;
                gvBookingDetails.DataBind();
            }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //GridViewRow row = gvBookingDetails.SelectedRow;
            //bookingID = Convert.ToInt32(gvBookingDetails.DataKeys[row.RowIndex].Value);
            //SqlDataSource4.DeleteParameters["BookingID"].DefaultValue = bookingID.ToString();
            SqlDataSource4.Delete();
            Response.Redirect(Request.RawUrl);

            
        }

        protected void SqlDataSource4_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}