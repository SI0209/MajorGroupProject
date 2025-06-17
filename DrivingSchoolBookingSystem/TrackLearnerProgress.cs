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
using System.IO;
/*using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.Diagnostics;
using System.IO;*/

namespace DrivingSchoolBookingSystem
{
    public partial class LearnerProgressForm : Form
    {
        LoginForm loginform;
        public LearnerProgressForm()
        {
            InitializeComponent();
            label6.Text = "Click here for further instructions";
            label6.ForeColor = Color.Blue;
            label6.Font = new Font(label6.Font, FontStyle.Underline);
            label6.Cursor = Cursors.Hand;
            // Configure tooltip timing and behavior
            toolTip1.AutoPopDelay = 5000;     // Time the tooltip stays visible
            toolTip1.InitialDelay = 500;      // Delay before it appears
            toolTip1.ReshowDelay = 100;       // Delay before showing again
            toolTip1.ShowAlways = true;       // Show even when form isn't active

            // GridViews
            toolTip1.SetToolTip(dataGridView1, "Click a learner row to view or update progress.");
            toolTip1.SetToolTip(dataGridView2, "Shows learners not yet added to progress tracking.");
            toolTip1.SetToolTip(textBox7, "Search by learner first name.");
            toolTip1.SetToolTip(textBox8, "Search by learner first name or lesson topic.");

            // Textboxes & Fields
            toolTip1.SetToolTip(textBox1, "Enter learner first name or lesson topic to search.");
            toolTip1.SetToolTip(textBox2, "Enter learner's name to filter new learners.");
            toolTip1.SetToolTip(comboBox1, "Enter the topic covered in the lesson.");
            toolTip1.SetToolTip(comboBox2, "Mark attendance status.");
            toolTip1.SetToolTip(comboBox3, "Rate learner's performance.");
            toolTip1.SetToolTip(textBox5, "Describe any errors made during the lesson.");
            toolTip1.SetToolTip(textBox6, "Add any additional remarks about the session.");
            toolTip1.SetToolTip(comboBox4, "Choose the overall progress note.");
            toolTip1.SetToolTip(dateTimePicker1, "Pick the lesson date");

            // Buttons
            toolTip1.SetToolTip(button5, "Clears the search box and reloads all progress data.");
            toolTip1.SetToolTip(button4, "Clears the search box and reloads new learners into the grid.");
            toolTip1.SetToolTip(button1, "Adds a new learner progress entry.");
            toolTip1.SetToolTip(button2, "Update progress details for the selected learner.");
            toolTip1.SetToolTip(button3, "Clears all progress entry fields.");

            // Edit Mode and Logout
            toolTip1.SetToolTip(radioButton1, "Turn ON to allow updates.");
            toolTip1.SetToolTip(radioButton2, "Turn OFF to prevent changes.");
            toolTip1.SetToolTip(pictureBox4, "Click here to log out safely.");
            toolTip1.SetToolTip(pictureBox5, "Redirect back to home page");
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
           
            radioButton2.Checked = true; // Default to "View Learner Progress" mode    

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
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox4.SelectedIndex = -1;


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
            /*   if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox3.Text)
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
               }*/
            /* ------------------------------------------------------------------
       1) BASIC “REQUIRED FIELDS” VALIDATION
    ------------------------------------------------------------------ */
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||            // LearnerName
                string.IsNullOrWhiteSpace(textBox3.Text) ||            // LearnerSurname
                string.IsNullOrWhiteSpace(comboBox1.Text) ||           // LessonTopic
                string.IsNullOrWhiteSpace(comboBox2.Text) ||           // Attendance
                string.IsNullOrWhiteSpace(comboBox3.Text) ||           // Rating
                string.IsNullOrWhiteSpace(textBox5.Text) ||            // ErrorsMade
                string.IsNullOrWhiteSpace(textBox6.Text) ||            // Comments
                string.IsNullOrWhiteSpace(comboBox4.Text))             // PassStatus
            {
                MessageBox.Show("Please fill in all required fields.",
                                "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /* ------------------------------------------------------------------
               2) CONTENT‑SPECIFIC CHECKS
            ------------------------------------------------------------------ */
            // Names should not contain digits
            if (textBox2.Text.Any(char.IsDigit) || textBox3.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name and surname cannot contain numbers.",
                                "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cell‑phone style length check (ErrorsMade & Comments aren’t numeric, so skipped)

            if (textBox5.Text.Length > 30)   // example guard against excessively long “Errors” text
            {
                MessageBox.Show("The Errors field is too long; please shorten it.",
                                "Input Too Long", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /* ------------------------------------------------------------------
               3) CONFIRMATION
            ------------------------------------------------------------------ */
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to add a new progress record for learner ID {textBox1.Text}\n" +
                $"{textBox2.Text} {textBox3.Text}?",
                "Confirm Add",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            /* ------------------------------------------------------------------
               4) DATABASE INSERT
            ------------------------------------------------------------------ */
            try
            {
                int learnerID = int.Parse(textBox1.Text);   // textBox1 is LearnerID (read‑only)

                trackLearnerTableAdapter.InsertQuery(
                    learnerID,
                    textBox2.Text.Trim(),                       // LearnerName
                    textBox3.Text.Trim(),                       // LearnerSurname
                    dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    comboBox1.Text.Trim(),                      // LessonTopic
                    comboBox2.Text.Trim(),                      // Attendance
                    comboBox3.Text.Trim(),                      // Rating
                    textBox5.Text.Trim(),                       // ErrorsMade
                    textBox6.Text.Trim(),                       // Comments
                    comboBox4.Text.Trim());                     // PassStatus

                // Refresh grids / lists
                trackLearnerTableAdapter.FillBy(this.wstGrp2DS2.TrackLearner);
                tblNewLearnerTableAdapter.FillByNewLearner(this.wstGrp2DS2.tblNewLearner);

                MessageBox.Show("New learner progress has been added successfully.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /* --------------------------------------------------------------
                   5) CLEAR ENTRY FIELDS FOR NEXT INPUT
                -------------------------------------------------------------- */
                dateTimePicker1.Value = DateTime.Today;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                textBox5.Clear();
                textBox6.Clear();
                textBox1.Clear
                    ();
                textBox2.Clear();
                textBox3.Clear();

                // Note: textBox1/2/3 remain because they show the currently‑selected learner
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the progress record:\n\n" + ex.Message,
                                "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        DialogResult dialogResult = MessageBox.Show($"Are you sure you want to UPDATE learner ID:" + textBox1.Text + "," + " " + textBox2.Text + " " + textBox3.Text + " " + "details?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();/* tblNewLearnerTableAdapter.FillByNewLearner(this.wstGrp2DS2.tblNewLearner);
             textBox7.Text = "";*/

            // Clear the search box
            textBox7.Clear();

            // Refill the table with learners who are NOT in the TrackLearner table
            tblNewLearnerTableAdapter.FillByNewLearner(this.wstGrp2DS2.tblNewLearner);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            /*string input = textBox7.Text.Trim();

            if (input.Length >= 1)
            {
                try
                {
                    this.tblNewLearnerTableAdapter.FillByLearnerName(this.wstGrp2DS2.tblNewLearner, textBox7.Text.Trim());


               }


                catch (Exception ex)
                {
                    MessageBox.Show("Error searching learners: " + ex.Message);
                }
            }
            else
            {
               tblNewLearnerTableAdapter.FillByNewLearner(this.wstGrp2DS2.tblNewLearner);
           }*/


            string input = textBox7.Text.Trim();

            if (input.Length >= 1)
            {
                try
                {
                    // Try searching for learners matching the name
                    this.tblNewLearnerTableAdapter.FillByLearnerName(this.wstGrp2DS2.tblNewLearner, input);

                    // Exclude learners that are already being tracked
                    foreach (DataRow trackRow in wstGrp2DS2.TrackLearner.Rows)
                    {
                        string learnerId = trackRow["LearnerID"].ToString();

                        var rowsToRemove = wstGrp2DS2.tblNewLearner
                            .Where(row => row["LearnerID"].ToString() == learnerId)
                            .ToList();

                        foreach (var row in rowsToRemove)
                            wstGrp2DS2.tblNewLearner.Rows.Remove(row);
                    }

                    // Check if any learners remain after filtering
                    if (wstGrp2DS2.tblNewLearner.Rows.Count == 0)
                    {
                        MessageBox.Show("No learner found matching your search. The full list will now be reloaded.",
                                        "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload default list
                        tblNewLearnerTableAdapter.FillByNewLearner(this.wstGrp2DS2.tblNewLearner);
                        textBox7.Clear();
                        // Remove already tracked learners again
                        foreach (DataRow trackRow in wstGrp2DS2.TrackLearner.Rows)
                        {
                            string learnerId = trackRow["LearnerID"].ToString();

                            var rowsToRemove = wstGrp2DS2.tblNewLearner
                                .Where(row => row["LearnerID"].ToString() == learnerId)
                                .ToList();

                            foreach (var row in rowsToRemove)
                                wstGrp2DS2.tblNewLearner.Rows.Remove(row);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong while searching. Please try again.\n\nDetails: " + ex.Message,
                                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    // Reload all learners who are not already being tracked
                    tblNewLearnerTableAdapter.FillByNewLearner(this.wstGrp2DS2.tblNewLearner);

                    // Exclude learners that are already being tracked
                    foreach (DataRow trackRow in wstGrp2DS2.TrackLearner.Rows)
                    {
                        string learnerId = trackRow["LearnerID"].ToString();

                        var rowsToRemove = wstGrp2DS2.tblNewLearner
                            .Where(row => row["LearnerID"].ToString() == learnerId)
                            .ToList();

                        foreach (var row in rowsToRemove)
                            wstGrp2DS2.tblNewLearner.Rows.Remove(row);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to reset the learner list. Please try again.\n\nDetails: " + ex.Message,
                                    "Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


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
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now; // Reset to current date
            comboBox1.SelectedIndex = -1; // Clear selection
            comboBox2.SelectedIndex = -1; // Clear selection
            comboBox3.SelectedIndex = -1; // Clear selection
            comboBox4.SelectedIndex = -1; // Clear selection
            textBox5.Clear(); // Clear ErrorsMade
            textBox6.Clear(); // Clear Comments
            
            

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(loginform);
            home.Employee_Name = loginform.Employee_Name;
            home.Employee_Surname = loginform.Employee_Surname;
            home.Employee_Type = loginform.Employee_Type;
            home.ShowDialog();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        // Remove or avoid using MigraDoc.Rendering-gdi namespace in the file to prevent ambiguity

       /* private void ExportDataGridViewToPdf()
        {
            // Create a new MigraDoc document
            Document doc = new Document();
            Section section = doc.AddSection();

            // Add a title
            Paragraph title = section.AddParagraph("Learner Progress Report");
            title.Format.Font.Size = 14;
            title.Format.Font.Bold = true;
            title.Format.SpaceAfter = "1cm";

            // Create table and set borders
            Table table = new Table();
            table.Borders.Width = 0.75;

            // Add columns
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                table.AddColumn(Unit.FromCentimeter(4));
            }

            // Add header row
            Row headerRow = table.AddRow();
            headerRow.Shading.Color = Colors.LightGray;
            headerRow.Format.Font.Bold = true;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                headerRow.Cells[i].AddParagraph(dataGridView1.Columns[i].HeaderText);
            }

            // Add data rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    Row dataRow = table.AddRow();
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        string cellValue = row.Cells[i].Value?.ToString() ?? "";
                        dataRow.Cells[i].AddParagraph(cellValue);
                    }
                }
            }

            section.Add(table);

            // Use the correct renderer (MigraDoc.Rendering namespace)
            var renderer = new PdfDocumentRenderer(true)
            {
                Document = doc
            };

            renderer.RenderDocument();

            // Save to desktop
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filename = Path.Combine(desktop, "LearnerProgressReport.pdf");
            renderer.PdfDocument.Save(filename);

            // Open PDF
            Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true });
        }*/


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
               
                textBox2.Enabled = false; // LearnerName should not be editable
                textBox3.Enabled = false;
                textBox6.Enabled = false; // Comments should not be editable
                textBox5.Enabled = false; // ErrorsMade should not be editable
                comboBox1.Enabled = false; // LessonTopic should not be editable
                comboBox2.Enabled = false; // Attendance should not be editable
                comboBox3.Enabled = false; // Rating should not be editable
                comboBox4.Enabled = false; // PassStatus should not be editable
                dateTimePicker1.Enabled = false; // LessonDate should not be editable

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;


                textBox2.Enabled = false; // LearnerName should not be editable
                textBox3.Enabled = false;
                textBox6.Enabled = true; // Comments now editable
                textBox5.Enabled = true; // ErrorsMade now editable

                comboBox1.Enabled = true; // LessonTopic now editable
                comboBox2.Enabled = true; // Attendance now editable
                comboBox3.Enabled = true; // Rating now editable
                comboBox4.Enabled = true; // PassStatus now editable

                dateTimePicker1.Enabled = true; // LessonDate now editable

            }
            }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.DarkRed;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Blue;
        }
       

        private void label6_Click_1(object sender, EventArgs e)
        {
            string instructions = "📘 Track Learner Progress – Instructions:\n\n" +
                      "🔍 Searching Progress Records:\n" +
                      " - Use the top search box to find progress by learner name or lesson topic.\n" +
                      " - Click Reset to reload all progress entries.\n\n" +
                      "📋 Viewing & Editing Progress:\n" +
                      " - Click a row in the progress table (top grid) to view their full details.\n" +
                      " - Learner details (ID, Name, Surname) are read-only.\n" +
                      " - Enable Edit Mode ON to make changes to progress fields.\n\n" +
                      "✏️ Updating Progress:\n" +
                      " - Select a learner from the top grid.\n" +
                      " - Make updates to progress info (topic, rating, errors, etc.).\n" +
                      " - Click Update to save changes.\n\n" +
                      "🆕 New Learners:\n" +
                      " - Bottom grid shows learners not yet tracked.\n" +
                      " - Search for them using the lower search box.\n" +
                      " - Select a row, then click Add to include them in progress tracking.\n\n" +
                      "🧽 Clear: Clears all entry fields.\n\n" +
                      "🔁 Auto Cleanup:\n" +
                      " - If a learner is deleted from the Learner Management form,\n" +
                      "   their progress record is automatically removed here.\n\n" +
                      "🚪 Logout: Safely logs you out of the system.\n\n" +
                      "💡 Tip: Hover over buttons and fields for helpful tooltips.";

            MessageBox.Show(instructions, "Track Learner Progress – Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
