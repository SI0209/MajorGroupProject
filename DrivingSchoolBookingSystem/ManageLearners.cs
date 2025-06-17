using DrivingSchoolBookingSystem.WstGrp2DS2TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrivingSchoolBookingSystem
{
    public partial class ManageLearners : Form
    {
        private bool autoDateHandlingEnabled = true;
        private bool suppressDateEvents = false;
        LoginForm Loginform;
        public ManageLearners(LoginForm loginform)
        {
            InitializeComponent();
            SetIssueDatePickerRange();
            Loginform = loginform;

            // Make label16 look like a hyperlinkAdd commentMore actions
            label16.Text = "Click here for instructions";
            label16.ForeColor = Color.Blue;
            label16.Font = new Font(label16.Font, FontStyle.Underline);
            label16.Cursor = Cursors.Hand;

            // Configure tooltip timing and behavior
            toolTip3.AutoPopDelay = 5000;     // Time the tooltip stays visible
            toolTip3.InitialDelay = 500;      // Delay before it appears
            toolTip3.ReshowDelay = 100;       // Delay before showing again
            toolTip3.ShowAlways = true;       // Show even when form isn't active

            toolTip3.SetToolTip(textBox1, "Enter the learner's first name.");
            toolTip3.SetToolTip(textBox2, "Enter the learner's surname.");
            toolTip3.SetToolTip(textBox3, "Enter the learner's ID number.");
            toolTip3.SetToolTip(textBox4, "Enter the learner's age.");
            toolTip3.SetToolTip(comboBox1, "Select the learner's gender.");
            toolTip3.SetToolTip(comboBox2, "Select the learner's race group.");
            toolTip3.SetToolTip(textBox5, "Enter the learner's cellphone number.");
            toolTip3.SetToolTip(textBox6, "Enter the learner's street address.");
            toolTip3        .SetToolTip(comboBox3, "Select the suburb where the learner lives.");
            toolTip3.SetToolTip(IssuedateTimePicker1, "Select the date the learner license was issued.");
            toolTip3.SetToolTip(textBox9, "Displays the license expiry date.");
            toolTip3.SetToolTip(comboBox4, "Select the code type for the learner's license.");



            toolTip3.SetToolTip(button1, "Click to add a new learner.");
            toolTip3.SetToolTip(button5, "Click to update selected learner details.");
            toolTip3.SetToolTip(button2, "Click to delete selected learner.");
            toolTip3.SetToolTip(button4, "Clear the search field and reload the table.");
            toolTip3.SetToolTip(button3, "Clear all fields.");
            toolTip3.SetToolTip(pictureBox5, "Click here to log out safely.");
            toolTip3    .SetToolTip(pictureBox2, "Redirect back to home page");


            toolTip3.SetToolTip(radioButton1, "Enable edit mode to allow changes.");
            toolTip3.SetToolTip(radioButton2, "Disable edit mode to prevent changes.");
            toolTip3.SetToolTip(textBox7, "Search by learner ID, name or surname.");

            toolTip3.SetToolTip(label16, "Click to view help and usage guidance.");
        }
            
        private void LearnerForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp2DataSet1.tblLearner' table. You can move, or remove it, as needed.
            this.tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner);
            // TODO: This line of code loads data into the 'wstGrp2DataSet.tblBooking' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'wstGrp2DataSet.tblLearner' table. You can move, or remove it, as needed.
            this.tblLearnerTableAdapter.Fill(this.wstGrp2DataSet.tblLearner);
            label15.Visible = false;
            textBox8.Visible = false;
            comboBox1.KeyPress += combox1_KeyPress;
            comboBox2.KeyPress += combox2_KeyPress;
            comboBox3.KeyPress += combox3_KeyPress;
            comboBox4.KeyPress += combox4_KeyPress;
            radioButton2.Checked = true;
            //gender combox

            IssuedateTimePicker1.MinDate = DateTime.Today.AddYears(-2);
            IssuedateTimePicker1.MaxDate = DateTime.Today;
            IssuedateTimePicker1.Value = DateTime.Today;
            textBox9.Clear();
           // UpdateExpiryDate(); // Optional: set expiry on form load


        }
        private void UpdateExpiryDate()
        {
            IssuedateTimePicker1.MinDate = DateTime.Today.AddYears(-2);
            IssuedateTimePicker1.MaxDate = DateTime.Today;
            IssuedateTimePicker1.Value = DateTime.Today;
            textBox9.Text = IssuedateTimePicker1.Value.AddYears(2).ToShortDateString();
        }
        private void SetIssueDatePickerRange()
        {
            DateTime minDate = DateTime.Today.AddYears(-2);
            DateTime maxDate = DateTime.Today;

            IssuedateTimePicker1.MinDate = minDate;
            IssuedateTimePicker1.MaxDate = maxDate;

            // Ensure value is within new range
            if (IssuedateTimePicker1.Value < minDate || IssuedateTimePicker1.Value > maxDate)
            {
                IssuedateTimePicker1.Value = maxDate;
            }
        }
        private void combox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // This blocks all typing
        }
        private void combox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // This blocks all typing
        }
        private void combox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // This blocks all typing
        }
        private void combox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // This blocks all typing
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) ||
     string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            // Name fields should not contain digits
            if (textBox1.Text.Any(char.IsDigit) || textBox2.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name fields cannot contain numbers.");
                return;
            }

            // ID number must be exactly 13 digits and all numeric
            if (textBox3.Text.Length != 13)
            {
                MessageBox.Show("ID number must be exactly 13 digits.");
                return;
            }
            else if (!textBox3.Text.All(char.IsDigit))
            {
                MessageBox.Show("ID number must contain only digits.");
                return;
            }

            // Age must be numeric and between 16 and 99
            if (!int.TryParse(textBox4.Text, out int age))
            {
                MessageBox.Show("Age must be a number.");
                return;
            }
            else if (age < 16 || age > 99)
            {
                MessageBox.Show("Age must be between 16 and 99.");
                return;
            }

            // Cell phone number must be 10 digits and all numeric
            if (textBox5.Text.Length != 10)
            {
                MessageBox.Show("Cell phone number must be exactly 10 digits.");
                return;
            }
            else if (!textBox5.Text.All(char.IsDigit))
            {
                MessageBox.Show("Cell phone number cannot contain letters.");
                return;
            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to add the new learner:" + " " + textBox1.Text.ToString() + " " + textBox2.Text.ToString() + " ?",
                                                       "Confirm New Learner",
                                                       MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // insert null-check block here

                    tblLearnerTableAdapter.InsertNewLearner(
                        textBox1.Text,
                        textBox2.Text,
                        textBox3.Text,
                        Convert.ToInt16(textBox4.Text),
                        comboBox1.Text.ToString(),
                        comboBox2.Text.ToString(),
                        textBox5.Text,
                        textBox6.Text,
                        comboBox3.Text.ToString(),
                        IssuedateTimePicker1.Value.ToString("yyyy-MM-dd"),
                       Convert.ToString(textBox9.Text),
                        Convert.ToInt16(comboBox4.Text)
                    );

                    tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner);
                    MessageBox.Show("Learner has been added successfully!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear(); 
                    
                    comboBox1.SelectedIndex = -1; // Reset to no selection          
                    comboBox2.SelectedIndex = -1; // Reset to no selection
                    comboBox3.SelectedIndex = -1; // Reset to no selection
                    comboBox4.SelectedIndex = -1; // Reset to no selection
                
                    IssuedateTimePicker1.Value = DateTime.Today; // Reset issue date to today
                    textBox9.Clear(); // Clear expiry date textbox




                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else if (confirm == DialogResult.No)
            { }

                



        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {


            string input = textBox7.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    // Load all learners if the search box is empty
                    tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner);
                    return;
                }

                // Use wildcard for partial search
                string keyword = $"%{input}%";
                tblLearnerTableAdapter.FillByPartialMatch(this.wstGrp2DataSet1.tblLearner, keyword);

                // If no results found
                if (wstGrp2DataSet1.tblLearner.Rows.Count == 0)
                {
                    MessageBox.Show("No learners matched your search. The full list will now be shown.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner); // Reload all
                    textBox7.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while searching. Please try again.\n\nDetails: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner); // Fallback to full list
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner);
            textBox7.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox8.Clear();

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            IssuedateTimePicker1.Value = DateTime.Today;
            textBox9.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {// Restrict issue date range (in case user tries to set it via code)
            /*  if (suppressDateEvents) return;

              try
              {
                  IssuedateTimePicker1.MinDate = DateTime.Today.AddYears(-2);
                  IssuedateTimePicker1.MaxDate = DateTime.Today;

                  DateTime issueDate = IssuedateTimePicker1.Value;
                  DateTime expiryDate = issueDate.AddYears(2);

                  ExpdateTimePicker2.MinDate = expiryDate;
                  ExpdateTimePicker2.MaxDate = expiryDate;
                  ExpdateTimePicker2.Value = expiryDate;
              }
              catch (Exception)
              {
                  MessageBox.Show("Clear Dates before choosing a new one");
              }
            if (!autoDateHandlingEnabled) return; // Skip if disabled by row selection

            try
            {
                DateTime issueDate = IssuedateTimePicker1.Value;
                DateTime expiryDate = issueDate.AddYears(2);

                // Set expiry picker to exactly 2 years after issue
                ExpdateTimePicker2.MinDate = expiryDate;
                ExpdateTimePicker2.MaxDate = expiryDate;
                ExpdateTimePicker2.Value = expiryDate;
            }
            catch (Exception)
            {
                MessageBox.Show("Clear dates before selecting a new one.");
            }*/
            /*  DateTime issueDate = IssuedateTimePicker1.Value;
                 DateTime expiryDate = issueDate.AddYears(2);

                 ExpdateTimePicker2.MinDate = expiryDate;
                 ExpdateTimePicker2.MaxDate = expiryDate;
                 ExpdateTimePicker2.Value = expiryDate;*/
            

            if (!autoDateHandlingEnabled || suppressDateEvents)
                return;

            try
            {
                suppressDateEvents = true; // prevent reentry or other events


                IssuedateTimePicker1.MinDate = DateTime.Today.AddYears(-2);
                IssuedateTimePicker1.MaxDate = DateTime.Today;

                DateTime issueDate = IssuedateTimePicker1.Value;
                DateTime expiryDate = issueDate.AddYears(2);
                /*/ExpdateTimePicker2.MinDate = expiryDate;
                 ExpdateTimePicker2.MaxDate = expiryDate;*/
                textBox9.Text = expiryDate.ToShortDateString();
            }



            catch
            {
                MessageBox.Show("Clear dates before selecting a new one.");
            }
            finally
            {
                suppressDateEvents = false;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable event handling to prevent triggering other logic during reset  
                autoDateHandlingEnabled = false;
                suppressDateEvents = true;

                // Clear all textboxes and combo boxes  
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();

                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;

                // Set Issue Date picker range and value  
                SetIssueDatePickerRange();
                IssuedateTimePicker1.Value = DateTime.Today;
                textBox9.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while clearing the form: " + ex.Message);
            }
            finally
            {
                // Re-enable event handling after reset is done  
                suppressDateEvents = false;
                autoDateHandlingEnabled = true;

                // Reset UI elements visibility/enabled states as needed  
                label15.Visible = false;
                textBox8.Visible = false;
                textBox8.Enabled = true;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // Populate all textboxes and combo boxes from the selected row  
                textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                comboBox3.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                comboBox4.Text = dataGridView1.CurrentRow.Cells[12].Value?.ToString();

                label15.Visible = true;
                textBox8.Visible = true;
                textBox8.Enabled = false;


                /*  // Disable automatic date handling during row population  
                  suppressDateEvents = true;
                  autoDateHandlingEnabled = false;

                  // Temporarily remove restrictions to set historical values  
                  IssuedateTimePicker1.MinDate = DateTimePicker.MinimumDateTime;
                  IssuedateTimePicker1.MaxDate = DateTimePicker.MaximumDateTime;

                  DateTime issueDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value);
                  IssuedateTimePicker1.Value = issueDate;*/
                UpdateExpiryDate();
                IssuedateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value);
                textBox9.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[11].Value).ToString(" M/ d/yyyy");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting the row: " + ex.Message);
            }
            finally
            {
                suppressDateEvents = false;
                // DO NOT re-enable autoDateHandlingEnabled here — wait for Clear button to do that  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected LearnerID from the DataGridView  
                int learnerID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete" + " " + "Learner ID:" + textBox8.Text.ToString() + "," + " " + textBox1.Text.ToString() + " " + textBox2.Text.ToString() +
                    " and their related progress record ?" ,
                                                       "Confirm Deletion",
                                                       MessageBoxButtons.YesNo, // Corrected argument  
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    DeleteLearnerFromDatabase(learnerID);
                    // Optional: clear form fields  
                    tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner);

                    // Clear all textboxes and combo boxes  
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    
                    IssuedateTimePicker1.Value = DateTime.Today;

                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                    comboBox3.SelectedIndex = -1;
                    comboBox4.SelectedIndex = -1;
                    textBox9.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please select a learner to delete.", "No Learner Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Corrected argument  
            }
        }
        private void DeleteLearnerFromDatabase(int learnerID)
        {
            /*  string connectionString = "Data Source=146.230.177.46;Initial Catalog=WstGrp2;Persist Security Info=True;User ID=WstGrp2;Password=d9jdh;TrustServerCertificate=True"; // Replace with your actual DB connection string

              using (SqlConnection conn = new SqlConnection(connectionString))
              {
                  string query = "DELETE FROM tblLearner WHERE LearnerID = @LearnerID";

                  using (SqlCommand cmd = new SqlCommand(query, conn))
                  {
                      cmd.Parameters.AddWithValue("@LearnerID", learnerID);

                      conn.Open();
                      cmd.ExecuteNonQuery();
                      conn.Close();
                  }
              }

              MessageBox.Show("Learner deleted successfully.");*/
            string connectionString = "Data Source=146.230.177.46;Initial Catalog=WstGrp2;Persist Security Info=True;User ID=WstGrp2;Password=d9jdh;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // First delete from TrackLearner
                    string deleteTracking = "DELETE FROM TrackLearner WHERE LearnerID = @LearnerID";
                    using (SqlCommand cmdTracking = new SqlCommand(deleteTracking, conn))
                    {
                        cmdTracking.Parameters.AddWithValue("@LearnerID", learnerID);
                        cmdTracking.ExecuteNonQuery();
                    }

                    // Then delete from tblLearner
                    string deleteLearner = "DELETE FROM tblLearner WHERE LearnerID = @LearnerID";
                    using (SqlCommand cmdLearner = new SqlCommand(deleteLearner, conn))
                    {
                        cmdLearner.Parameters.AddWithValue("@LearnerID", learnerID);
                        cmdLearner.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                MessageBox.Show("The learner and all related progress records were successfully deleted.",
                                "Deletion Complete",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops! Something went wrong while trying to delete the learner.\n\n" +
                                "Please check your connection or try again later.\n\n" +
                                "Details: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblLearnerTableAdapter.FillBy1(this.wstGrp2DataSet.tblLearner);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblLearnerTableAdapter.FillBy2(this.wstGrp2DataSet.tblLearner);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblLearnerTableAdapter.FillBy(this.wstGrp2DataSet1.tblLearner);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
     || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text)
     || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(comboBox3.Text)
     || IssuedateTimePicker1.Value == IssuedateTimePicker1.MinDate || string.IsNullOrWhiteSpace(textBox9.Text) || string.IsNullOrWhiteSpace(comboBox4.Text)
     || string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Please complete all required fields before updating.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp2;Persist Security Info=True;User ID=WstGrp2;Password=d9jdh;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();

                    string selectQuery = "SELECT * FROM tblLearner WHERE LearnerID = @learnerID";
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
                    {
                        selectCmd.Parameters.AddWithValue("@learnerID", Convert.ToInt32(textBox8.Text));
                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool hasChanges = false;

                                hasChanges |= !reader["Learner_Name"].ToString().Trim().Equals(textBox1.Text.Trim());
                                hasChanges |= !reader["Learner_Surname"].ToString().Trim().Equals(textBox2.Text.Trim());
                                hasChanges |= !reader["Learner_IDNumber"].ToString().Trim().Equals(textBox3.Text.Trim());
                                hasChanges |= Convert.ToInt32(reader["Learner_Age"]) != Convert.ToInt32(textBox4.Text);
                                hasChanges |= !reader["Learner_Gender"].ToString().Trim().Equals(comboBox1.Text.Trim());
                                hasChanges |= !reader["Learner_Race"].ToString().Trim().Equals(comboBox2.Text.Trim());
                                hasChanges |= !reader["Learner_CellNumber"].ToString().Trim().Equals(textBox5.Text.Trim());
                                hasChanges |= !reader["Learner_StreetAddress"].ToString().Trim().Equals(textBox6.Text.Trim());
                                hasChanges |= !reader["Learner_Suburb"].ToString().Trim().Equals(comboBox3.Text.Trim());
                                hasChanges |= Convert.ToDateTime(reader["Learner_LearnersIssueDate"]).Date != IssuedateTimePicker1.Value.Date;
                                hasChanges |= Convert.ToDateTime(reader["Learner_LearnersExpiryDate"]).Date != Convert.ToDateTime(textBox9.Text).Date;
                                hasChanges |= Convert.ToInt32(reader["Code_Type"]) != Convert.ToInt32(comboBox4.Text);

                                if (!hasChanges)
                                {
                                    MessageBox.Show("No changes were made. Learner information is already up to date.", "No Changes Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Learner not found. Please check the ID and try again.", "Learner Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Proceed with update
                    string query = "UPDATE tblLearner SET " +
                        "Learner_Name = @learner_Name, " +
                        "Learner_Surname = @learner_Surname, " +
                        "Learner_IDNumber = @learner_IDNumber, " +
                        "Learner_Age = @learner_Age, " +
                        "Learner_Gender = @learner_Gender, " +
                        "Learner_Race = @learner_Race, " +
                        "Learner_CellNumber = @learner_CellNumber, " +
                        "Learner_StreetAddress = @learner_StreetAddress, " +
                        "Learner_Suburb = @learner_Suburb, " +
                        "Learner_LearnersIssueDate = @learner_LearnersIssueDate, " +
                        "Learner_LearnersExpiryDate = @learner_LearnersExpiryDate, " +
                        "Code_Type = @code_Type " +
                        "WHERE LearnerID = @learnerID";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@learnerID", Convert.ToInt32(textBox8.Text));
                        command.Parameters.AddWithValue("@learner_Name", textBox1.Text.Trim());
                        command.Parameters.AddWithValue("@learner_Surname", textBox2.Text.Trim());
                        command.Parameters.AddWithValue("@learner_IDNumber", textBox3.Text.Trim());
                        command.Parameters.AddWithValue("@learner_Age", Convert.ToInt32(textBox4.Text));
                        command.Parameters.AddWithValue("@learner_Gender", comboBox1.Text.Trim());
                        command.Parameters.AddWithValue("@learner_Race", comboBox2.Text.Trim());
                        command.Parameters.AddWithValue("@learner_CellNumber", textBox5.Text.Trim());
                        command.Parameters.AddWithValue("@learner_StreetAddress", textBox6.Text.Trim());
                        command.Parameters.AddWithValue("@learner_Suburb", comboBox3.Text.Trim());
                        command.Parameters.AddWithValue("@learner_LearnersIssueDate", IssuedateTimePicker1.Value);
                        command.Parameters.AddWithValue("@learner_LearnersExpiryDate", Convert.ToDateTime(textBox9.Text));
                        command.Parameters.AddWithValue("@code_Type", Convert.ToInt32(comboBox4.Text));

                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to update learner " + textBox8.Text + "," + textBox1.Text + " " + textBox2.Text + "?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Learner information has been updated successfully.", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tblLearnerTableAdapter.Fill(wstGrp2DataSet1.tblLearner);

                            // Clear all textboxes and combo boxes after successful update
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
                            textBox8.Clear();
                            
                            IssuedateTimePicker1.Value = DateTime.Today;
                            comboBox1.SelectedIndex = -1; // Reset to no selection
                            comboBox2.SelectedIndex = -1; // Reset to no selection
                            comboBox3.SelectedIndex = -1; // Reset to no selection
                            comboBox4.SelectedIndex = -1; // Reset to no selection
                            textBox9.Clear(); // Clear expiry date textbox

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong while updating. Please try again.\n\nDetails: " + ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           HomeForm home = new HomeForm(Loginform); 
            home.Employee_Name = Loginform.Employee_Name;
            home.Employee_Surname = Loginform.Employee_Surname;
            home.Employee_Type = Loginform.Employee_Type;
            home.Show();                             
            this.Hide();
        }

        private void fillBy2ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button5.Visible = false;

           textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            IssuedateTimePicker1.Enabled = false;
            textBox9.Enabled = false;
            comboBox4.Enabled = false;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            IssuedateTimePicker1.Enabled = true;
            textBox9.Enabled = true;
            comboBox4.Enabled = true;
        }

        private void label16_Click(object sender, EventArgs e)
        {
           
        }
        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label16.ForeColor = Color.DarkRed; // or a hover color you prefer
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.ForeColor = Color.Blue;
        }
        

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void comboBox3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {
            string instructions = "📋 Learner Management Instructions:\n\n" +
                         "🔍 Search:\n" +
                         " - Enter a learner's ID, name, or surname in the search box.\n" +
                         " - Matching learners will appear in the table below.\n\n" +
                         "🧾 Viewing Learners:\n" +
                         " - Click on a row in the table to load that learner's details into the form.\n" +
                         " - Their info will appear in the fields on the left.\n\n" +
                         "🖋️ Edit Mode:\n" +
                         " - Turn Edit Mode ON to enable changes to learner info.\n" +
                         " - Turn it OFF to prevent accidental edits.\n\n" +
                         "➕ Add:\n" +
                         " - Fill out all fields.\n" +
                         " - Click **Add** to create a new learner record.\n\n" +
                         "🔄 Update:\n" +
                         " - Select a learner from the grid.\n" +
                         " - Make the desired changes (Edit Mode must be ON).\n" +
                         " - Click Update to save changes.\n\n" +
                         "❌ Delete:\n" +
                         " - Select a learner in the grid.\n" +
                         " - Click Delete to remove them permanently.\n\n" +
                         "🧽 Clear:\n" +
                         " - Clears all the fields in the form.\n\n" +
                         "🔁 Reset:\n" +
                         " - Clears the search box and reloads all learners in the table.\n\n" +
                         "📅 Issue/Expiry Dates:\n" +
                         " - Set the Issue Date, and the **Expiry Date** is calculated automatically.\n\n" +
                         "🚪 Logout:\n" +
                         " - Logs out of the system and returns to the login screen.\n\n" +
                         "💡 Tip: Hover your mouse over any field or button for a helpful tooltip.";

            MessageBox.Show(instructions, "How to Use This Form", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
