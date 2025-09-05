using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DrivingSchoolWebsite.Client
{
    public partial class ClientBookingOnline : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string codeType = getCodeType();
            if (codeType.Equals("Code1"))
                txtCodeType.Text = "8";
            else 
                txtCodeType.Text = "10";

            if (!txtCodeType.Text.Equals(""))
            {
                if (txtCodeType.Text.Equals("8"))
                    SqlDataSource3.SelectParameters["Vehicle_Size"].DefaultValue = "Small";
                else if (txtCodeType.Text.Equals("10"))
                    SqlDataSource3.SelectParameters["Vehicle_Size"].DefaultValue = "Medium";
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
           
                decimal pricePerHour = 0;
                int startTime = Convert.ToInt32(TimeSlotDropDown.Text.Substring(0, 2));
                int endTime = Convert.ToInt32(DropDownList1.Text.Substring(0, 2));
                TimeSpan tStartTime = TimeSpan.FromHours(startTime);
                TimeSpan tEndTime = TimeSpan.FromHours(endTime);
                // sqlDSInsert.InsertParameters["Booking_Date"].DefaultValue = "2024/11/03";//bookingDate.Text.ToString();
                sqlDSInsert.InsertParameters["Booking_StartTime"].DefaultValue = tStartTime.ToString();
                sqlDSInsert.InsertParameters["Booking_EndTime"].DefaultValue = tEndTime.ToString();
                SqlConnection con = new SqlConnection("Server=146.230.177.46;Database=WstGrp2;User ID= WstGrp2;Password=d9jdh");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Code_PricePerHour FROM tblLessonCode Where Code_Type = @Code_Type", con);
                cmd.Parameters.AddWithValue("@Code_type", txtCodeType.Text);
                cmd.CommandType = CommandType.Text;
                pricePerHour = Convert.ToDecimal(cmd.ExecuteScalar());
                decimal totalCost = pricePerHour * (endTime - startTime);
                decimal feeDue = totalCost;
                sqlDSInsert.InsertParameters["Booking_TotalCost"].DefaultValue = totalCost.ToString();
                sqlDSInsert.InsertParameters["Booking_FeeDue"].DefaultValue = feeDue.ToString();
                SqlCommand cmd2 = new SqlCommand("Select Id FROM AspNetUsers Where Email = @Email", con);
                cmd2.Parameters.AddWithValue("@Email", User.Identity.Name.ToString());
                cmd2.CommandType = CommandType.Text;
                string Id = cmd2.ExecuteScalar().ToString();
                sqlDSInsert.InsertParameters["LearnerID"].DefaultValue = Id;
            if (!isLearnerBooked(tStartTime, tEndTime))
            {
                if (ValidateBooking())
                {
                    sqlDSInsert.Insert();
                    //lblDateError.Text = bookingDate.Text;
                   Response.Redirect(Request.RawUrl);
                }
            }
            else
                lblDateError.Text = "You already have a booking during this times on this date!!";
            
            
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

        public Boolean isLearnerBooked(TimeSpan tStartTime, TimeSpan tEndtime)
        {
            SqlConnection con = new SqlConnection("Server=146.230.177.46;Database=WstGrp2;User ID= WstGrp2;Password=d9jdh");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Id FROM AspNetUsers Where Email = @Email", con);
            cmd.Parameters.AddWithValue("@Email", User.Identity.Name.ToString());
            cmd.CommandType = CommandType.Text;
            string Id = cmd.ExecuteScalar().ToString();
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) AS Expr1 FROM tblBooking WHERE  (Booking_Date = @BookingDate) AND (Booking_StartTime <= @endTime) AND (Booking_EndTime >= @StartTime) AND (LearnerID = @LearnerID)", con);
            cmd2.Parameters.AddWithValue("@LearnerID", Id);
            cmd2.Parameters.AddWithValue("@endTime", tEndtime.ToString());
            cmd2.Parameters.AddWithValue("@StartTime", tStartTime.ToString());
            DateTime Date = DateTime.Parse(bookingDate.Text);
            string formattedDate = Date.ToString("yyyy/MM/dd");
            cmd2.Parameters.AddWithValue("@BookingDate", formattedDate);
            cmd2.CommandType = CommandType.Text;
            int count = (int)cmd2.ExecuteScalar();
            if (count > 0)
                return true;
            else 
                return false;
           
        }

        protected void txtCodeType_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void instructorDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
    }
}