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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvLearner = new System.Windows.Forms.DataGridView();
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
            this.txtFeeDue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtSearch);
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
            this.panel1.Controls.Add(this.txtFeeDue);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTotalCost);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvBooking);
            this.panel1.Controls.Add(this.pictureBox12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(47, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 769);
            this.panel1.TabIndex = 81;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label14.Location = new System.Drawing.Point(500, 508);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(278, 28);
            this.label14.TabIndex = 111;
            this.label14.Text = "Search for Learner by Surname";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSearch.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(812, 505);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(283, 34);
            this.txtSearch.TabIndex = 110;
            // 
            // dgvLearner
            // 
            this.dgvLearner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLearner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLearner.Location = new System.Drawing.Point(383, 555);
            this.dgvLearner.Name = "dgvLearner";
            this.dgvLearner.RowHeadersWidth = 51;
            this.dgvLearner.RowTemplate.Height = 24;
            this.dgvLearner.Size = new System.Drawing.Size(1033, 198);
            this.dgvLearner.TabIndex = 109;
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
            this.dateTimePicker1.Location = new System.Drawing.Point(619, 18);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(375, 34);
            this.dateTimePicker1.TabIndex = 106;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label17.Location = new System.Drawing.Point(427, 23);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 28);
            this.label17.TabIndex = 105;
            this.label17.Text = "Search by date";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnUpdate.Location = new System.Drawing.Point(161, 655);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 49);
            this.btnUpdate.TabIndex = 80;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnDelete.Location = new System.Drawing.Point(273, 656);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 49);
            this.btnDelete.TabIndex = 79;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnClear.Location = new System.Drawing.Point(161, 716);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 49);
            this.btnClear.TabIndex = 78;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnAdd.Location = new System.Drawing.Point(37, 656);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 49);
            this.btnAdd.TabIndex = 77;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbxVehicleID
            // 
            this.cbxVehicleID.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.cbxVehicleID.FormattingEnabled = true;
            this.cbxVehicleID.Location = new System.Drawing.Point(19, 612);
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
            this.label15.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label15.Location = new System.Drawing.Point(21, 580);
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
            this.cbxEmployeeID.Location = new System.Drawing.Point(19, 545);
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
            this.label16.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label16.Location = new System.Drawing.Point(16, 511);
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
            this.cbxLearnerID.Location = new System.Drawing.Point(19, 478);
            this.cbxLearnerID.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLearnerID.Name = "cbxLearnerID";
            this.cbxLearnerID.Size = new System.Drawing.Size(310, 31);
            this.cbxLearnerID.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label13.Location = new System.Drawing.Point(16, 444);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 28);
            this.label13.TabIndex = 71;
            this.label13.Text = "LearnerID";
            // 
            // cbxLessonCodes
            // 
            this.cbxLessonCodes.DisplayMember = "Code_Type";
            this.cbxLessonCodes.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.cbxLessonCodes.FormattingEnabled = true;
            this.cbxLessonCodes.Location = new System.Drawing.Point(19, 412);
            this.cbxLessonCodes.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLessonCodes.Name = "cbxLessonCodes";
            this.cbxLessonCodes.Size = new System.Drawing.Size(167, 31);
            this.cbxLessonCodes.TabIndex = 70;
            this.cbxLessonCodes.ValueMember = "Code_Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label12.Location = new System.Drawing.Point(13, 380);
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
            // txtFeeDue
            // 
            this.txtFeeDue.AcceptsReturn = true;
            this.txtFeeDue.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeeDue.Location = new System.Drawing.Point(209, 342);
            this.txtFeeDue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeeDue.Name = "txtFeeDue";
            this.txtFeeDue.ReadOnly = true;
            this.txtFeeDue.Size = new System.Drawing.Size(167, 34);
            this.txtFeeDue.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label10.Location = new System.Drawing.Point(207, 313);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 28);
            this.label10.TabIndex = 63;
            this.label10.Text = "Fee Due";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(21, 342);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(164, 34);
            this.txtTotalCost.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label9.Location = new System.Drawing.Point(16, 240);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 28);
            this.label9.TabIndex = 57;
            this.label9.Text = "Booking Status";
            // 
            // label4
            // 
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label7.Location = new System.Drawing.Point(21, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 56;
            this.label7.Text = "Total Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(19, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 55;
            this.label6.Text = "Booking Date";
            // 
            // label5
            // 
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
            this.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(383, 85);
            this.dgvBooking.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 51;
            this.dgvBooking.Size = new System.Drawing.Size(1033, 405);
            this.dgvBooking.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ebrima", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label8.Location = new System.Drawing.Point(769, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 28);
            this.label8.TabIndex = 35;
            this.label8.Text = "Booking List";
            // 
            // label3
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(99, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Manage Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(204, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 54;
            this.label2.Text = "End Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label11.Location = new System.Drawing.Point(21, 102);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 28);
            this.label11.TabIndex = 53;
            this.label11.Text = "Start Time";
            // 
            // ManageBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.Background_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1780, 1055);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ManageBooking";
            this.Text = "ManageBooking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSearch;
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
        private System.Windows.Forms.TextBox txtFeeDue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}