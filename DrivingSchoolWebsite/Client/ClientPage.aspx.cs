using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrivingSchoolWebsite.Client
{
    public partial class ClientPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            SqlDSUpdateProfile.UpdateParameters["PhoneNumber"].DefaultValue = PhoneNumber.Text;
            SqlDSUpdateProfile.UpdateParameters["StreetAddress"].DefaultValue = StreetAddress.Text;
            SqlDSUpdateProfile.UpdateParameters["Suburb"].DefaultValue = Suburb.Text;
            SqlDSUpdateProfile.UpdateParameters["FirstName"].DefaultValue = FirstName.Text;
            SqlDSUpdateProfile.UpdateParameters["LastName"].DefaultValue = LastName.Text;
            SqlDSUpdateProfile.UpdateParameters["Email"].DefaultValue = User.Identity.Name.ToString();
            SqlDSUpdateProfile.Update();
        }
    }
}