using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrivingSchoolWebsite.Private_Pages
{
    public partial class AddReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // Get username from a textbox
            string reviewText = txtReview.Text; // Get review text from a textarea
            int rating = int.Parse(ddlRating.SelectedValue); // Get rating from dropdown
            if (string.IsNullOrEmpty(username))
            {
                username = "Anonymous";
            }
            AddReviewToDatabase(username, reviewText, rating);
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Account/Login.aspx"); // Redirect to login if not authenticated
            }
        }

        private void AddReviewToDatabase(string username, string reviewText, int rating)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Reviews (Username, ReviewText, Rating) VALUES (@Username, @ReviewText, @Rating)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@ReviewText", reviewText);
                command.Parameters.AddWithValue("@Rating", rating);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }
    }
}