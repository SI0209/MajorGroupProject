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
    public partial class LessonCodeForm : Form
    {
        ErrorControl errorControl = new ErrorControl();

        public LessonCodeForm()
        {
            InitializeComponent();
        }

        private void LessonCodeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp2DataSet.tblVehicle' table. You can move, or remove it, as needed.
            this.taVehicle.Fill(this.dsBookingSystem.tblVehicle);
            // TODO: This line of code loads data into the 'wstGrp2DataSet.tblLessonCode' table. You can move, or remove it, as needed.
            this.taLessonCodes.Fill(this.dsBookingSystem.tblLessonCode);

        }
        private Boolean AllDateEntered()
        {
            if (txtCodeType.Text != "" && txtPricePerHour.Text != "")
                return true;
            return false;
        }

        private void Clear()
        {
            txtCodeType.Text = "";
            txtPricePerHour.Text = "";
            txtCodeType.Focus();
        }

        private Boolean checkIfCodeAlreadyExists(int CodeType)

        {
            foreach (DataRow row in dsBookingSystem.tblLessonCode.Rows)
                if (Convert.ToInt16(row["Code_Type"]) == CodeType)
                    return true;
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = null;
            if (!AllDateEntered())
            {
                MessageBox.Show("Enter Data in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string codeType = txtCodeType.Text;
                string pricePerHour = txtPricePerHour.Text;
                if (errorControl.ValidateCodeType(codeType) != null)
                    message += errorControl.ValidateCodeType(codeType) + "\n";
                if (errorControl.ValidatePricePerHour(pricePerHour) != null)
                    message += errorControl.ValidatePricePerHour(pricePerHour);
                if (message == null)
                {
                    if (checkIfCodeAlreadyExists(Convert.ToInt16(codeType)))
                    {
                        MessageBox.Show("Code Type already exists - It cannot be added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to add this Code type?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            taLessonCodes.Insert(Convert.ToInt16(codeType), Convert.ToDecimal(pricePerHour));
                            taLessonCodes.Fill(dsBookingSystem.tblLessonCode);
                            btnClear.PerformClick();
                            MessageBox.Show("Code Type details successfully added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Code Type not added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = null;
            if (!AllDateEntered())
            {
                MessageBox.Show("Enter Data in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string codeType = txtCodeType.Text;
                string pricePerHour = txtPricePerHour.Text;
                if (errorControl.ValidateCodeType(codeType) != null)
                    message += errorControl.ValidateCodeType(codeType) + "\n";
                if (errorControl.ValidatePricePerHour(pricePerHour) != null)
                    message += errorControl.ValidatePricePerHour(pricePerHour);
                if (message == null)
                {
                    if (!checkIfCodeAlreadyExists(Convert.ToInt16(codeType)))
                    {
                        MessageBox.Show("Code Type does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to update this Code type?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            taLessonCodes.UpdateLessonCodes(Convert.ToDecimal(pricePerHour), Convert.ToInt16(codeType));
                            taLessonCodes.Fill(dsBookingSystem.tblLessonCode);
                            btnClear.PerformClick();
                            MessageBox.Show("Code Type details successfully updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Code Type details not updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnClear.PerformClick();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private Boolean isCodeTypeRelatedInABooking(int codeType)
        {
            taBooking.Fill(dsBookingSystem.tblBooking);
            foreach (DataRow row in dsBookingSystem.tblBooking.Rows)
            {
                if (Convert.ToInt16(row["Code_Type"]) == codeType)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = null;
            if (!AllDateEntered())
            {
                MessageBox.Show("Enter Data in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string codeType = txtCodeType.Text;
                if (errorControl.ValidateCodeType(codeType) != null)
                    message += errorControl.ValidateCodeType(codeType) + "\n";
                if (message == null)
                {
                    if (!checkIfCodeAlreadyExists(Convert.ToInt16(codeType)))
                    {
                        MessageBox.Show("Code Type does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!isCodeTypeRelatedInABooking(Convert.ToInt32(codeType)))
                        {
                            DialogResult result = MessageBox.Show("Are you sure you want to delete this Code type?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                taLessonCodes.DeleteLessonCode(Convert.ToInt32(codeType));
                                taLessonCodes.Fill(dsBookingSystem.tblLessonCode);
                                btnClear.PerformClick();
                                MessageBox.Show("Code Type details successfully deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Code Type details not deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnClear.PerformClick();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please delete all booking records containing the Code Type you want to delete, first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnClear.PerformClick();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
} 