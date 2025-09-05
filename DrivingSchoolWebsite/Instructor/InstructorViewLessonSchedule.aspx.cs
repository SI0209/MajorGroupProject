using Microsoft.AspNet.Identity;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrivingSchoolWebsite.Instructor
{
    public partial class InstructorViewLessonSchedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set the UserId (if needed) or do other necessary initializations
                if (Label1 != null)
                {
                    Label1.Text = User.Identity.GetUserId();
                }

                // Ensure SqlDataSource1 is available before binding
                if (SqlDataSource1 != null)
                {
                    GridView1.DataBind();
                }
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            // Ensure Calendar1 is not null
            if (Calendar1 == null || SqlDataSource1 == null)
            {
                return; // Exit the method early if either control is not initialized
            }

            DateTime selectedDate = Calendar1.SelectedDate;

            // Check if the date is valid (e.g., if it's not an empty date)
            if (selectedDate != DateTime.MinValue)
            {
                // Get the UserId for the logged-in user
                string userId = User.Identity.GetUserId();

                // Set the Label1 text to the UserId (assuming Label1 is used for the UserId)
                if (Label1 != null)
                {
                    Label1.Text = userId;
                }

                // Update the SqlDataSource parameter for SelectedDate
                SqlDataSource1.SelectParameters["SelectedDate"].DefaultValue = selectedDate.ToString("yyyy-MM-dd");

                // Rebind the GridView to display filtered results
                GridView1.DataBind();
            }
            else
            {
                // If no date is selected, load all records
                SqlDataSource1.SelectParameters["SelectedDate"].DefaultValue = string.Empty;  // Clear the date filter
                GridView1.DataBind();
            }
        }
    }
}
