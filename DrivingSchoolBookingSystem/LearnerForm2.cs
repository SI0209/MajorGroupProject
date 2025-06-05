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
    public partial class LearnerForm2 : Form
    {
        public LearnerForm2()
        {
            InitializeComponent();
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
                        comboBox1.SelectedValue.ToString(),
                        comboBox2.SelectedValue.ToString(),
                        textBox5.Text,
                        textBox6.Text,
                        comboBox3.SelectedValue.ToString(),
                        dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                        dateTimePicker2.Value.ToString("yyyy-MM-dd"),
                        Convert.ToInt16(comboBox4.SelectedValue)
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


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string input = textBox7.Text.Trim();

            if (textBox7.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Please enter digits only for learner ID.");
                return;
            }


            if (int.TryParse(input, out int learnerId))
            {
                tblLearnerTableAdapter.FillByLearnerID(this.wstGrp2DataSet1.tblLearner, learnerId);
            }
            else
            {
                
            }
            if (wstGrp2DataSet1.tblLearner.Rows.Count == 0)
            {
                MessageBox.Show("Invalid learner ID, please input a valid ID.");
                tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            label15.Visible = true;
            textBox8.Visible = true;
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
    }
}
