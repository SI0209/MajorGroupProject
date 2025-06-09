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
            // TODO: This line of code loads data into the 'wstGrp2DataSet.tblLearner' table. You can move, or remove it, as needed.
            this.tblLearnerTableAdapter.Fill(this.wstGrp2DataSet.tblLearner);
            // TODO: This line of code loads data into the 'wstGrp2DS2.tblNewLearner' table. You can move, or remove it, as needed.
            this.tblNewLearnerTableAdapter.Fill(this.wstGrp2DS2.tblNewLearner);
            // TODO: This line of code loads data into the 'wstGrp2DS2.LearnerProgress' table. You can move, or remove it, as needed.
            this.learnerProgressTableAdapter.Fill(this.wstGrp2DS2.LearnerProgress);
            // TODO: This line of code loads data into the 'wstGrp2DS21.LearnerProgress' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'wstGrp2DS2.LearnerProgress' table. You can move, or remove it, as needed.
            //zthis.learnerProgressTableAdapter.Fill(this.wstGrp2DS2.LearnerProgress);
            // TODO: This line of code loads data into the 'bookingSystemDataSet.tblLearners' table. You can move, or remove it, as needed.
            // this.tblLearnersTableAdapter.Fill(this.bookingSystemDataSet.tblLearners);


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
            textBox4.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();

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

        }
    }
}
