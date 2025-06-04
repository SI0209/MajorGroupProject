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
            tblLearnerTableAdapter.InsertNewLearner(textBox1.Text, textBox2.Text, textBox3.Text,Convert.ToInt16(textBox4.Text), comboBox1.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(), textBox6.Text, textBox5.Text, comboBox3.SelectedValue.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), Convert.ToInt16(comboBox4.SelectedValue));
            tblLearnerTableAdapter.Fill(this.wstGrp2DataSet.tblLearner);
            MessageBox.Show("Learner has been added successfully!");

        }
    }
}
