using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace DrivingSchoolWebsite.Public_Pages
{
    public partial class Review : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadReviews();
            }
        }

        private void LoadReviews()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            List<UserReview> reviews = new List<UserReview>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Username, ReviewText, Rating, CreatedAt FROM Reviews ORDER BY CreatedAt DESC";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        reviews.Add(new UserReview
                        {
                            Username = reader["Username"].ToString(),
                            ReviewText = reader["ReviewText"].ToString(),
                            Rating = Convert.ToInt32(reader["Rating"]),
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
            }

            DisplayReviews(reviews);
        }

        private void DisplayReviews(List<UserReview> reviews)
        {
            string reviewHtml = "";
            foreach (var review in reviews)
            {
                reviewHtml += $"<div style='padding: 20px; border-bottom: 1px solid #999; margin-bottom: 20px;'>";
                reviewHtml += $"<h4 style='margin-bottom: 10px;'>{review.Username}</h4>";
                reviewHtml += $"<p>\"{review.ReviewText}\"</p>";
                reviewHtml += $"<p style='text-align: right; font-style: italic;'>Rating: {new string('★', review.Rating)}{new string('☆', 5 - review.Rating)}</p>";
                reviewHtml += $"</div>";
            }
            //litReviews.Text = reviewHtml; // Set the generated HTML to the Literal control
        }
    }

    public class UserReview
    {
        public string Username { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
