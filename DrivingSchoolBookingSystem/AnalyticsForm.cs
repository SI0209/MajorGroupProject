using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrivingSchoolBookingSystem
{
    public partial class AnalyticsForm : Form
    {
        LoginForm loginForm;
        public AnalyticsForm(LoginForm Loginform)
        {
            InitializeComponent();
            loginForm = Loginform;
            this.StartPosition = FormStartPosition.CenterScreen;
            DrawChart();
            // pieChart.Titles.Add("Pie Chart");
            pieChart.Series["s1"].IsValueShownAsLabel = true;


            //top
            string topInstructor = taBooking.TopInstructorOfAllTime().ToString();
            string[] resultTop = new string[] { "0", "0" };
            resultTop = SplitString(topInstructor, ',');
            string TopEmployeeID = resultTop.Length > 0 ? resultTop[0] : "0";
            string TopEmployeeName = (string)taEmployee.GetEmployeeName(Convert.ToInt32(TopEmployeeID));
            string sTopLessonCount = resultTop.Length > 1 ? resultTop[1] : "0";

            string secondInstructor = taBooking.SecondBestInstructor().ToString();
            string[] resultSecond = new string[] { "0", "0" };
            resultSecond = SplitString(secondInstructor, ',');
            string secEmployeeID = resultTop.Length > 0 ? resultSecond[0] : "0";
            string secEmployeeName = (string)taEmployee.GetEmployeeName(Convert.ToInt32(secEmployeeID));
            string secLessonCount = resultTop.Length > 1 ? resultSecond[1] : "0";

            string thirdInstructor = taBooking.ThirdBestInstructor().ToString();
            string[] resultThird = new string[] { "0", "0" };
            resultThird = SplitString(thirdInstructor, ',');
            string ThirdEmployeeID = resultThird.Length > 0 ? resultThird[0] : "0";
            string ThirdEmployeeName = (string)taEmployee.GetEmployeeName(Convert.ToInt32(ThirdEmployeeID));
            string sThirdLessonCount = resultThird.Length > 1 ? resultThird[1] : "0";

            pieChart.Series["s1"].Points.AddXY(TopEmployeeName, sTopLessonCount);
            pieChart.Series["s1"].Points.AddXY(secEmployeeName, secLessonCount);
            pieChart.Series["s1"].Points.AddXY(ThirdEmployeeName, sThirdLessonCount);
            // MessageBox.Show(sTopLessonCount + "  " + secLessonCount + "  " + sThirdLessonCount);
        }

        static string[] SplitString(string input, char separator)
        {

            return input.Split(separator);
        }
        private void InitializeChart()
        {
            chartBookings.Series.Clear();
            chartBookings.Series.Add("Bookings");
        }
        private void DrawChart()
        {
            // Initialize chart
            InitializeChart();

            // Get booking values from adapter
            int dailyBookings = GetDailyBookings();
            int weeklyBookings = GetWeeklyBookings();
            int monthlyBookings = GetMonthlyBookings();

            // Update chart with booking values
            UpdateChart(dailyBookings, weeklyBookings, monthlyBookings);
        }

        private void GenerateDailyReport()
        {
            try
            {
                // Initialize 
                decimal paymentsToday = 0;
                int bookingsToday = 0;
                int bookingsCancelledToday = 0;
                string mostInsLessons = null;
                string[] result = new string[] { "0", "0" };


                

                if (taBooking != null)
                {
                    bookingsToday = Convert.ToInt32(taBooking.BookingsToday());
                    bookingsCancelledToday = Convert.ToInt32(taBooking.BookingsNotCompletedToday());
                    mostInsLessons = (string)taBooking.MostInstructorLessonsToday();
                }

                if (mostInsLessons != null)
                {
                    result = SplitString(mostInsLessons, ',');
                }

                string EmployeeID = result.Length > 0 ? result[0] : "0";
                string sLessonCount = result.Length > 1 ? result[1] : "0";

                DateTime currentDate = DateTime.Now;
                string report = $"Today's Report ({currentDate}):" + Environment.NewLine +
                                "-----------------" + Environment.NewLine +
                                $"Total Payments Received Today: R{paymentsToday}" + Environment.NewLine +
                                $"Bookings Made Today: {bookingsToday}" + Environment.NewLine +
                                $"Bookings Cancelled Today: {bookingsCancelledToday}" + "%" + Environment.NewLine;

                if (sLessonCount.Equals("0"))
                {
                    report += "Employee with Most Lessons Taught Today: NULL (Employee ID: NULL)" + Environment.NewLine +
                              "Total Lessons Taught by the Most Active Instructor Today: NULL" + Environment.NewLine;
                }
                else
                {
                    int Employee_number;
                    if (int.TryParse(EmployeeID, out Employee_number) && taEmployee != null)
                    {
                        string EmployeeName = (string)taEmployee.GetEmployeeName(Employee_number);
                        report += $"Employee with Most Lessons Taught Today: {EmployeeName} (Employee ID: {EmployeeID})" + Environment.NewLine +
                                  $"Total Lessons Taught by the Most Active Instructor Today: {sLessonCount}" + Environment.NewLine;
                    }
                    else
                    {
                        report += "Employee with Most Lessons Taught Today: NULL (Employee ID: NULL)" + Environment.NewLine +
                                  "Total Lessons Taught by the Most Active Instructor Today: NULL" + Environment.NewLine;
                    }
                }

                dailyStatisticsTxtBx.Text = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}");
            }


        }
        private void GenerateWeeklyReport()
        {
            try
            {
                decimal paymentsThisWeek = 0;
                int bookingsThisWeek = 0;
                int bookingsCancelledThisWeek = 0;
                string mostInsLessonsThisWeek = null;
                int weeklyAv = 0;
                string[] result = new string[] { "0", "0" };


              

                if (taBooking != null)
                {
                    bookingsThisWeek = Convert.ToInt32(taBooking.BookingsWeekly());
                    bookingsCancelledThisWeek = Convert.ToInt32(taBooking.BookingsNotCompletedWeekly());
                    mostInsLessonsThisWeek = (string)(taBooking.MostWeeklyInstructorLessons());
                    weeklyAv = Convert.ToInt32(taBooking.GetAverageWeeklyBookings());
                }

                if (mostInsLessonsThisWeek != null)
                {
                    result = SplitString(mostInsLessonsThisWeek, ',');
                }

                string EmployeeID = result.Length > 0 ? result[0] : "0";
                string sLessonCount = result.Length > 1 ? result[1] : "0";

                DateTime currentDateTime = DateTime.Now;
                DateTime startOfWeek = currentDateTime.AddDays(-(int)currentDateTime.DayOfWeek);

                string report = $"Weekly Report ({startOfWeek.ToShortDateString()} - {currentDateTime.ToShortDateString()}):" + Environment.NewLine +
                                "-----------------" + Environment.NewLine +
                                $"Total Payments Received This Week: R{paymentsThisWeek}" + Environment.NewLine +
                                $"Bookings Made This Week: {bookingsThisWeek}" + Environment.NewLine +
                                $"Average Number Of Bookings Made This Week: {weeklyAv}" + Environment.NewLine +
                                $"Percentage Of Bookings Cancelled This Week: {bookingsCancelledThisWeek}%" + Environment.NewLine;

                if (sLessonCount.Equals("0"))
                {
                    report += "Employee with Most Lessons Taught This Week: NULL (Employee ID: NULL)" + Environment.NewLine +
                              "Total Lessons Taught by the Most Active Instructor This Week: NULL" + Environment.NewLine;
                }
                else
                {
                    int Employee_number;
                    if (int.TryParse(EmployeeID, out Employee_number) && taEmployee != null)
                    {
                        string EmployeeName = (string)taEmployee.GetEmployeeName(Employee_number);
                        report += $"Employee with Most Lessons Taught This Week: {EmployeeName} (Employee ID: {EmployeeID})" + Environment.NewLine +
                                  $"Total Lessons Taught by the Most Active Instructor This Week: {sLessonCount}" + Environment.NewLine;
                    }
                    else
                    {
                        report += "Employee with Most Lessons Taught This Week: NULL (Employee ID: NULL)" + Environment.NewLine +
                                  "Total Lessons Taught by the Most Active Instructor This Week: NULL" + Environment.NewLine;
                    }
                }

                weeklyStatsTxtBox.Text = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}");
            }

        }
        private void GenerateMonthlyReport()
        {
            try
            {

                decimal paymentsThisMonth = 0;
                int bookingsThisMonth = 0;
                int bookingsCancelledThisMonth = 0;
                string mostInsLessonsThisMonth = null;
                int monthlyAv = 0;
                string[] result = new string[] { "0", "0" };


                

                if (taBooking != null)
                {
                    bookingsThisMonth = Convert.ToInt32(taBooking.BookingsMonthly());
                    bookingsCancelledThisMonth = Convert.ToInt32(taBooking.BookingsNotCompletedMonthly());
                    mostInsLessonsThisMonth = (string)taBooking.MostMonthlyInstructorLessons();
                    monthlyAv = Convert.ToInt32(taBooking.GetAverageMonthlyBookings());
                }

                if (mostInsLessonsThisMonth != null)
                {
                    result = SplitString(mostInsLessonsThisMonth, ',');
                }

                string EmployeeID = result.Length > 0 ? result[0] : "0";
                string sLessonCount = result.Length > 1 ? result[1] : "0";

                DateTime currentDateTime = DateTime.Now;
                DateTime startOfMonth = new DateTime(currentDateTime.Year, currentDateTime.Month, 1);
                DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

                string report = $"Monthly Report ({startOfMonth.ToShortDateString()} - {endOfMonth.ToShortDateString()}):" + Environment.NewLine +
                                "-----------------" + Environment.NewLine +
                                $"Total Payments Received This Month: R{paymentsThisMonth}" + Environment.NewLine +
                                $"Bookings Made This Month: {bookingsThisMonth}" + Environment.NewLine +
                                $"Average Number Of Bookings Made This Month: {monthlyAv}" + Environment.NewLine +
                                $"Percentage Of Bookings Cancelled This Month: {bookingsCancelledThisMonth}%" + Environment.NewLine;

                if (sLessonCount.Equals("0"))
                {
                    report += "Employee with Most Lessons Taught This Month: NULL (Employee ID: NULL)" + Environment.NewLine +
                              "Total Lessons Taught by the Most Active Instructor This Month: NULL" + Environment.NewLine;
                }
                else
                {
                    int Employee_number;
                    if (int.TryParse(EmployeeID, out Employee_number) && taEmployee != null)
                    {
                        string EmployeeName = (string)taEmployee.GetEmployeeName(Employee_number);
                        report += $"Employee with Most Lessons Taught This Month: {EmployeeName} (Employee ID: {EmployeeID})" + Environment.NewLine +
                                  $"Total Lessons Taught by the Most Active Instructor This Month: {sLessonCount}" + Environment.NewLine;
                    }
                    else
                    {
                        report += "Employee with Most Lessons Taught This Month: NULL (Employee ID: NULL)" + Environment.NewLine +
                                  "Total Lessons Taught by the Most Active Instructor This Month: NULL" + Environment.NewLine;
                    }
                }

                monthlyStatsTxtBx.Text = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}");
            }

        }



        private void AnalyticsForm_Load_1(object sender, EventArgs e)
        {
            GenerateDailyReport();
            GenerateWeeklyReport();
            GenerateMonthlyReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string report = monthlyStatsTxtBx.Text;

            //monthly
            DateTime currentDate = DateTime.Now;
            SaveMonthlyReport(report, currentDate);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public static void SaveDailyReport(string reportContent, DateTime reportDate)
        {
            string reportsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports");

            if (!Directory.Exists(reportsDirectory))
            {
                Directory.CreateDirectory(reportsDirectory);
            }
            string fileName = $"DailyReport_{reportDate:yyyy-MM-dd}.txt";
            string filePath = Path.Combine(reportsDirectory, fileName);
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(reportContent);
                }

                MessageBox.Show($"Report saved successfully to {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the report: {ex.Message}");
            }
        }
        public static void SaveWeeklyReport(string reportContent, DateTime reportDate)
        {
            string reportsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports");


            if (!Directory.Exists(reportsDirectory))
            {
                Directory.CreateDirectory(reportsDirectory);
            }


            string fileName = $"WeeklyReport_{reportDate:yyyy-MM-dd}.txt";


            string filePath = Path.Combine(reportsDirectory, fileName);

            try
            {

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(reportContent);
                }

                MessageBox.Show($"Weekly report saved successfully to {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the weekly report: {ex.Message}");
            }
        }
        public static void SaveMonthlyReport(string reportContent, DateTime reportDate)
        {

            string reportsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports");


            if (!Directory.Exists(reportsDirectory))
            {
                Directory.CreateDirectory(reportsDirectory);
            }
            string fileName = $"MonthlyReport_{reportDate:yyyy-MM}.txt";
            string filePath = Path.Combine(reportsDirectory, fileName);

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(reportContent);
                }

                MessageBox.Show($"Monthly report saved successfully to {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the monthly report: {ex.Message}");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string report = dailyStatisticsTxtBx.Text;

            //daily
            DateTime currentDate = DateTime.Now;
            SaveDailyReport(report, currentDate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string report = weeklyStatsTxtBox.Text;

            //weekly
            DateTime currentDate = DateTime.Now;
            SaveWeeklyReport(report, currentDate);
        }
        private int GetDailyBookings()
        {
            // Call your adapter method to get daily bookings
            int? dailyBookings = Convert.ToInt32(taBooking.BookingsToday());
            return dailyBookings ?? 0; // Return 0 if dailyBookings is null
        }

        private int GetWeeklyBookings()
        {
            // Call your adapter method to get weekly bookings
            int? weeklyBookings = Convert.ToInt32(taBooking.BookingsWeekly());
            return weeklyBookings ?? 0; // Return 0 if weeklyBookings is null
        }

        private int GetMonthlyBookings()
        {
            // Call your adapter method to get monthly bookings
            int? monthlyBookings = Convert.ToInt32(taBooking.BookingsMonthly());
            return monthlyBookings ?? 0; // Return 0 if monthlyBookings is null
        }
        private void UpdateChart(int dailyBookings, int weeklyBookings, int monthlyBookings)
        {
            chartBookings.Series["Bookings"].Points.AddXY("Daily", dailyBookings);
            chartBookings.Series["Bookings"].Points.AddXY("Weekly", weeklyBookings);
            chartBookings.Series["Bookings"].Points.AddXY("Monthly", monthlyBookings);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SaveDailyReport(dailyStatisticsTxtBx.Text, DateTime.Now);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveWeeklyReport(weeklyStatsTxtBox.Text, DateTime.Now);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SaveMonthlyReport(monthlyStatsTxtBx.Text, DateTime.Now);
        }

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            GenerateDailyReport();
            GenerateMonthlyReport();
            GenerateWeeklyReport();
            DrawChart();
            int booking = Convert.ToInt32(taBooking.TotalBookings());
            int bookingCompleted = Convert.ToInt32(taBooking.TotalBookingsCompleted());
            int totalInstructors = Convert.ToInt32(taEmployee.TotalEmployee());
            int totalVehicles = Convert.ToInt32(taVehicle.TotalVehicles());


            label13.Text = booking.ToString();
            label9.Text = bookingCompleted.ToString();
            textBox1.Text = booking.ToString();
            textBox2.Text = totalInstructors.ToString();
            textBox3.Text = totalVehicles.ToString();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(loginForm);
            homeForm.Employee_Name = loginForm.Employee_Name;
            homeForm.Employee_Surname = loginForm.Employee_Surname;
            homeForm.Employee_Type = loginForm.Employee_Type;
            homeForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
