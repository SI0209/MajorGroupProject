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
    public partial class ManageVehiclesForm : Form
    {
        private int VehicleID = -1;
        private ErrorControl errorControl = new ErrorControl();
        public ManageVehiclesForm()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp2DataSet.tblVehicle' table. You can move, or remove it, as needed.
            this.taVehicle.Fill(this.wstGrp2DataSet.tblVehicle);


        }

        private void dgvVehicles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvVehicles.Rows[e.RowIndex];
            VehicleID = Convert.ToInt32(row.Cells["VehicleID"].Value);

            txtVehicleMake.Text = row.Cells["Vehicle_Make"].Value?.ToString();
            txtVehicleModel.Text = row.Cells["Vehicle_Model"].Value?.ToString();
            txtVehicleYear.Text = row.Cells["Vehicle_Year"].Value?.ToString();
            txtVehicleReg.Text = row.Cells["Vehicle_Registration"].Value?.ToString();
            txtVIN.Text = row.Cells["Vehicle_EngineNumber"].Value?.ToString();
            cmbVehicleType.Text = row.Cells["Vehicle_Size"].Value?.ToString();
            cmbVehicleStatus.Text = row.Cells["Vehicle_Status"].Value?.ToString();
        }

        private bool AllDataEntered()
        {
            return !string.IsNullOrWhiteSpace(txtVehicleMake.Text) &&
                   !string.IsNullOrWhiteSpace(txtVehicleModel.Text) &&
                   !string.IsNullOrWhiteSpace(txtVehicleYear.Text) &&
                   !string.IsNullOrWhiteSpace(txtVehicleReg.Text) &&
                   !string.IsNullOrWhiteSpace(txtVIN.Text) &&
                   !string.IsNullOrWhiteSpace(cmbVehicleType.Text) &&
                   !string.IsNullOrWhiteSpace(cmbVehicleStatus.Text);
        }

        private bool RegNumberExists(string regNum)
        {
            foreach (DataRow row in wstGrp2DataSet.tblVehicle.Rows)
            {
                if (row["Vehicle_Registration"].ToString().Equals(regNum, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        private void ClearForm()
        {
            txtVehicleMake.Clear();
            txtVehicleModel.Clear();
            txtVehicleYear.Clear();
            txtVehicleReg.Clear();
            txtVIN.Clear();
            cmbVehicleType.SelectedIndex = -1;
            cmbVehicleStatus.SelectedIndex = -1;
            VehicleID = -1;
            txtVehicleMake.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = null;
            if (!AllDataEntered())
            {
                MessageBox.Show("Please enter data in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string make = txtVehicleMake.Text.Trim();
            string model = txtVehicleModel.Text.Trim();
            string year = txtVehicleYear.Text.Trim();
            string regNum = txtVehicleReg.Text.Trim();
            string engineNum = txtVIN.Text.Trim();
            string size = cmbVehicleType.Text;
            string status = cmbVehicleStatus.Text;

            // Perform validations similar to your earlier code (adapted for your field names)
            if (errorControl.ValidateMake(make) != null)
                message += errorControl.ValidateMake(make) + "\n";
            if (errorControl.ValidateModel(model) != null)
                message += errorControl.ValidateModel(model) + "\n";
            if (errorControl.ValidateRegNum(regNum) != null)
                message += errorControl.ValidateRegNum(regNum) + "\n";
            if (errorControl.ValidateEngineNum(engineNum) != null)
                message += errorControl.ValidateEngineNum(engineNum) + "\n";
            if (RegNumberExists(regNum))
                message += "Invalid! Cannot have two vehicles with the same registration number.\n";

            if (message != null)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you would like to add this Vehicle?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    taVehicle.Insert(txtVehicleMake.Text, txtVehicleModel.Text, txtVehicleYear.Text, txtVehicleReg.Text,
                                     txtVIN.Text, cmbVehicleType.Text, cmbVehicleStatus.Text);
                    taVehicle.Fill(wstGrp2DataSet.tblVehicle);
                    ClearForm();
                    MessageBox.Show("Vehicle successfully added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding vehicle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vehicle not added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtVehicleMake.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a vehicle make or model to search.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Filter rows in tblVehicle based on Make or Model containing search text
            var filteredRows = wstGrp2DataSet.tblVehicle
                .Where(v =>
                    v.Vehicle_Make != null && v.Vehicle_Make.ToLower().Contains(searchText) ||
                    v.Vehicle_Model != null && v.Vehicle_Model.ToLower().Contains(searchText))
                .ToList();

            if (filteredRows.Count == 0)
            {
                MessageBox.Show("No matching vehicles found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create a new DataTable to display filtered results
            DataTable dt = wstGrp2DataSet.tblVehicle.Clone(); // clone structure only

            foreach (var row in filteredRows)
            {
                dt.ImportRow(row);
            }

            dgvVehicles.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (VehicleID == -1)
            {
                MessageBox.Show("Please select a vehicle from the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!AllDataEntered())
            {
                MessageBox.Show("Please enter data in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you would like to DELETE this Vehicle details?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    taVehicle.DeleteVehicle(VehicleID);
                    taVehicle.Fill(wstGrp2DataSet.tblVehicle);
                    ClearForm();
                    MessageBox.Show("Vehicle details successfully deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting vehicle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vehicle details not deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (VehicleID == -1)
            {
                MessageBox.Show("Please select a vehicle from the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = null;
            if (!AllDataEntered())
            {
                MessageBox.Show("Please enter data in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string make = txtVehicleMake.Text.Trim();
            string model = txtVehicleModel.Text.Trim();
            string year = txtVehicleYear.Text.Trim();
            string regNum = txtVehicleReg.Text.Trim();
            string engineNum = txtVIN.Text.Trim();
            string size = cmbVehicleType.Text;
            string status = cmbVehicleStatus.Text;

            if (errorControl.ValidateMake(make) != null)
                message += errorControl.ValidateMake(make) + "\n";
            if (errorControl.ValidateModel(model) != null)
                message += errorControl.ValidateModel(model) + "\n";
            if (errorControl.ValidateRegNum(regNum) != null)
                message += errorControl.ValidateRegNum(regNum) + "\n";
            if (errorControl.ValidateEngineNum(engineNum) != null)
                message += errorControl.ValidateEngineNum(engineNum) + "\n";

            if (message != null)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you would like to update this Vehicle details?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    taVehicle.UpdateVehicle(regNum, engineNum, make, model, size, year, status, VehicleID);
                    taVehicle.Fill(wstGrp2DataSet.tblVehicle);
                    ClearForm();
                    MessageBox.Show("Vehicle details successfully updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating vehicle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vehicle details remain unchanged!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }
    }
}
        {

        }
    }
}
