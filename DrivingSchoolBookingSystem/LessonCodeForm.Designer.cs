namespace DrivingSchoolBookingSystem
{
    partial class LessonCodeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wstGrp2DataSet = new DrivingSchoolBookingSystem.WstGrp2DataSet();
            this.tblLessonCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLessonCodeTableAdapter = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblLessonCodeTableAdapter();
            this.tableAdapterManager = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.TableAdapterManager();
            this.codeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePricePerHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tblVehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblVehicleTableAdapter = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblVehicleTableAdapter();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNumberPlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleRegNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleEngineNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonCodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(85, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 458);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Lesson Code";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 36);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price Per Hour";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeTypeDataGridViewTextBoxColumn,
            this.codePricePerHourDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblLessonCodeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(207, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(520, 162);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // wstGrp2DataSet
            // 
            this.wstGrp2DataSet.DataSetName = "WstGrp2DataSet";
            this.wstGrp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLessonCodeBindingSource
            // 
            this.tblLessonCodeBindingSource.DataMember = "tblLessonCode";
            this.tblLessonCodeBindingSource.DataSource = this.wstGrp2DataSet;
            // 
            // tblLessonCodeTableAdapter
            // 
            this.tblLessonCodeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBookingTableAdapter = null;
            this.tableAdapterManager.tblEmployeeTableAdapter = null;
            this.tableAdapterManager.tblLearnerTableAdapter = null;
            this.tableAdapterManager.tblLessonCodeTableAdapter = this.tblLessonCodeTableAdapter;
            this.tableAdapterManager.tblUnavailableSlotTableAdapter = null;
            this.tableAdapterManager.tblVehicleTableAdapter = this.tblVehicleTableAdapter;
            this.tableAdapterManager.UpdateOrder = DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codeTypeDataGridViewTextBoxColumn
            // 
            this.codeTypeDataGridViewTextBoxColumn.DataPropertyName = "Code_Type";
            this.codeTypeDataGridViewTextBoxColumn.HeaderText = "Code_Type";
            this.codeTypeDataGridViewTextBoxColumn.Name = "codeTypeDataGridViewTextBoxColumn";
            // 
            // codePricePerHourDataGridViewTextBoxColumn
            // 
            this.codePricePerHourDataGridViewTextBoxColumn.DataPropertyName = "Code_PricePerHour";
            this.codePricePerHourDataGridViewTextBoxColumn.HeaderText = "Code_PricePerHour";
            this.codePricePerHourDataGridViewTextBoxColumn.Name = "codePricePerHourDataGridViewTextBoxColumn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lesson Codes";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Available Vehicles";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIDDataGridViewTextBoxColumn,
            this.vehicleNumberPlateDataGridViewTextBoxColumn,
            this.vehicleRegNumDataGridViewTextBoxColumn,
            this.vehicleEngineNumDataGridViewTextBoxColumn,
            this.vehicleMakeDataGridViewTextBoxColumn,
            this.vehicleModelDataGridViewTextBoxColumn,
            this.vehicleSizeDataGridViewTextBoxColumn,
            this.vehicleStatusDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblVehicleBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(207, 264);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(520, 177);
            this.dataGridView2.TabIndex = 13;
            // 
            // tblVehicleBindingSource
            // 
            this.tblVehicleBindingSource.DataMember = "tblVehicle";
            this.tblVehicleBindingSource.DataSource = this.wstGrp2DataSet;
            // 
            // tblVehicleTableAdapter
            // 
            this.tblVehicleTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleNumberPlateDataGridViewTextBoxColumn
            // 
            this.vehicleNumberPlateDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_NumberPlate";
            this.vehicleNumberPlateDataGridViewTextBoxColumn.HeaderText = "Vehicle_NumberPlate";
            this.vehicleNumberPlateDataGridViewTextBoxColumn.Name = "vehicleNumberPlateDataGridViewTextBoxColumn";
            // 
            // vehicleRegNumDataGridViewTextBoxColumn
            // 
            this.vehicleRegNumDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_RegNum";
            this.vehicleRegNumDataGridViewTextBoxColumn.HeaderText = "Vehicle_RegNum";
            this.vehicleRegNumDataGridViewTextBoxColumn.Name = "vehicleRegNumDataGridViewTextBoxColumn";
            // 
            // vehicleEngineNumDataGridViewTextBoxColumn
            // 
            this.vehicleEngineNumDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_EngineNum";
            this.vehicleEngineNumDataGridViewTextBoxColumn.HeaderText = "Vehicle_EngineNum";
            this.vehicleEngineNumDataGridViewTextBoxColumn.Name = "vehicleEngineNumDataGridViewTextBoxColumn";
            // 
            // vehicleMakeDataGridViewTextBoxColumn
            // 
            this.vehicleMakeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Make";
            this.vehicleMakeDataGridViewTextBoxColumn.HeaderText = "Vehicle_Make";
            this.vehicleMakeDataGridViewTextBoxColumn.Name = "vehicleMakeDataGridViewTextBoxColumn";
            // 
            // vehicleModelDataGridViewTextBoxColumn
            // 
            this.vehicleModelDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Model";
            this.vehicleModelDataGridViewTextBoxColumn.HeaderText = "Vehicle_Model";
            this.vehicleModelDataGridViewTextBoxColumn.Name = "vehicleModelDataGridViewTextBoxColumn";
            // 
            // vehicleSizeDataGridViewTextBoxColumn
            // 
            this.vehicleSizeDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Size";
            this.vehicleSizeDataGridViewTextBoxColumn.HeaderText = "Vehicle_Size";
            this.vehicleSizeDataGridViewTextBoxColumn.Name = "vehicleSizeDataGridViewTextBoxColumn";
            // 
            // vehicleStatusDataGridViewTextBoxColumn
            // 
            this.vehicleStatusDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_Status";
            this.vehicleStatusDataGridViewTextBoxColumn.HeaderText = "Vehicle_Status";
            this.vehicleStatusDataGridViewTextBoxColumn.Name = "vehicleStatusDataGridViewTextBoxColumn";
            // 
            // LessonCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 507);
            this.Controls.Add(this.panel1);
            this.Name = "LessonCodeForm";
            this.Text = "LessonCodeForm";
            this.Load += new System.EventHandler(this.LessonCodeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonCodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVehicleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private WstGrp2DataSet wstGrp2DataSet;
        private System.Windows.Forms.BindingSource tblLessonCodeBindingSource;
        private WstGrp2DataSetTableAdapters.tblLessonCodeTableAdapter tblLessonCodeTableAdapter;
        private WstGrp2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePricePerHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private WstGrp2DataSetTableAdapters.tblVehicleTableAdapter tblVehicleTableAdapter;
        private System.Windows.Forms.BindingSource tblVehicleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNumberPlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleEngineNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleMakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleStatusDataGridViewTextBoxColumn;
    }
}