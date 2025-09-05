using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrivingSchoolWebsite.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            sqldsUpdateProfile.Update();

            Label1.Text = "Your details have been successfully updated!";         
            ScriptManager.RegisterStartupScript(this, this.GetType(), "hideMessage", "setTimeout(function(){document.getElementById('" + Label1.ClientID + "').style.display='none';}, 10000);", true);
        }
    }
}