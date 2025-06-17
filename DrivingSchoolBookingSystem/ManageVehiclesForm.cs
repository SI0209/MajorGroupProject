using DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters;
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
    public partial class ManageVehiclesForm : Form
    {
        private int VehicleID = -1;
        private ErrorControl errorControl = new ErrorControl();
        tblBookingTableAdapter taBooking = new tblBookingTableAdapter();
        LoginForm loginform;
        public ManageVehiclesForm(LoginForm Loginform)
        {
            InitializeComponent();
            loginform = Loginform;
            cmbSize.Items.AddRange(new string[] { "Small", "Medium", "Large" });
            cmbVehicleStatus.Items.AddRange(new string[] { "Available", "Unavailable" });
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp2DataSet.tblVehicle' table. You can move, or remove it, as needed.
            this.taVehicle.Fill(this.wstGrp2DataSet.tblVehicle);
        }
        public Boolean AllDataEntered()
        {
            if (txtNumberPlate.Text != "" && txtRegNum.Text != "" && txtMake.Text != "" && txtModel.Text != ""
               && txtEngineNum.Text != "" && cmbSize.Text != "" && cmbVehicleStatus.Text != "")
            {
                return true;
            }
            return false;
        }

        private Boolean RegNumberExists(string regNum)
        {
            foreach (DataRow row in this.wstGrp2DataSet.tblVehicle)
            {
                if (row["Vehicle_RegNum"].ToString().Equals(regNum))
                    return true;
            }
            return false;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string message = "";
            if (!AllDataEntered())
            {
                MessageBox.Show("Please enter data in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string numPlate = txtNumberPlate.Text;
                string regNum = txtRegNum.Text;
                string make = txtMake.Text;
                string model = txtModel.Text;
                string engineNum = txtEngineNum.Text;
                string vehicleSize = cmbSize.SelectedItem?.ToString() ?? "";
                string vehicleStatus = cmbVehicleStatus.SelectedItem?.ToString() ?? "";
                if (errorControl.ValidateNumberPlate(numPlate) != null)
                    message += errorControl.ValidateNumberPlate(numPlate) + "\n";
                if (errorControl.ValidateRegNum(regNum) != null)
                    message += errorControl.ValidateRegNum(regNum) + "\n";
                if (errorControl.ValidateEngineNum(engineNum) != null)
                    message += errorControl.ValidateEngineNum(engineNum) + "\n";
                if (errorControl.ValidateMake(make) != null)
                    message += errorControl.ValidateMake(make) + "\n";
                if (errorControl.ValidateModel(model) != null)
                    message += errorControl.ValidateModel(model) + "\n";
                if (RegNumberExists(regNum))
                    message += "Invalid! Cannot have two vehicles with the same registration number";
                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you would like to add this Vehicle?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            taVehicle.Insert(numPlate, regNum, engineNum, make, model, vehicleSize, vehicleStatus);
                            taVehicle.Fill(this.wstGrp2DataSet.tblVehicle);
                            btnClear.PerformClick();
                            MessageBox.Show("Vehicle successfully added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error adding vehicle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vehicle not added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        private Boolean isVehicleRelatedInABooking()
        {
            taBooking.Fill(this.wstGrp2DataSet.tblBooking);
            foreach (DataRow row in this.wstGrp2DataSet.tblVehicle.Rows)
            {
                if (Convert.ToInt16(row["VehicleID"]) == VehicleID)
                {
                    return true;
                }
            }
            return false;
        }

        private void dgvVehicles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((int)dgvVehicles.CurrentRow.Cells[0].Value < 0)
                return;
            VehicleID = (int)dgvVehicles.CurrentRow.Cells[0].Value;
            txtNumberPlate.Text = dgvVehicles.CurrentRow.Cells[1].Value.ToString();
            txtRegNum.Text = dgvVehicles.CurrentRow.Cells[2].Value.ToString();
            txtEngineNum.Text = dgvVehicles.CurrentRow.Cells[3].Value.ToString();
            txtMake.Text = dgvVehicles.CurrentRow.Cells[4].Value.ToString();
            txtModel.Text = dgvVehicles.CurrentRow.Cells[5].Value.ToString();
            cmbSize.Text = dgvVehicles.CurrentRow.Cells[6].Value.ToString();
            cmbVehicleStatus.Text = dgvVehicles.CurrentRow.Cells[7].Value.ToString();

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (VehicleID != -1)
            {
                if (!AllDataEntered())
                {
                    MessageBox.Show("Please enter data in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!isVehicleRelatedInABooking())
                    {
                        DialogResult result = MessageBox.Show("Are you sure you would like to DELETE this Vehicle details?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            taVehicle.DeleteVehicle(VehicleID);
                            taVehicle.Fill(this.wstGrp2DataSet.tblVehicle);
                            btnClear.PerformClick();
                            MessageBox.Show("Vehicle details successfully deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Vehicle details not deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please delete all booking records containing the vehicle you want to delete, first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnClear.PerformClick();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Vehicle from the vehicle list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtNumberPlate.Text = "";
            txtRegNum.Text = "";
            txtMake.Text = "";
            txtModel.Text = "";
            txtEngineNum.Text = "";
            cmbSize.SelectedIndex = -1;
            cmbVehicleStatus.SelectedIndex = -1;
            txtSearch.Text = "";
            txtNumberPlate.Focus();

            VehicleID = -1;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (VehicleID != -1)
            {
                string message = null;
                if (!AllDataEntered())
                {
                    MessageBox.Show("Please enter data in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string numPlate = txtNumberPlate.Text;
                    string regNum = txtRegNum.Text;
                    string make = txtMake.Text;
                    string model = txtModel.Text;
                    string engineNum = txtEngineNum.Text;
                    string vehicleSize = cmbSize.SelectedItem.ToString();
                    string vehicleStatus = cmbVehicleStatus.SelectedItem.ToString();
                    if (errorControl.ValidateNumberPlate(numPlate) != null)
                        message += errorControl.ValidateNumberPlate(numPlate) + "\n";
                    if (errorControl.ValidateRegNum(regNum) != null)
                        message += errorControl.ValidateRegNum(regNum) + "\n";
                    if (errorControl.ValidateEngineNum(engineNum) != null)
                        message += errorControl.ValidateEngineNum(engineNum) + "\n";
                    if (errorControl.ValidateMake(make) != null)
                        message += errorControl.ValidateMake(make) + "\n";
                    if (errorControl.ValidateModel(model) != null)
                        message += errorControl.ValidateModel(model) + "\n";
                    if (message != null)
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Are you sure you would like to update this Vehicle details?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            taVehicle.UpdateVehicle(numPlate, regNum, engineNum, make, model, vehicleSize, vehicleStatus, VehicleID);
                            taVehicle.Fill(this.wstGrp2DataSet.tblVehicle);
                            btnClear.PerformClick();
                            MessageBox.Show("Vehicle detailes successfully updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Vehicle details remain unchanged!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
                        }
                    }

                }
            }
            else
                MessageBox.Show("Please select a Vehicle from the vehicle list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string make = txtSearch.Text;
            taVehicle.FillByMake(this.wstGrp2DataSet.tblVehicle, make);
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtNumberPlate.Enabled = false;
                txtRegNum.Enabled = false;
                txtEngineNum.Enabled = false;
                txtMake.Enabled = false;
                txtModel.Enabled = false;
                cmbSize.Enabled = false;
                cmbVehicleStatus.Enabled = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnClear.Visible = false;
            }
            else
            {
                txtNumberPlate.Enabled = true;
                txtRegNum.Enabled = true;
                txtEngineNum.Enabled = true;
                txtMake.Enabled = true;
                txtModel.Enabled = true;
                cmbSize.Enabled = true;
                cmbVehicleStatus.Enabled = true;
                btnAdd.Visible = true;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnClear.Visible = true;
            }
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
=======
        
>>>>>>> 00ce2c6 (Fixed Home buttons)
    }
}