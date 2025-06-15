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
    public partial class LearnerProgressForm : Form
    {
        public LearnerProgressForm()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp2DS2.TrackLearner' table. You can move, or remove it, as needed.
            this.trackLearnerTableAdapter.FillBy(this.wstGrp2DS2.TrackLearner);
            // TODO: This line of code loads data into the 'wstGrp2DataSet.tblLearner' table. You can move, or remove it, as needed.
            //this.tblLearnerTableAdapter.Fill(this.wstGrp2DataSet.tblLearner);
            // TODO: This line of code loads data into the 'wstGrp2DS2.tblNewLearner' table. You can move, or remove it, as needed.
           this.tblNewLearnerTableAdapter.FillByNewLearner(this.wstGrp2DS2.tblNewLearner);
            
            // TODO: This line of code loads data into the 'wstGrp2DS21.LearnerProgress' table. You can move, or remove it, as needed.
            //this.trackLearnerTableAdapter.FillBy(this.wstGrp2DS2.TrackLearner);
            // TODO: This line of code loads data into the 'wstGrp2DS2.LearnerProgress' table. You can move, or remove it, as needed.
            //this.learnerProgressTableAdapter.Fill(this.wstGrp2DS2.LearnerProgress);
            // TODO: This line of code loads data into the 'bookingSystemDataSet.tblLearners' table. You can move, or remove it, as needed.
            // this.tblLearnersTableAdapter.Fill(this.bookingSystemDataSet.tblLearners);

           
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
           

            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex=-1;
            comboBox3.SelectedIndex=-1;
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox4.SelectedIndex=-1;


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now; //default value
            comboBox1.SelectedIndex = -1; // Clear selection
          comboBox2.SelectedIndex = -1; // Clear selection
            comboBox3.SelectedIndex = -1; // Clear selection
         comboBox4.SelectedIndex = -1; // Clear selection
            textBox5.Text = "";
            textBox6.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox3.Text)
                || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(comboBox4.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            try
            {
                trackLearnerTableAdapter.InsertQuery(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    comboBox1.Text, comboBox2.Text, comboBox3.Text, textBox5.Text, textBox6.Text, comboBox4.Text);

                trackLearnerTableAdapter.FillBy(this.wstGrp2DS2.TrackLearner);
                tblNewLearnerTableAdapter.Fill(this.wstGrp2DS2.tblNewLearner);
                MessageBox.Show("New learner progress has been added successfully.");
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured:" + ex.Message);
                return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text)
                || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox3.Text)
                || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(comboBox4.Text))
            {
                MessageBox.Show("Please complete all required fields before updating.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if a row is selected in the DataGridView
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a learner record to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.CurrentRow;

            string originalLearnerName = selectedRow.Cells[1].Value?.ToString() ?? "";
            string originalLearnerSurname = selectedRow.Cells[2].Value?.ToString() ?? "";
            DateTime originalLessonDate = Convert.ToDateTime(selectedRow.Cells[3].Value);
            string originalLessonTopic = selectedRow.Cells[4].Value?.ToString() ?? "";
            string originalAttendance = selectedRow.Cells[5].Value?.ToString() ?? "";
            string originalRating = selectedRow.Cells[6].Value?.ToString() ?? "";
            string originalErrorsMade = selectedRow.Cells[7].Value?.ToString() ?? "";
            string originalComments = selectedRow.Cells[8].Value?.ToString() ?? "";
            string originalPassStatus = selectedRow.Cells[9].Value?.ToString() ?? "";

            // Compare original values with current input values
            bool noChange =
                originalLearnerName == textBox2.Text.Trim() &&
                originalLearnerSurname == textBox3.Text.Trim() &&
                originalLessonDate.Date == dateTimePicker1.Value.Date &&
                originalLessonTopic == comboBox1.Text.Trim() &&
                originalAttendance == comboBox2.Text.Trim() &&
                originalRating == comboBox3.Text.Trim() &&
                originalErrorsMade == textBox5.Text.Trim() &&
                originalComments == textBox6.Text.Trim() &&
                originalPassStatus == comboBox4.Text.Trim();

            if (noChange)
            {
                MessageBox.Show("No changes detected, update cancelled.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Now proceed with database update
            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp2;Persist Security Info=True;User ID=WstGrp2;Password=d9jdh;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();

                    // Check if LearnerID exists
                    string selectQuery = "SELECT * FROM TrackLearner WHERE LearnerID = @learnerID";
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
                    {
                        selectCmd.Parameters.AddWithValue("@learnerID", Convert.ToInt32(textBox1.Text));
                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                MessageBox.Show("Learner not found. Please check the Learner ID and try again.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Prepare update command
                    string query = "UPDATE TrackLearner SET " +
                        "LearnerName = @learnerName, " +
                        "LearnerSurname = @learnerSurname, " +
                        "LessonDate = @lessonDate, " +
                        "LessonTopic = @lessonTopic, " +
                        "Attendance = @attendance, " +
                        "Rating = @rating, " +
                        "ErrorsMade = @errorsMade, " +
                        "Comments = @comments, " +
                        "PassStatus = @passStatus " +
                        "WHERE LearnerID = @learnerID";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@learnerID", Convert.ToInt32(textBox1.Text));
                        command.Parameters.AddWithValue("@learnerName", textBox2.Text.Trim());
                        command.Parameters.AddWithValue("@learnerSurname", textBox3.Text.Trim());
                        command.Parameters.AddWithValue("@lessonDate", dateTimePicker1.Value.Date);
                        command.Parameters.AddWithValue("@lessonTopic", comboBox1.Text.Trim());
                        command.Parameters.AddWithValue("@attendance", comboBox2.Text.Trim());
                        command.Parameters.AddWithValue("@rating", comboBox3.Text.Trim());
                        command.Parameters.AddWithValue("@errorsMade", textBox5.Text.Trim());
                        command.Parameters.AddWithValue("@comments", textBox6.Text.Trim());
                        command.Parameters.AddWithValue("@passStatus", comboBox4.Text.Trim());

                        DialogResult dialogResult = MessageBox.Show($"Are you sure you want to UPDATE learner ID:" + textBox1.Text + "," + " " + textBox2.Text + " " + textBox3.Text  + " " + "details?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Learner has been updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh your data source here if you have a TableAdapter or similar
                            trackLearnerTableAdapter.FillBy(wstGrp2DS2.TrackLearner);

                            // Clear inputs
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            dateTimePicker1.Value = DateTime.Now;
                           comboBox1.SelectedIndex = -1;
                            comboBox2
                                .SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                            textBox5.Clear();
                            textBox6.Clear();
                            comboBox4.SelectedIndex = -1;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tblNewLearnerTableAdapter.FillByNewLearner(this.wstGrp2DS2.tblNewLearner);
            textBox7.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
              string input = textBox7.Text.Trim();
              if (input.All(char.IsLetter))
              {
                  tblNewLearnerTableAdapter.FillByLearnerName(this.wstGrp2DS2.tblNewLearner, input);

              }
              else{
                  MessageBox.Show("Please enter a valid name.");
              }
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            /*string input = textBox8.Text.Trim();
            if (input.All(char.IsLetter))
            {
                trackLearnerTableAdapter.FillByLearnerName(this.wstGrp2DS2.TrackLearner, input);

            }
            else
            {
                MessageBox.Show("Please enter a valid name.");
            }*/
            string input = textBox8.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    // Load all records if the search box is empty
                    trackLearnerTableAdapter.FillBy(this.wstGrp2DS2.TrackLearner);
                    return;
                }

                // Only match items that start with the input
                string keyword = input + "%";
                trackLearnerTableAdapter.FillByMulti(this.wstGrp2DS2.TrackLearner, keyword);

                if (wstGrp2DS2.TrackLearner.Rows.Count == 0)
                {
                    MessageBox.Show("No results starting with your input were found. Reloading full list.", "No Matches Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trackLearnerTableAdapter.FillBy(this.wstGrp2DS2.TrackLearner); // Reload full list
                    textBox8.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during the search. Please try again.\n\nDetails: " + ex.Message,
                                "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trackLearnerTableAdapter.FillBy(this.wstGrp2DS2.TrackLearner); // Fallback to full list
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            trackLearnerTableAdapter.FillBy(this.wstGrp2DS2.TrackLearner);
            textBox8.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
