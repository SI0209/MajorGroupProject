using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            tblLearnerTableAdapter.FillByLearnerID(this.wstGrp2DataSet1.tblLearner, Convert.ToInt16(textBox7.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tblLearnerTableAdapter.Fill(this.wstGrp2DataSet1.tblLearner);
        }
    }
}
