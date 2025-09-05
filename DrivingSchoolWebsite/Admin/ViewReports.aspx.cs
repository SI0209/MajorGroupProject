using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;

namespace DrivingSchoolWebsite.Admin
{
    public partial class ViewReports : Page
    {
        private string connectionString = "Server=146.230.177.46;Database=WstGrp2;User ID=WstGrp2;Password=d9jdh";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDashboardData();
            }
        }

        private void LoadDashboardData()
        {
            try
            {
                // Get counts for male and female learners
                int totalMales = GetMaleLearnerCount();
                int totalFemales = GetFemaleLearnerCount() ;

                // Debugging output to verify values
                Response.Write($"Male Learners: {totalMales}<br>");
                Response.Write($"Female Learners: {totalFemales}<br>");

                // Display counts in labels (for testing purposes)
                LblMaleLearners.Text = totalMales.ToString();
                LblFemaleLearners.Text = totalFemales.ToString();

                // Test Pie Chart Population
                PopulatePieChart(totalMales, totalFemales);

                // Test other values (Bookings, Vehicles, etc.)
                lblBookings.Text = GetTotalBookings().ToString();
                lblPopularCode.Text = GetMostPopularCode().ToString();
                lblVehicles.Text = GetTotalVehicles().ToString();
                lblPayments.Text = GetTotalUnpaidBookings().ToString();
                lblMaleInstructors.Text = GetTotalMaleInstructors().ToString();
                lblFemaleInstructors.Text = GetTotalFemaleInstructors().ToString();
            }
            catch (Exception ex)
            {
                // Handle errors
                Response.Write("Error loading dashboard data: " + ex.Message);
            }
        }

        private void PopulatePieChart(int maleCount, int femaleCount)
        {
            // Clear any previous points from the chart
            Chart1.Series["Learners"].Points.Clear();

            // Add data points for male and female learners to the pie chart
            Chart1.Series["Learners"].Points.AddXY("Male Learners", maleCount);
            Chart1.Series["Learners"].Points.AddXY("Female Learners", femaleCount);

            // Set the label for each point to display both the gender and count
            Chart1.Series["Learners"].Points[0].Label = $"Male Learners: {maleCount}";
            Chart1.Series["Learners"].Points[1].Label = $"Female Learners: {femaleCount}";

            // Apply the common chart styling
            ApplyChartStyling(Chart1);
        }
        private void ApplyChartStyling(Chart chart)
        {
            // Apply general chart styling here
            chart.Series["Learners"].Palette = ChartColorPalette.None; // Remove default pastel palette
            chart.Series["Learners"].Points[0].Color = System.Drawing.Color.FromArgb(255, 85, 153, 255); // Light Blue
            chart.Series["Learners"].Points[1].Color = System.Drawing.Color.FromArgb(255, 255, 85, 85); // Vibrant Red

            chart.Series["Learners"].ChartType = SeriesChartType.Pie;
            chart.Series["Learners"].BorderWidth = 2;
            chart.Series["Learners"].BorderColor = System.Drawing.Color.White;
            chart.Series["Learners"].ShadowOffset = 4;

            // Set the label for each point to display both the gender and count
            chart.Series["Learners"].IsValueShownAsLabel = true;
            chart.Series["Learners"].Label = "#PERCENT{P0}"; // Show percentage as the label

            // Apply 3D effect to the chart area
            if (chart.ChartAreas.Count == 0)
            {
                chart.ChartAreas.Add(new ChartArea("ChartArea1"));
            }
            chart.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;

            // Adjust the legend appearance
            if (chart.Legends.Count == 0)
            {
                chart.Legends.Add("Legend1");
            }
            chart.Legends["Legend1"].Docking = Docking.Bottom;
            chart.Legends["Legend1"].Alignment = System.Drawing.StringAlignment.Center;
            chart.Legends["Legend1"].Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);

            // Increase the size of the chart
            chart.Width = 700;  // Increase width to 800 pixels
            chart.Height = 500; // Increase height to 600 pixels
            chart.Attributes.Add("style", "max-width:100%; height:auto;");

            // Improve label font style for modern design
            chart.Series["Learners"].Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            chart.Series["Learners"].LabelForeColor = System.Drawing.Color.White;
        }






        private int GetMaleLearnerCount()
        {
            int maleCount = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) AS MaleLearnerCount FROM tblLearner WHERE Learner_Gender = 'Male'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            maleCount = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Error retrieving male learners count: " + ex.Message);
                }
            }
            return maleCount;
        }

        private int GetFemaleLearnerCount()
        {
            int femaleCount = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) AS FemaleLearnerCount FROM tblLearner WHERE Learner_Gender = 'Female'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            femaleCount = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Error retrieving female learners count: " + ex.Message);
                }
            }
            return femaleCount;
        }

        public int GetTotalBookings()
        {
            return ExecuteScalarQuery("SELECT COUNT(*) AS total_bookings FROM tblBooking");
        }

        public int GetTotalVehicles()
        {
            return ExecuteScalarQuery("SELECT COUNT(*) AS Expr1 FROM tblVehicle");
        }

        public int GetTotalUnpaidBookings()
        {
            return ExecuteScalarQuery("SELECT SUM(Booking_FeeDue) AS Expr1 FROM tblBooking");
        }

        public int GetTotalMaleInstructors()
        {
            return ExecuteScalarQuery("SELECT COUNT(*) AS Expr1 FROM tblEmployee WHERE Employee_Gender = 'Male'");
        }

        public int GetTotalFemaleInstructors()
        {
            return ExecuteScalarQuery("SELECT COUNT(*) AS Expr1 FROM tblEmployee WHERE Employee_Gender = 'Female'");
        }

        private int GetMostPopularCode()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "WITH CodeTypePopularity AS (SELECT Code_Type, COUNT(*) AS BookingCount FROM tblBooking GROUP BY Code_Type) SELECT TOP(1) lc.Code_Type FROM CodeTypePopularity AS ctp INNER JOIN tblLessonCode AS lc ON ctp.Code_Type = lc.Code_Type ORDER BY ctp.BookingCount DESC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Error retrieving most popular code: " + ex.Message);
                }
            }
            return 0; // Return a default value in case of error
        }

        private int ExecuteScalarQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0; // Return 0 if result is null
            }
        }
    }
}
