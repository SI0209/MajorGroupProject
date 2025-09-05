using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace DrivingSchoolWebsite.Admin
{
    public partial class ReportTwo : System.Web.UI.Page
    {
        private string connectionString = "Server=146.230.177.46;Database=WstGrp2;User ID=WstGrp2;Password=d9jdh"; // Your connection string

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateYearDropdown();
            }

            PopulateMonthlyBookingsChart(2024);  // Default year set to 2024
            PopulateInstructorPieChart();
            LoadDashboardData();

            LblBookings.Text = GetTotalBookings().ToString();
            LblRev.Text = GetPayments().ToString();
            lblPopularCode.Text = GetMostPopularCode().ToString(); 
        }

        private void PopulateYearDropdown()
        {
            ddlYear.Items.Clear();
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear - 5; year <= currentYear; year++)
            {
                ddlYear.Items.Add(new ListItem(year.ToString(), year.ToString()));
            }
            ddlYear.SelectedValue = currentYear.ToString();
        }

        protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ddlYear.SelectedValue, out int selectedYear))
            {
                PopulateMonthlyBookingsChart(selectedYear);
                PopulateInstructorPieChart();
            }
        }

        private void PopulateMonthlyBookingsChart(int selectedYear)
        {
            string query = @"
            SELECT MONTH(Booking_Date) AS BookingMonth, COUNT(*) AS TotalCompletedBookings
            FROM tblBooking
            WHERE Booking_Status = 'Complete'
            AND YEAR(Booking_Date) = @InputYear
            GROUP BY MONTH(Booking_Date)
            ORDER BY BookingMonth";

            int[] monthlyBookings = new int[12];

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InputYear", selectedYear);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int month = reader.GetInt32(0) - 1;
                            monthlyBookings[month] = reader.GetInt32(1);
                        }
                    }
                }
            }

            chartMonthlyBookings.Series["MonthlyBookings"].Points.Clear();
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 0; i < 12; i++)
            {
                chartMonthlyBookings.Series["MonthlyBookings"].Points.AddXY(months[i], monthlyBookings[i]);
            }

            ApplyChartStyling(chartMonthlyBookings, "MonthlyBookings", false);
        }


        private void PopulateInstructorPieChart()
        {
            string query = @"
    SELECT TOP 3 EmployeeID, COUNT(*) AS LessonCount
    FROM tblBooking
    WHERE Booking_Status = 'Complete'
    AND YEAR(Booking_Date) = YEAR(GETDATE())
    GROUP BY EmployeeID
    ORDER BY LessonCount DESC";

            List<string> employeeNames = new List<string>();
            List<int> bookings = new List<int>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int employeeId = reader.GetInt32(0);
                            int bookingCount = reader.GetInt32(1);

                            // Fetch employee name by ID
                            string employeeName = GetEmployeeNameById(employeeId);
                            if (!string.IsNullOrEmpty(employeeName))
                            {
                                employeeNames.Add(employeeName);
                                bookings.Add(bookingCount);
                            }
                        }
                    }
                }
            }

            pieChartInstructor.Series["InstructorBookings"].Points.Clear();
            for (int i = 0; i < employeeNames.Count; i++)
            {
                // Add each employee to the pie chart with name and lesson count
                pieChartInstructor.Series["InstructorBookings"].Points.AddXY(employeeNames[i], bookings[i]);

                // Ensure the label is the employee's name and their lesson count
                pieChartInstructor.Series["InstructorBookings"].Points[i].Label = $"{employeeNames[i]}: {bookings[i]} lessons";
            }

            ApplyChartStyling(pieChartInstructor, "InstructorBookings", true);
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

        private void ApplyChartStyling(Chart chart, string seriesName, bool isPieChart = false)
        {
            chart.Width = 800;
            chart.Height = 500;
            chart.Attributes.Add("style", "max-width:100%; height:auto;");

            chart.Series[seriesName].Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            chart.Series[seriesName].LabelForeColor = System.Drawing.Color.Black;

            if (isPieChart)
            {
                chart.Series[seriesName].ChartType = SeriesChartType.Pie;
                chart.Series[seriesName].IsValueShownAsLabel = true;
                chart.Series[seriesName].Label = "#VALY";
                chart.Series[seriesName].ShadowOffset = 6;
                chart.Series[seriesName].BorderWidth = 3;
                chart.Series[seriesName].BorderColor = System.Drawing.Color.White;

                if (chart.ChartAreas.Count == 0)
                {
                    chart.ChartAreas.Add(new ChartArea("ChartArea1"));
                }
                chart.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;

                if (chart.Legends.Count == 0)
                {
                    chart.Legends.Add("Legend1");
                }
                chart.Legends["Legend1"].Enabled = true;
                chart.Legends["Legend1"].Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Regular);
                chart.Legends["Legend1"].Docking = Docking.Bottom;
                chart.Legends["Legend1"].Alignment = StringAlignment.Center;
            }
            else
            {
                chart.Series[seriesName].ChartType = SeriesChartType.Column;
                chart.Series[seriesName].IsValueShownAsLabel = true;
                chart.Series[seriesName].Label = "#VALY";
                chart.Series[seriesName].Palette = ChartColorPalette.BrightPastel;

                if (chart.ChartAreas.Count == 0)
                {
                    chart.ChartAreas.Add(new ChartArea("ChartArea1"));
                }
                chart.ChartAreas["ChartArea1"].AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
                chart.ChartAreas["ChartArea1"].AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
                chart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 12);
                chart.ChartAreas["ChartArea1"].AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 12);
                chart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = 45;
            }
        }

        private int GetPayments()
        {
            return ExecuteScalarQuery("SELECT SUM(Payment_Amount) AS total_payments FROM tblPayment");
        }

        private int GetTotalBookings()
        {
            return ExecuteScalarQuery("SELECT COUNT(*) AS total_bookings FROM tblBooking");
        }

        private int ExecuteScalarQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                return result != DBNull.Value && result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private void LoadDashboardData()
        {
            try
            {
                Label1.Text = GetTotalBookings().ToString();
                lblPayments.Text = GetPayments().ToString();
                lblVehicles.Text = GetTotalVehicles().ToString();
                lblPayments.Text = GetTotalUnpaidBookings().ToString();
                lblMaleInstructors.Text = GetTotalMaleInstructors().ToString();
                lblFemaleInstructors.Text = GetTotalFemaleInstructors().ToString();
            }
            catch (Exception ex)
            {
                Response.Write("Error loading dashboard data: " + ex.Message);
            }
        }
        private string GetEmployeeNameById(int employeeId)
        {
            string employeeName = string.Empty;

            string query = "SELECT Employee_Name, Employee_Surname FROM tblEmployee WHERE EmployeeID = @EmployeeID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["Employee_Name"].ToString();
                                string lastName = reader["Employee_Surname"].ToString();
                                employeeName = firstName + " " + lastName;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                    Response.Write("Error fetching employee name: " + ex.Message);
                }
            }

            return employeeName;
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

    }
}
