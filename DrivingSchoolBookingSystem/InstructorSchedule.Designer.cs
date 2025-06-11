namespace DrivingSchoolBookingSystem
{
    partial class InstructorSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorSchedule));
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblInstuctorScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBookingSystem = new DrivingSchoolBookingSystem.WstGrp2DataSet();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.taBooking = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblBookingTableAdapter();
            this.taLearner = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblLearnerTableAdapter();
            this.taVehicle = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblVehicleTableAdapter();
            this.taEmployee = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblEmployeeTableAdapter();
            this.taInstructorSchedule = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblInstuctorScheduleTableAdapter();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInstuctorScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(696, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 38);
            this.label4.TabIndex = 54;
            this.label4.Text = "Instructor Schedule";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(13, 12);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 38);
            this.lblName.TabIndex = 56;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingDateDataGridViewTextBoxColumn,
            this.bookingStartTimeDataGridViewTextBoxColumn,
            this.bookingEndTimeDataGridViewTextBoxColumn,
            this.bookingStatusDataGridViewTextBoxColumn,
            this.codeTypeDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeSurnameDataGridViewTextBoxColumn,
            this.learnerNameDataGridViewTextBoxColumn,
            this.learnerSurnameDataGridViewTextBoxColumn,
            this.vehicleMakeDataGridViewTextBoxColumn,
            this.vehicleModelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblInstuctorScheduleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 260);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1511, 437);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "Booking_Date";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.bookingDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.Width = 122;
            // 
            // bookingStartTimeDataGridViewTextBoxColumn
            // 
            this.bookingStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Booking_StartTime";
            this.bookingStartTimeDataGridViewTextBoxColumn.HeaderText = "Booking_StartTime";
            this.bookingStartTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingStartTimeDataGridViewTextBoxColumn.Name = "bookingStartTimeDataGridViewTextBoxColumn";
            this.bookingStartTimeDataGridViewTextBoxColumn.Width = 151;
            // 
            // bookingEndTimeDataGridViewTextBoxColumn
            // 
            this.bookingEndTimeDataGridViewTextBoxColumn.DataPropertyName = "Booking_EndTime";
            this.bookingEndTimeDataGridViewTextBoxColumn.HeaderText = "Booking_EndTime";
            this.bookingEndTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingEndTimeDataGridViewTextBoxColumn.Name = "bookingEndTimeDataGridViewTextBoxColumn";
            this.bookingEndTimeDataGridViewTextBoxColumn.Width = 148;
            // 
            // bookingStatusDataGridViewTextBoxColumn
            // 
            this.bookingStatusDataGridViewTextBoxColumn.DataPropertyName = "Booking_Status";
            this.bookingStatusDataGridViewTextBoxColumn.HeaderText = "Booking_Status";
            this.bookingStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingStatusDataGridViewTextBoxColumn.Name = "bookingStatusDataGridViewTextBoxColumn";
            this.bookingStatusDataGridViewTextBoxColumn.Width = 130;
            // 
            // codeTypeDataGridViewTextBoxColumn
            // 
            this.codeTypeDataGridViewTextBoxColumn.DataPropertyName = "Code_Type";
            this.codeTypeDataGridViewTextBoxColumn.HeaderText = "Code_Type";
            this.codeTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeTypeDataGridViewTextBoxColumn.Name = "codeTypeDataGridViewTextBoxColumn";
            this.codeTypeDataGridViewTextBoxColumn.Width = 108;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.Width = 142;
            // 
            // employeeSurnameDataGridViewTextBoxColumn
            // 
            this.employeeSurnameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Surname";
            this.employeeSurnameDataGridViewTextBoxColumn.HeaderText = "Employee_Surname";
            this.employeeSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeSurnameDataGridViewTextBoxColumn.Name = "employeeSurnameDataGridViewTextBoxColumn";
            this.employeeSurnameDataGridViewTextBoxColumn.Width = 159;
            // 
            // learnerNameDataGridViewTextBoxColumn
            // 
            this.learnerNameDataGridViewTextBoxColumn.DataPropertyName = "Learner_Name";
            this.learnerNameDataGridViewTextBoxColumn.HeaderText = "Learner_Name";
            this.learnerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerNameDataGridViewTextBoxColumn.Name = "learnerNameDataGridViewTextBoxColumn";
            this.learnerNameDataGridViewTextBoxColumn.Width = 126;
            // 
            // learnerSurnameDataGridViewTextBoxColumn
            // 
            this.learnerSurnameDataGridViewTextBoxColumn.DataPropertyName = "Learner_Surname";
            this.learnerSurnameDataGridViewTextBoxColumn.HeaderText = "Learner_Surname";
            this.learnerSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerSurnameDataGridViewTextBoxColumn.Name = "learnerSurnameDataGridViewTextBoxColumn";
            this.learnerSurnameDataGridViewTextBoxColumn.Width = 143;
            // 
            // vehicleMakeDataGridViewTextBoxColumn
            // 
            this.vehicleMakeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Make";
            this.vehicleMakeDataGridViewTextBoxColumn.HeaderText = "Vehicle_Make";
            this.vehicleMakeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleMakeDataGridViewTextBoxColumn.Name = "vehicleMakeDataGridViewTextBoxColumn";
            this.vehicleMakeDataGridViewTextBoxColumn.Width = 122;
            // 
            // vehicleModelDataGridViewTextBoxColumn
            // 
            this.vehicleModelDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Model";
            this.vehicleModelDataGridViewTextBoxColumn.HeaderText = "Vehicle_Model";
            this.vehicleModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleModelDataGridViewTextBoxColumn.Name = "vehicleModelDataGridViewTextBoxColumn";
            this.vehicleModelDataGridViewTextBoxColumn.Width = 126;
            // 
            // tblInstuctorScheduleBindingSource
            // 
            this.tblInstuctorScheduleBindingSource.DataMember = "tblInstuctorSchedule";
            this.tblInstuctorScheduleBindingSource.DataSource = this.dsBookingSystem;
            // 
            // dsBookingSystem
            // 
            this.dsBookingSystem.DataSetName = "G3Wst2024DataSet";
            this.dsBookingSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(20, 782);
            this.pbBack.Margin = new System.Windows.Forms.Padding(4);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(52, 48);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 103;
            this.pbBack.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.dtpDate.Location = new System.Drawing.Point(184, 148);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(359, 34);
            this.dtpDate.TabIndex = 104;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(25, 148);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 28);
            this.label17.TabIndex = 106;
            this.label17.Text = "Search by date";
            // 
            // taBooking
            // 
            this.taBooking.ClearBeforeFill = true;
            // 
            // taLearner
            // 
            this.taLearner.ClearBeforeFill = true;
            // 
            // taVehicle
            // 
            this.taVehicle.ClearBeforeFill = true;
            // 
            // taEmployee
            // 
            this.taEmployee.ClearBeforeFill = true;
            // 
            // taInstructorSchedule
            // 
            this.taInstructorSchedule.ClearBeforeFill = true;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Location = new System.Drawing.Point(703, 12);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(279, 183);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 55;
            this.PictureBox3.TabStop = false;
            // 
            // InstructorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 863);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InstructorSchedule";
            this.Text = "InstuctorSchcedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInstuctorScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WstGrp2DataSet dsBookingSystem;
        private WstGrp2DataSetTableAdapters.tblBookingTableAdapter taBooking;
        private WstGrp2DataSetTableAdapters.tblLearnerTableAdapter taLearner;
        private WstGrp2DataSetTableAdapters.tblVehicleTableAdapter taVehicle;
        private WstGrp2DataSetTableAdapters.tblEmployeeTableAdapter taEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.BindingSource tblInstuctorScheduleBindingSource;
        private WstGrp2DataSetTableAdapters.tblInstuctorScheduleTableAdapter taInstructorSchedule;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModelDataGridViewTextBoxColumn;
        internal System.Windows.Forms.PictureBox PictureBox3;
    }
}