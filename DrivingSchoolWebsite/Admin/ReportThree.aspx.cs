using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrivingSchoolWebsite.Admin
{
    public partial class ReportThree : System.Web.UI.Page
    {

        private string connectionString = "Server=146.230.177.46;Database=WstGrp2;User ID=WstGrp2;Password=d9jdh"; // Your connection string
        List<string> suburbNames = new List<string>();
        List<int> learnerCounts = new List<int>();
        private string suburb = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Call the method to populate the dashboard on first load
                PopulateDashboard();
                PopulateSuburbBookingsChart();
            }
        }

        // Method to populate the dashboard labels with SQL data
        private void PopulateDashboard()
        {
            // Fetch the total number of learners
            string totalLearnersQuery = "SELECT DISTINCT COUNT(*) AS Expr1 FROM tblLearner";
            string mostPopularSuburbQuery = "WITH SuburbPopularity AS (SELECT Learner_Suburb, COUNT(*) AS LearnerCount FROM  tblLearner  GROUP BY Learner_Suburb) SELECT TOP (1) Learner_Suburb, LearnerCount FROM SuburbPopularity AS SuburbPopularity_1 ORDER BY LearnerCount DESC";
            string learnersInMostPopularSuburbQuery = @"
        WITH SuburbPopularity AS (
            SELECT Learner_Suburb, COUNT(*) AS LearnerCount 
            FROM tblLearner
            GROUP BY Learner_Suburb
        )
        SELECT COUNT(*) 
        FROM tblLearner 
        WHERE Learner_Suburb = (
            SELECT TOP 1 Learner_Suburb 
            FROM SuburbPopularity 
            ORDER BY LearnerCount DESC
        );
    ";

            try
            {
                // Open a connection to the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Fetch Total Learners
                    using (SqlCommand cmd = new SqlCommand(totalLearnersQuery, conn))
                    {
                        int totalLearners = (int)cmd.ExecuteScalar();
                        LblTotalLearners.Text = $"Total Learners: {totalLearners}";
                    }

                    // Fetch Most Popular Suburb and Learner Count
                    using (SqlCommand cmd = new SqlCommand(mostPopularSuburbQuery, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                suburb = reader.GetString(0);
                                int learnerCount = reader.GetInt32(1);
                                LblMostPopularSuburb.Text = $"Most Popular Suburb: {suburb}";
                                LblLearnersInMostPopularSuburb.Text = $"Learners in {suburb}: {learnerCount}";
                            }
                        }
                    }

                    // Fetch Learners in Most Popular Suburb
                    using (SqlCommand cmd = new SqlCommand(learnersInMostPopularSuburbQuery, conn))
                    {
                        int learnersInSuburb = (int)cmd.ExecuteScalar();
                        LblLearnersInMostPopularSuburb.Text = $"Learners in Most Popular Suburb: {learnersInSuburb} in {suburb}";
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (log it, show error message, etc.)
                Response.Write("Error fetching data: " + ex.Message);
            }
        }


        private void PopulateSuburbBookingsChart()
        {
            // Clear previous data points before adding new ones
            suburbNames.Clear();
            learnerCounts.Clear();

            // Query to get the top 5 most popular suburbs and their learner count
            string suburbBookingsQuery = @"
        WITH SuburbPopularity AS (
            SELECT Learner_Suburb, COUNT(*) AS LearnerCount
            FROM tblLearner
            GROUP BY Learner_Suburb
        )
        SELECT TOP 5 Learner_Suburb, LearnerCount
        FROM SuburbPopularity
        ORDER BY LearnerCount DESC
    ";

            try
            {
                // Open a connection to the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Fetch data for suburbs and learner counts
                    using (SqlCommand cmd = new SqlCommand(suburbBookingsQuery, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                suburbNames.Add(reader.GetString(0)); // Suburb Name
                                learnerCounts.Add(reader.GetInt32(1)); // Learner Count
                            }
                        }
                    }
                }

                // Clear existing data points
                Chart2.Series["SuburbBookings"].Points.Clear();

                // Add data points to the chart
                for (int i = 0; i < suburbNames.Count; i++)
                {
                    Chart2.Series["SuburbBookings"].Points.AddXY(suburbNames[i], learnerCounts[i]);
                }

                // Configure the series
                Chart2.Series["SuburbBookings"].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Bar;
                Chart2.Series["SuburbBookings"].IsValueShownAsLabel = true;  // Show values on bars
                Chart2.Series["SuburbBookings"].Label = "#VALY";  // Show learner count as label on the bars
                Chart2.Series["SuburbBookings"].Palette = System.Web.UI.DataVisualization.Charting.ChartColorPalette.Pastel;
                Chart2.Series["SuburbBookings"].BorderWidth = 2;
                Chart2.Series["SuburbBookings"].BorderColor = System.Drawing.Color.White;
                Chart2.Series["SuburbBookings"].ShadowOffset = 4;

                // Set chart area properties (ensure it exists)
                if (Chart2.ChartAreas.Count == 0)
                {
                    Chart2.ChartAreas.Add(new System.Web.UI.DataVisualization.Charting.ChartArea("ChartArea1"));
                }

                // Configure Y-axis for whole numbers
                Chart2.ChartAreas["ChartArea1"].AxisY.Interval = 1; // Use whole number intervals
                Chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "0"; // Ensure formatting as whole numbers
                Chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray; // Optional: gridline styling
                Chart2.ChartAreas["ChartArea1"].AxisY.MinorGrid.Enabled = false; // Optional: disable minor gridlines
                Chart2.ChartAreas["ChartArea1"].AxisY.Title = "Learner Count"; // Optional: Add a title to the Y-axis

                // (Optional) Customize X-axis labels
                Chart2.ChartAreas["ChartArea1"].AxisX.Title = "Suburbs";
                Chart2.ChartAreas["ChartArea1"].AxisX.Interval = 1; // Show all labels on X-axis
            }
            catch (Exception ex)
            {
                // Handle any errors
                Response.Write("Error fetching data for chart: " + ex.Message);
            }
        }








    }
}