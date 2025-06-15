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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrivingSchoolBookingSystem
{
    public partial class ManageLearners : Form
    {
        private bool autoDateHandlingEnabled = true;
        private bool suppressDateEvents = false;

        public ManageLearners()
        {
            InitializeComponent();
            SetIssueDatePickerRange();
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

            //gender combox

            IssuedateTimePicker1.MinDate = DateTime.Today.AddYears(-2);
            IssuedateTimePicker1.MaxDate = DateTime.Today;


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
            if(string.IsNullOrWhiteSpace(textBox1.Text)||string.IsNullOrWhiteSpace(textBox2.Text)||string.IsNullOrWhiteSpace(textBox3.Text)||
                string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            if (textBox1.Text.Any(char.IsDigit)||textBox2.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name fields cannot contain numbers.");
                return;
            }
            if (textBox3.Text.Length>13)
            {
                MessageBox.Show("ID number cannot contain more than 13 digits");
                return;
            }
            else if (textBox3.Text.Any(char.IsLetter))
            {
                MessageBox.Show("ID number cannot contain letters.");
                return;
            }
            if (textBox4.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Age cannot contain letters.");
                return;
            }
            if (textBox5.Text.Length > 10)
            {
                MessageBox.Show("Cell phone number can only contain 10 digits.");
                return;
            }else if (textBox5.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Cell phone number cannot contain letters.");
                return;
            }
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

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
            


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           


            string input = textBox7.Text.Trim();

            try
            {
                bool isTextBox7Empty = string.IsNullOrWhiteSpace(input);
                {
                   tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner);
                }

                // Search by LearnerID if input is numeric
                if (input.All(char.IsDigit))
                {
                    if (int.TryParse(input, out int learnerId))
                    {
                        tblLearnerTableAdapter.FillByLearnerID(this.wstGrp2DataSet1.tblLearner, learnerId);
                    }
                }
                else
                {
                    // Search by Name or Surname (partial match with wildcards)
                    string keyword = $"%{input}%";
                    tblLearnerTableAdapter.FillByNameOrSurname(this.wstGrp2DataSet1.tblLearner, keyword);
                }

                // If no results found
                if (wstGrp2DataSet1.tblLearner.Rows.Count == 0)
                {
                    MessageBox.Show("No matching learner found. Reloading full list.");
                    tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner); // Load all learners
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message);
                tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner); // Load all learners in case of error
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner);
            textBox7.Clear();   
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
                textBox9.Text = expiryDate.ToString("yyyy-MM-dd");
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

                // Calculate expiry date as 2 years after issue date  
                DateTime expiryDate = IssuedateTimePicker1.Value.AddYears(2);

                // Fix: Convert DateTime to string before assigning to textBox9.Text  
                textBox9.Text = expiryDate.ToString("yyyy-MM-dd");
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

                // Disable automatic date handling during row population  
                suppressDateEvents = true;
                autoDateHandlingEnabled = false;

                // Temporarily remove restrictions to set historical values  
                IssuedateTimePicker1.MinDate = DateTimePicker.MinimumDateTime;
                IssuedateTimePicker1.MaxDate = DateTimePicker.MaximumDateTime;

                DateTime issueDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value);
                IssuedateTimePicker1.Value = issueDate;

                textBox9.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[11].Value).ToString("yyyy-MM-dd");
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

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this learner?",
                                                       "Confirm Delete",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    DeleteLearnerFromDatabase(learnerID);
                    // Optional: clear form fields
                    tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner);
                }
            }
            else
            {
                MessageBox.Show("Please select a learner to delete.");
            }
        }
        private void DeleteLearnerFromDatabase(int learnerID)
        {
            string connectionString = "Data Source=146.230.177.46;Initial Catalog=WstGrp2;Persist Security Info=True;User ID=WstGrp2;Password=d9jdh;TrustServerCertificate=True"; // Replace with your actual DB connection string

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

            MessageBox.Show("Learner deleted successfully.");
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
           if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) 
                || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text)
                || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(comboBox3.Text)
                || IssuedateTimePicker1.Value == IssuedateTimePicker1.MinDate || string.IsNullOrWhiteSpace(textBox9.Text) || string.IsNullOrWhiteSpace(comboBox4.Text)
                || string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Please fill in all required fields");
                return;
            }
            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp2;Persist Security Info=True;User ID=WstGrp2;Password=d9jdh;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();

                    string query = "UPDATE tblLearner " +
                     "SET Learner_Name = @learner_Name, " +
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
                        //Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@learnerID", Convert.ToInt32(textBox8.Text));
                        command.Parameters.AddWithValue("@learner_Name", textBox1.Text);
                        command.Parameters.AddWithValue("@learner_Surname", textBox2.Text);
                        command.Parameters.AddWithValue("@learner_IDNumber", textBox3.Text);
                        command.Parameters.AddWithValue("@learner_Age",Convert.ToInt32(textBox4.Text));
                        command.Parameters.AddWithValue("@learner_Gender", comboBox1.Text);
                        command.Parameters.AddWithValue("@learner_Race", comboBox2.Text);
                        command.Parameters.AddWithValue("@learner_CellNumber", textBox5.Text);
                        command.Parameters.AddWithValue("@learner_StreetAddress", textBox6.Text);
                        command.Parameters.AddWithValue("@learner_Suburb", comboBox3.Text);
                        command.Parameters.AddWithValue("@learner_LearnersIssueDate", IssuedateTimePicker1.Value);
                        command.Parameters.AddWithValue("@learner_LearnersExpiryDate",textBox9.Text);
                        command.Parameters.AddWithValue("@code_Type", Convert.ToInt32(comboBox4.Text));

                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to UPDATE learner  " + textBox8.Text.ToString() + " details ?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Learner has been updated successfully.");
                            tblLearnerTableAdapter.Fill(wstGrp2DataSet1.tblLearner);

                           



                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
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
           HomeForm home = new HomeForm(); 
            home.Show();                             
            this.Hide();
        }

        private void fillBy2ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
