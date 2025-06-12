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
            this.tblLearnerTableAdapter.Fill(this.wstGrp2DataSet.tblLearner);
            // TODO: This line of code loads data into the 'wstGrp2DS2.tblNewLearner' table. You can move, or remove it, as needed.
            this.tblNewLearnerTableAdapter.FillByNewLearner(this.wstGrp2DS2.tblNewLearner);
            // TODO: This line of code loads data into the 'wstGrp2DS2.LearnerProgress' table. You can move, or remove it, as needed.
            this.learnerProgressTableAdapter.Fill(this.wstGrp2DS2.LearnerProgress);
            // TODO: This line of code loads data into the 'wstGrp2DS21.LearnerProgress' table. You can move, or remove it, as needed.
            this.trackLearnerTableAdapter.FillBy(this.wstGrp2DS2.TrackLearner);
            // TODO: This line of code loads data into the 'wstGrp2DS2.LearnerProgress' table. You can move, or remove it, as needed.
            //zthis.learnerProgressTableAdapter.Fill(this.wstGrp2DS2.LearnerProgress);
            // TODO: This line of code loads data into the 'bookingSystemDataSet.tblLearners' table. You can move, or remove it, as needed.
            // this.tblLearnersTableAdapter.Fill(this.bookingSystemDataSet.tblLearners);

            label6.Visible = false;
            textBox4.Visible = false;
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
            textBox4.Visible = false;
            label6.Visible = false;

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
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox3.Text)
                || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(comboBox4.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=WstGrp2;Persist Security Info=True;User ID=WstGrp2;Password=d9jdh;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();

                    string query = "UPDATE TrackLearner " +
                     "SET LearnerID = @learnerID, " +
                     "LearnerName = @learnerName, " +
                     "LearnerSurname = @learnerSurname, " +
                     "LessonDate = @lessonDate, " +
                     "LessonTopic = @lessonTopic, " +
                     "Attendance = @attendance, " +
                     "Rating = @rating, " + 
                     "ErrorsMade = @errorsMade, " + 
                     "Comments = @comments, " +
                     "PassStatus = @passStatus " +
                     "WHERE ProgressID = @progressID";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        //Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@learnerID", Convert.ToInt32(textBox1.Text));
                        command.Parameters.AddWithValue("@learnerName", textBox2.Text);
                        command.Parameters.AddWithValue("@learnerSurname", textBox3.Text);
                        command.Parameters.AddWithValue("@lessonDate", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@lessonTopic", comboBox1.Text);
                        command.Parameters.AddWithValue("@attendance", comboBox2.Text);
                        command.Parameters.AddWithValue("@rating", comboBox3.Text);
                        command.Parameters.AddWithValue("@errorsMade", textBox5.Text);
                        command.Parameters.AddWithValue("@comments", textBox6.Text);
                        command.Parameters.AddWithValue("@passStatus", comboBox4.Text);
                        command.Parameters.AddWithValue("@progressID", textBox4.Text);

                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to UPDATE learner " + textBox1.Text.ToString() + " details ?", "Confirmation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Learner has been updated successfully.");
                            trackLearnerTableAdapter.FillBy(wstGrp2DS2.TrackLearner);

                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            dateTimePicker1.Value = DateTime.Now;//default value
                            comboBox1.Text = "";
                            comboBox2.Text = "";
                            comboBox3.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            comboBox4.Text = "";
                            

                         
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }


            }


        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            comboBox4.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            label6.Visible = true;
            textBox4.Visible = true;
            textBox4.Enabled = false;
            
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
            string input = textBox8.Text.Trim();
            if (input.All(char.IsLetter))
            {
                trackLearnerTableAdapter.FillByLearnerName(this.wstGrp2DS2.TrackLearner, input);

            }
            else
            {
                MessageBox.Show("Please enter a valid name.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            trackLearnerTableAdapter.FillBy(this.wstGrp2DS2.TrackLearner);
            textBox8.Text = "";
        }
    }
}
