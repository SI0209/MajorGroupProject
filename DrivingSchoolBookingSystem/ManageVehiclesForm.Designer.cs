namespace DrivingSchoolBookingSystem
{
    partial class ManageVehiclesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEngineNum = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbVehicleStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleRegNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleEngineNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblVehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp2DataSet = new DrivingSchoolBookingSystem.WstGrp2DataSet();
            this.taVehicle = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblVehicleTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.Background_final;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtEngineNum);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dgvVehicles);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbVehicleStatus);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbSize);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtModel);
            this.panel1.Controls.Add(this.txtMake);
            this.panel1.Controls.Add(this.txtRegNum);
            this.panel1.Controls.Add(this.txtNumberPlate);
            this.panel1.Location = new System.Drawing.Point(185, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 838);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(453, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 19);
            this.label11.TabIndex = 44;
            this.label11.Text = "Search Vehicle By Make";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Image = global::DrivingSchoolBookingSystem.Properties.Resources.dark_blue;
            this.btnClear.Location = new System.Drawing.Point(537, 796);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(191, 43);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(19, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "Vehicle Engine Number";
            // 
            // txtEngineNum
            // 
            this.txtEngineNum.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.txtEngineNum.Location = new System.Drawing.Point(22, 318);
            this.txtEngineNum.Name = "txtEngineNum";
            this.txtEngineNum.Size = new System.Drawing.Size(130, 26);
            this.txtEngineNum.TabIndex = 41;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(663, 180);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 26);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(549, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "MANAGE VEHICLES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DrivingSchoolBookingSystem.Properties.Resources.vehicle;
            this.pictureBox1.Location = new System.Drawing.Point(410, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AutoGenerateColumns = false;
            this.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.vehicleRegNumDataGridViewTextBoxColumn,
            this.vehicleEngineNumDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.vehicleSizeDataGridViewTextBoxColumn,
            this.vehicleStatusDataGridViewTextBoxColumn});
            this.dgvVehicles.DataSource = this.tblVehicleBindingSource;
            this.dgvVehicles.Location = new System.Drawing.Point(303, 235);
            this.dgvVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.RowHeadersWidth = 51;
            this.dgvVehicles.Size = new System.Drawing.Size(832, 554);
            this.dgvVehicles.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(19, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Vehicle Make";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Image = global::DrivingSchoolBookingSystem.Properties.Resources.dark_blue;
            this.btnDelete.Location = new System.Drawing.Point(7, 746);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 43);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "DELETE VEHICLE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Image = global::DrivingSchoolBookingSystem.Properties.Resources.dark_blue;
            this.btnUpdate.Location = new System.Drawing.Point(7, 697);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 43);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "UPDATE VEHICLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Image = global::DrivingSchoolBookingSystem.Properties.Resources.dark_blue;
            this.btnAdd.Location = new System.Drawing.Point(7, 638);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 43);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "ADD NEW VEHICLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(19, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Vehicle Status";
            // 
            // cmbVehicleStatus
            // 
            this.cmbVehicleStatus.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.cmbVehicleStatus.FormattingEnabled = true;
            this.cmbVehicleStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cmbVehicleStatus.Location = new System.Drawing.Point(23, 577);
            this.cmbVehicleStatus.Name = "cmbVehicleStatus";
            this.cmbVehicleStatus.Size = new System.Drawing.Size(121, 27);
            this.cmbVehicleStatus.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(23, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vehicle Size";
            // 
            // cmbSize
            // 
            this.cmbSize.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbSize.Location = new System.Drawing.Point(25, 500);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 27);
            this.cmbSize.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(19, 408);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vehicle Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vehicle Registration Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(23, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vehicle Number Plate";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.txtModel.Location = new System.Drawing.Point(23, 440);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(129, 26);
            this.txtModel.TabIndex = 3;
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.txtMake.Location = new System.Drawing.Point(22, 379);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(130, 26);
            this.txtMake.TabIndex = 2;
            // 
            // txtRegNum
            // 
            this.txtRegNum.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.txtRegNum.Location = new System.Drawing.Point(27, 238);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.Size = new System.Drawing.Size(130, 26);
            this.txtRegNum.TabIndex = 1;
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.txtNumberPlate.Location = new System.Drawing.Point(29, 171);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(130, 26);
            this.txtNumberPlate.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 838);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.logo_transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(30, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 105);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 766);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Log out";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(72, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Home";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.log_out;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(49, 684);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 79);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.home_icon;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(42, 163);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.button;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(30, 135);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(116, 85);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VehicleID";
            this.dataGridViewTextBoxColumn1.HeaderText = "VehicleID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vehicle_NumberPlate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vehicle_NumberPlate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // vehicleRegNumDataGridViewTextBoxColumn
            // 
            this.vehicleRegNumDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_RegNum";
            this.vehicleRegNumDataGridViewTextBoxColumn.HeaderText = "Vehicle_RegNum";
            this.vehicleRegNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleRegNumDataGridViewTextBoxColumn.Name = "vehicleRegNumDataGridViewTextBoxColumn";
            this.vehicleRegNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleEngineNumDataGridViewTextBoxColumn
            // 
            this.vehicleEngineNumDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_EngineNum";
            this.vehicleEngineNumDataGridViewTextBoxColumn.HeaderText = "Vehicle_EngineNum";
            this.vehicleEngineNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleEngineNumDataGridViewTextBoxColumn.Name = "vehicleEngineNumDataGridViewTextBoxColumn";
            this.vehicleEngineNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vehicle_Make";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vehicle_Make";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vehicle_Model";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vehicle_Model";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // vehicleSizeDataGridViewTextBoxColumn
            // 
            this.vehicleSizeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Size";
            this.vehicleSizeDataGridViewTextBoxColumn.HeaderText = "Vehicle_Size";
            this.vehicleSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleSizeDataGridViewTextBoxColumn.Name = "vehicleSizeDataGridViewTextBoxColumn";
            this.vehicleSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleStatusDataGridViewTextBoxColumn
            // 
            this.vehicleStatusDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Status";
            this.vehicleStatusDataGridViewTextBoxColumn.HeaderText = "Vehicle_Status";
            this.vehicleStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleStatusDataGridViewTextBoxColumn.Name = "vehicleStatusDataGridViewTextBoxColumn";
            this.vehicleStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblVehicleBindingSource
            // 
            this.tblVehicleBindingSource.DataMember = "tblVehicle";
            this.tblVehicleBindingSource.DataSource = this.wstGrp2DataSet;
            // 
            // wstGrp2DataSet
            // 
            this.wstGrp2DataSet.DataSetName = "WstGrp2DataSet";
            this.wstGrp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taVehicle
            // 
            this.taVehicle.ClearBeforeFill = true;
            // 
            // ManageVehiclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.Background_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 839);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageVehiclesForm";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.TextBox txtNumberPlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbVehicleStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource tblVehicleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNumberPlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleEngineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleMileageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleEngineNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleStatusDataGridViewTextBoxColumn;
        private DrivingSchoolBookingSystem.WstGrp2DataSet wstGrp2DataSet;
        private DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblVehicleTableAdapter taVehicle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEngineNum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label11;
    }
}

