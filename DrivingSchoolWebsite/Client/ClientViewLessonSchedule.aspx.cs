using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrivingSchoolWebsite.Client
{
    public partial class ClientViewLessonSchedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnViewSchedule_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=146.230.177.46;Database=WstGrp2;User ID= WstGrp2;Password=d9jdh");
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select Id FROM AspNetUsers Where Email = @Email", con);
            cmd2.Parameters.AddWithValue("@Email", User.Identity.Name.ToString());
            cmd2.CommandType = CommandType.Text;
            string Id = cmd2.ExecuteScalar().ToString();
            SqlDataSource1.SelectParameters["LearnerID"].DefaultValue = Id;
            SqlDataSource1.SelectParameters["Booking_Date"].DefaultValue = selectedDate.Text;
        }
    }
}