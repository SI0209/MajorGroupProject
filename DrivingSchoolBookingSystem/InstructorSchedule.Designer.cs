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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblInstuctorScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.taBooking = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblBookingTableAdapter();
            this.taLearner = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblLearnerTableAdapter();
            this.taVehicle = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblVehicleTableAdapter();
            this.taEmployee = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblEmployeeTableAdapter();
            this.taInstructorSchedule = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblInstuctorScheduleTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dsBookingSystem = new DrivingSchoolBookingSystem.WstGrp2DataSet();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInstuctorScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookingSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(807, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 41);
            this.label4.TabIndex = 54;
            this.label4.Text = "Instructor Schedule";
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
            this.dataGridView1.Location = new System.Drawing.Point(405, 301);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1274, 408);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblInstuctorScheduleBindingSource
            // 
            this.tblInstuctorScheduleBindingSource.DataMember = "tblInstuctorSchedule";
            this.tblInstuctorScheduleBindingSource.DataSource = this.dsBookingSystem;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(900, 226);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(340, 30);
            this.dtpDate.TabIndex = 104;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(660, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 32);
            this.label14.TabIndex = 105;
            this.label14.Text = "Search by date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DrivingSchoolBookingSystem.Properties.Resources.Untitled_design__12__removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(715, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(-12, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 1027);
            this.panel1.TabIndex = 107;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.image_removebg_preview__13_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(30, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 82);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(60, 932);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 32);
            this.label18.TabIndex = 17;
            this.label18.Text = "Log out";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.log_out;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(50, 832);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(106, 97);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.logo_transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(22, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 144);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // dsBookingSystem
            // 
            this.dsBookingSystem.DataSetName = "WstGrp2DataSet";
            this.dsBookingSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "Booking_Date";
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
            // InstructorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.Background_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1011);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InstructorSchedule";
            this.Text = "InstuctorSchcedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInstuctorScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookingSystem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WstGrp2DataSetTableAdapters.tblBookingTableAdapter taBooking;
        private WstGrp2DataSetTableAdapters.tblLearnerTableAdapter taLearner;
        private WstGrp2DataSetTableAdapters.tblVehicleTableAdapter taVehicle;
        private WstGrp2DataSetTableAdapters.tblEmployeeTableAdapter taEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource tblInstuctorScheduleBindingSource;
        private WstGrp2DataSetTableAdapters.tblInstuctorScheduleTableAdapter taInstructorSchedule;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
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
        private WstGrp2DataSet dsBookingSystem;
    }
}