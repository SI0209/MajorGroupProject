namespace DrivingSchoolBookingSystem
{
    partial class ManageBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLearner = new System.Windows.Forms.DataGridView();
            this.dsBookingSystem = new DrivingSchoolBookingSystem.WstGrp2DataSet();
            this.nudEndTime = new System.Windows.Forms.NumericUpDown();
            this.nudStartTime = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxVehicleID = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxEmployeeID = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxLearnerID = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxLessonCodes = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxBookingStatus = new System.Windows.Forms.ComboBox();
            this.dtpBooking = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.taBooking = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblBookingTableAdapter();
            this.taEmployee = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblEmployeeTableAdapter();
            this.taVehicle = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblVehicleTableAdapter();
            this.taLessonCode = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblLessonCodeTableAdapter();
            this.taLearner = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblLearnerTableAdapter();
            this.taBookingInnerJoin = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblBookingInnerJoinTableAdapter();
            this.taUnavailableSlot = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblUnavailableSlotTableAdapter();
            this.tblBookingInnerJoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStartTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingEndTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingInnerJoinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvLearner);
            this.panel1.Controls.Add(this.nudEndTime);
            this.panel1.Controls.Add(this.nudStartTime);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cbxVehicleID);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbxEmployeeID);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cbxLearnerID);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cbxLessonCodes);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbxBookingStatus);
            this.panel1.Controls.Add(this.dtpBooking);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvBooking);
            this.panel1.Controls.Add(this.pictureBox12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(245, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 769);
            this.panel1.TabIndex = 81;
            // 
            // dgvLearner
            // 
            this.dgvLearner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLearner.AutoGenerateColumns = false;
            this.dgvLearner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLearner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLearner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn1,
            this.bookingDateDataGridViewTextBoxColumn1,
            this.bookingStartTimeDataGridViewTextBoxColumn1,
            this.bookingEndTimeDataGridViewTextBoxColumn1,
            this.bookingStatusDataGridViewTextBoxColumn1,
            this.learnerIDDataGridViewTextBoxColumn1,
            this.codeTypeDataGridViewTextBoxColumn1,
            this.vehicleIDDataGridViewTextBoxColumn1,
            this.employeeIDDataGridViewTextBoxColumn1,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeSurnameDataGridViewTextBoxColumn,
            this.learnerNameDataGridViewTextBoxColumn,
            this.learnerSurnameDataGridViewTextBoxColumn,
            this.vehicleMakeDataGridViewTextBoxColumn,
            this.vehicleModelDataGridViewTextBoxColumn});
            this.dgvLearner.DataSource = this.tblBookingInnerJoinBindingSource;
            this.dgvLearner.Location = new System.Drawing.Point(383, 555);
            this.dgvLearner.Name = "dgvLearner";
            this.dgvLearner.RowHeadersWidth = 51;
            this.dgvLearner.RowTemplate.Height = 24;
            this.dgvLearner.Size = new System.Drawing.Size(867, 198);
            this.dgvLearner.TabIndex = 109;
            // 
            // dsBookingSystem
            // 
            this.dsBookingSystem.DataSetName = "WstGrp2DataSet";
            this.dsBookingSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nudEndTime
            // 
            this.nudEndTime.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.nudEndTime.Location = new System.Drawing.Point(209, 133);
            this.nudEndTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudEndTime.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.nudEndTime.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudEndTime.Name = "nudEndTime";
            this.nudEndTime.Size = new System.Drawing.Size(120, 34);
            this.nudEndTime.TabIndex = 108;
            this.nudEndTime.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // nudStartTime
            // 
            this.nudStartTime.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.nudStartTime.Location = new System.Drawing.Point(21, 133);
            this.nudStartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudStartTime.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudStartTime.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudStartTime.Name = "nudStartTime";
            this.nudStartTime.Size = new System.Drawing.Size(120, 34);
            this.nudStartTime.TabIndex = 107;
            this.nudStartTime.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(727, 510);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(375, 34);
            this.dateTimePicker1.TabIndex = 106;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkBlue;
            this.label17.Location = new System.Drawing.Point(535, 515);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 28);
            this.label17.TabIndex = 105;
            this.label17.Text = "Search by date";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.Location = new System.Drawing.Point(131, 617);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 49);
            this.btnUpdate.TabIndex = 80;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDelete.Location = new System.Drawing.Point(242, 617);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 49);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnClear.Location = new System.Drawing.Point(131, 674);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 49);
            this.btnClear.TabIndex = 78;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.Location = new System.Drawing.Point(20, 617);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 49);
            this.btnAdd.TabIndex = 77;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxVehicleID
            // 
            this.cbxVehicleID.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.cbxVehicleID.FormattingEnabled = true;
            this.cbxVehicleID.Location = new System.Drawing.Point(19, 552);
            this.cbxVehicleID.Margin = new System.Windows.Forms.Padding(4);
            this.cbxVehicleID.Name = "cbxVehicleID";
            this.cbxVehicleID.Size = new System.Drawing.Size(310, 31);
            this.cbxVehicleID.TabIndex = 76;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(21, 520);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 28);
            this.label15.TabIndex = 75;
            this.label15.Text = "VehicleID";
            // 
            // cbxEmployeeID
            // 
            this.cbxEmployeeID.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.cbxEmployeeID.FormattingEnabled = true;
            this.cbxEmployeeID.Location = new System.Drawing.Point(19, 485);
            this.cbxEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmployeeID.Name = "cbxEmployeeID";
            this.cbxEmployeeID.Size = new System.Drawing.Size(310, 31);
            this.cbxEmployeeID.TabIndex = 74;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkBlue;
            this.label16.Location = new System.Drawing.Point(16, 451);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 28);
            this.label16.TabIndex = 73;
            this.label16.Text = "EmployeeID";
            // 
            // cbxLearnerID
            // 
            this.cbxLearnerID.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.cbxLearnerID.FormattingEnabled = true;
            this.cbxLearnerID.Location = new System.Drawing.Point(19, 418);
            this.cbxLearnerID.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLearnerID.Name = "cbxLearnerID";
            this.cbxLearnerID.Size = new System.Drawing.Size(310, 31);
            this.cbxLearnerID.TabIndex = 72;
            this.cbxLearnerID.SelectedIndexChanged += new System.EventHandler(this.cbxLearnerID_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(16, 384);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 28);
            this.label13.TabIndex = 71;
            this.label13.Text = "LearnerID";
            // 
            // cbxLessonCodes
            // 
            this.cbxLessonCodes.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.cbxLessonCodes.FormattingEnabled = true;
            this.cbxLessonCodes.Location = new System.Drawing.Point(19, 352);
            this.cbxLessonCodes.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLessonCodes.Name = "cbxLessonCodes";
            this.cbxLessonCodes.Size = new System.Drawing.Size(167, 31);
            this.cbxLessonCodes.TabIndex = 70;
            this.cbxLessonCodes.SelectedIndexChanged += new System.EventHandler(this.cbxLessonCodes_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(13, 320);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 28);
            this.label12.TabIndex = 69;
            this.label12.Text = "Lesson Codes";
            // 
            // cbxBookingStatus
            // 
            this.cbxBookingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBookingStatus.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.cbxBookingStatus.FormattingEnabled = true;
            this.cbxBookingStatus.Items.AddRange(new object[] {
            "Not Complete",
            "Complete"});
            this.cbxBookingStatus.Location = new System.Drawing.Point(21, 270);
            this.cbxBookingStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbxBookingStatus.Name = "cbxBookingStatus";
            this.cbxBookingStatus.Size = new System.Drawing.Size(164, 36);
            this.cbxBookingStatus.TabIndex = 66;
            // 
            // dtpBooking
            // 
            this.dtpBooking.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.dtpBooking.Location = new System.Drawing.Point(21, 202);
            this.dtpBooking.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBooking.Name = "dtpBooking";
            this.dtpBooking.Size = new System.Drawing.Size(353, 34);
            this.dtpBooking.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(16, 240);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 28);
            this.label9.TabIndex = 57;
            this.label9.Text = "Booking Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(21, 102);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 28);
            this.label11.TabIndex = 53;
            this.label11.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 53;
            this.label4.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(19, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 55;
            this.label6.Text = "Booking Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(204, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 54;
            this.label2.Text = "End Time";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(204, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 54;
            this.label5.Text = "End Time";
            // 
            // dgvBooking
            // 
            this.dgvBooking.AllowUserToAddRows = false;
            this.dgvBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooking.AutoGenerateColumns = false;
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.bookingStartTimeDataGridViewTextBoxColumn,
            this.bookingEndTimeDataGridViewTextBoxColumn,
            this.bookingStatusDataGridViewTextBoxColumn,
            this.codeTypeDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.learnerIDDataGridViewTextBoxColumn});
            this.dgvBooking.DataSource = this.tblBookingBindingSource;
            this.dgvBooking.Location = new System.Drawing.Point(383, 85);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.Size = new System.Drawing.Size(867, 405);
            this.dgvBooking.TabIndex = 36;
            this.dgvBooking.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBooking_RowHeaderMouseClick);
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn.Width = 99;
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
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.Width = 94;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 111;
            // 
            // learnerIDDataGridViewTextBoxColumn
            // 
            this.learnerIDDataGridViewTextBoxColumn.DataPropertyName = "LearnerID";
            this.learnerIDDataGridViewTextBoxColumn.HeaderText = "LearnerID";
            this.learnerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerIDDataGridViewTextBoxColumn.Name = "learnerIDDataGridViewTextBoxColumn";
            this.learnerIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // tblBookingBindingSource
            // 
            this.tblBookingBindingSource.DataMember = "tblBooking";
            this.tblBookingBindingSource.DataSource = this.dsBookingSystem;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(18, 21);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(67, 62);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 45;
            this.pictureBox12.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ebrima", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(767, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 28);
            this.label8.TabIndex = 35;
            this.label8.Text = "Booking List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(99, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Manage Booking";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(99, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Manage Booking";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 1059);
            this.panel2.TabIndex = 82;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.logo_transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(21, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 144);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 933);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Log out";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.log_out;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(40, 832);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(106, 97);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.image_removebg_preview__13_;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(21, 210);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(147, 94);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // taBooking
            // 
            this.taBooking.ClearBeforeFill = true;
            // 
            // taEmployee
            // 
            this.taEmployee.ClearBeforeFill = true;
            // 
            // taVehicle
            // 
            this.taVehicle.ClearBeforeFill = true;
            // 
            // taLessonCode
            // 
            this.taLessonCode.ClearBeforeFill = true;
            // 
            // taLearner
            // 
            this.taLearner.ClearBeforeFill = true;
            // 
            // taBookingInnerJoin
            // 
            this.taBookingInnerJoin.ClearBeforeFill = true;
            // 
            // taUnavailableSlot
            // 
            this.taUnavailableSlot.ClearBeforeFill = true;
            // 
            // tblBookingInnerJoinBindingSource
            // 
            this.tblBookingInnerJoinBindingSource.DataMember = "tblBookingInnerJoin";
            this.tblBookingInnerJoinBindingSource.DataSource = this.dsBookingSystem;
            // 
            // bookingIDDataGridViewTextBoxColumn1
            // 
            this.bookingIDDataGridViewTextBoxColumn1.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn1.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bookingIDDataGridViewTextBoxColumn1.Name = "bookingIDDataGridViewTextBoxColumn1";
            this.bookingIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bookingIDDataGridViewTextBoxColumn1.Width = 99;
            // 
            // bookingDateDataGridViewTextBoxColumn1
            // 
            this.bookingDateDataGridViewTextBoxColumn1.DataPropertyName = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn1.HeaderText = "Booking_Date";
            this.bookingDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bookingDateDataGridViewTextBoxColumn1.Name = "bookingDateDataGridViewTextBoxColumn1";
            this.bookingDateDataGridViewTextBoxColumn1.Width = 122;
            // 
            // bookingStartTimeDataGridViewTextBoxColumn1
            // 
            this.bookingStartTimeDataGridViewTextBoxColumn1.DataPropertyName = "Booking_StartTime";
            this.bookingStartTimeDataGridViewTextBoxColumn1.HeaderText = "Booking_StartTime";
            this.bookingStartTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bookingStartTimeDataGridViewTextBoxColumn1.Name = "bookingStartTimeDataGridViewTextBoxColumn1";
            this.bookingStartTimeDataGridViewTextBoxColumn1.Width = 151;
            // 
            // bookingEndTimeDataGridViewTextBoxColumn1
            // 
            this.bookingEndTimeDataGridViewTextBoxColumn1.DataPropertyName = "Booking_EndTime";
            this.bookingEndTimeDataGridViewTextBoxColumn1.HeaderText = "Booking_EndTime";
            this.bookingEndTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bookingEndTimeDataGridViewTextBoxColumn1.Name = "bookingEndTimeDataGridViewTextBoxColumn1";
            this.bookingEndTimeDataGridViewTextBoxColumn1.Width = 148;
            // 
            // bookingStatusDataGridViewTextBoxColumn1
            // 
            this.bookingStatusDataGridViewTextBoxColumn1.DataPropertyName = "Booking_Status";
            this.bookingStatusDataGridViewTextBoxColumn1.HeaderText = "Booking_Status";
            this.bookingStatusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bookingStatusDataGridViewTextBoxColumn1.Name = "bookingStatusDataGridViewTextBoxColumn1";
            this.bookingStatusDataGridViewTextBoxColumn1.Width = 130;
            // 
            // learnerIDDataGridViewTextBoxColumn1
            // 
            this.learnerIDDataGridViewTextBoxColumn1.DataPropertyName = "LearnerID";
            this.learnerIDDataGridViewTextBoxColumn1.HeaderText = "LearnerID";
            this.learnerIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.learnerIDDataGridViewTextBoxColumn1.Name = "learnerIDDataGridViewTextBoxColumn1";
            this.learnerIDDataGridViewTextBoxColumn1.Width = 95;
            // 
            // codeTypeDataGridViewTextBoxColumn1
            // 
            this.codeTypeDataGridViewTextBoxColumn1.DataPropertyName = "Code_Type";
            this.codeTypeDataGridViewTextBoxColumn1.HeaderText = "Code_Type";
            this.codeTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.codeTypeDataGridViewTextBoxColumn1.Name = "codeTypeDataGridViewTextBoxColumn1";
            this.codeTypeDataGridViewTextBoxColumn1.Width = 108;
            // 
            // vehicleIDDataGridViewTextBoxColumn1
            // 
            this.vehicleIDDataGridViewTextBoxColumn1.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn1.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.vehicleIDDataGridViewTextBoxColumn1.Name = "vehicleIDDataGridViewTextBoxColumn1";
            this.vehicleIDDataGridViewTextBoxColumn1.Width = 94;
            // 
            // employeeIDDataGridViewTextBoxColumn1
            // 
            this.employeeIDDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn1.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn1.Name = "employeeIDDataGridViewTextBoxColumn1";
            this.employeeIDDataGridViewTextBoxColumn1.Width = 111;
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
            // ManageBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.Background_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ManageBooking";
            this.Text = "ManageBooking";
            this.Load += new System.EventHandler(this.ManageBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookingInnerJoinBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLearner;
        private System.Windows.Forms.NumericUpDown nudEndTime;
        private System.Windows.Forms.NumericUpDown nudStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxVehicleID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxEmployeeID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxLearnerID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxLessonCodes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxBookingStatus;
        private System.Windows.Forms.DateTimePicker dtpBooking;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private WstGrp2DataSetTableAdapters.tblBookingTableAdapter taBooking;
        private WstGrp2DataSet dsBookingSystem;
        private WstGrp2DataSetTableAdapters.tblEmployeeTableAdapter taEmployee;
        private WstGrp2DataSetTableAdapters.tblVehicleTableAdapter taVehicle;
        private WstGrp2DataSetTableAdapters.tblLessonCodeTableAdapter taLessonCode;
        private WstGrp2DataSetTableAdapters.tblLearnerTableAdapter taLearner;
        private WstGrp2DataSetTableAdapters.tblBookingInnerJoinTableAdapter taBookingInnerJoin;
        private WstGrp2DataSetTableAdapters.tblUnavailableSlotTableAdapter taUnavailableSlot;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblBookingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStartTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingEndTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblBookingInnerJoinBindingSource;
    }
}