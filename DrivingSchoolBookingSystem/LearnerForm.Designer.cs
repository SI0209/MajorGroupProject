namespace DrivingSchoolBookingSystem
{
    partial class LearnerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.learnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerIDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerRaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerCellNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerStreetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerSuburbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerLearnersIssueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learnerLearnersExpiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLearnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp2DataSet = new BookingSystem.WstGrp2DataSet();
            this.wstGrp2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLearnerTableAdapter = new BookingSystem.WstGrp2DataSetTableAdapters.tblLearnerTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLearnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp2DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(493, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Learners";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.learnerIDDataGridViewTextBoxColumn,
            this.learnerNameDataGridViewTextBoxColumn,
            this.learnerSurnameDataGridViewTextBoxColumn,
            this.learnerIDNumberDataGridViewTextBoxColumn,
            this.learnerAgeDataGridViewTextBoxColumn,
            this.learnerGenderDataGridViewTextBoxColumn,
            this.learnerRaceDataGridViewTextBoxColumn,
            this.learnerCellNumberDataGridViewTextBoxColumn,
            this.learnerStreetAddressDataGridViewTextBoxColumn,
            this.learnerSuburbDataGridViewTextBoxColumn,
            this.learnerLearnersIssueDateDataGridViewTextBoxColumn,
            this.learnerLearnersExpiryDateDataGridViewTextBoxColumn,
            this.codeTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblLearnerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(490, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(671, 190);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // learnerIDDataGridViewTextBoxColumn
            // 
            this.learnerIDDataGridViewTextBoxColumn.DataPropertyName = "LearnerID";
            this.learnerIDDataGridViewTextBoxColumn.HeaderText = "LearnerID";
            this.learnerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerIDDataGridViewTextBoxColumn.Name = "learnerIDDataGridViewTextBoxColumn";
            this.learnerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.learnerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // learnerNameDataGridViewTextBoxColumn
            // 
            this.learnerNameDataGridViewTextBoxColumn.DataPropertyName = "Learner_Name";
            this.learnerNameDataGridViewTextBoxColumn.HeaderText = "Learner_Name";
            this.learnerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerNameDataGridViewTextBoxColumn.Name = "learnerNameDataGridViewTextBoxColumn";
            this.learnerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // learnerSurnameDataGridViewTextBoxColumn
            // 
            this.learnerSurnameDataGridViewTextBoxColumn.DataPropertyName = "Learner_Surname";
            this.learnerSurnameDataGridViewTextBoxColumn.HeaderText = "Learner_Surname";
            this.learnerSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerSurnameDataGridViewTextBoxColumn.Name = "learnerSurnameDataGridViewTextBoxColumn";
            this.learnerSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // learnerIDNumberDataGridViewTextBoxColumn
            // 
            this.learnerIDNumberDataGridViewTextBoxColumn.DataPropertyName = "Learner_IDNumber";
            this.learnerIDNumberDataGridViewTextBoxColumn.HeaderText = "Learner_IDNumber";
            this.learnerIDNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerIDNumberDataGridViewTextBoxColumn.Name = "learnerIDNumberDataGridViewTextBoxColumn";
            this.learnerIDNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // learnerAgeDataGridViewTextBoxColumn
            // 
            this.learnerAgeDataGridViewTextBoxColumn.DataPropertyName = "Learner_Age";
            this.learnerAgeDataGridViewTextBoxColumn.HeaderText = "Learner_Age";
            this.learnerAgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerAgeDataGridViewTextBoxColumn.Name = "learnerAgeDataGridViewTextBoxColumn";
            this.learnerAgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // learnerGenderDataGridViewTextBoxColumn
            // 
            this.learnerGenderDataGridViewTextBoxColumn.DataPropertyName = "Learner_Gender";
            this.learnerGenderDataGridViewTextBoxColumn.HeaderText = "Learner_Gender";
            this.learnerGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerGenderDataGridViewTextBoxColumn.Name = "learnerGenderDataGridViewTextBoxColumn";
            this.learnerGenderDataGridViewTextBoxColumn.Width = 125;
            // 
            // learnerRaceDataGridViewTextBoxColumn
            // 
            this.learnerRaceDataGridViewTextBoxColumn.DataPropertyName = "Learner_Race";
            this.learnerRaceDataGridViewTextBoxColumn.HeaderText = "Learner_Race";
            this.learnerRaceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerRaceDataGridViewTextBoxColumn.Name = "learnerRaceDataGridViewTextBoxColumn";
            this.learnerRaceDataGridViewTextBoxColumn.Width = 125;
            // 
            // learnerCellNumberDataGridViewTextBoxColumn
            // 
            this.learnerCellNumberDataGridViewTextBoxColumn.DataPropertyName = "Learner_CellNumber";
            this.learnerCellNumberDataGridViewTextBoxColumn.HeaderText = "Learner_CellNumber";
            this.learnerCellNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerCellNumberDataGridViewTextBoxColumn.Name = "learnerCellNumberDataGridViewTextBoxColumn";
            this.learnerCellNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // learnerStreetAddressDataGridViewTextBoxColumn
            // 
            this.learnerStreetAddressDataGridViewTextBoxColumn.DataPropertyName = "Learner_StreetAddress";
            this.learnerStreetAddressDataGridViewTextBoxColumn.HeaderText = "Learner_StreetAddress";
            this.learnerStreetAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerStreetAddressDataGridViewTextBoxColumn.Name = "learnerStreetAddressDataGridViewTextBoxColumn";
            this.learnerStreetAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // learnerSuburbDataGridViewTextBoxColumn
            // 
            this.learnerSuburbDataGridViewTextBoxColumn.DataPropertyName = "Learner_Suburb";
            this.learnerSuburbDataGridViewTextBoxColumn.HeaderText = "Learner_Suburb";
            this.learnerSuburbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerSuburbDataGridViewTextBoxColumn.Name = "learnerSuburbDataGridViewTextBoxColumn";
            this.learnerSuburbDataGridViewTextBoxColumn.Width = 125;
            // 
            // learnerLearnersIssueDateDataGridViewTextBoxColumn
            // 
            this.learnerLearnersIssueDateDataGridViewTextBoxColumn.DataPropertyName = "Learner_LearnersIssueDate";
            this.learnerLearnersIssueDateDataGridViewTextBoxColumn.HeaderText = "Learner_LearnersIssueDate";
            this.learnerLearnersIssueDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerLearnersIssueDateDataGridViewTextBoxColumn.Name = "learnerLearnersIssueDateDataGridViewTextBoxColumn";
            this.learnerLearnersIssueDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // learnerLearnersExpiryDateDataGridViewTextBoxColumn
            // 
            this.learnerLearnersExpiryDateDataGridViewTextBoxColumn.DataPropertyName = "Learner_LearnersExpiryDate";
            this.learnerLearnersExpiryDateDataGridViewTextBoxColumn.HeaderText = "Learner_LearnersExpiryDate";
            this.learnerLearnersExpiryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.learnerLearnersExpiryDateDataGridViewTextBoxColumn.Name = "learnerLearnersExpiryDateDataGridViewTextBoxColumn";
            this.learnerLearnersExpiryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeTypeDataGridViewTextBoxColumn
            // 
            this.codeTypeDataGridViewTextBoxColumn.DataPropertyName = "Code_Type";
            this.codeTypeDataGridViewTextBoxColumn.HeaderText = "Code_Type";
            this.codeTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeTypeDataGridViewTextBoxColumn.Name = "codeTypeDataGridViewTextBoxColumn";
            this.codeTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblLearnerBindingSource
            // 
            this.tblLearnerBindingSource.DataMember = "tblLearner";
            this.tblLearnerBindingSource.DataSource = this.wstGrp2DataSet;
            // 
            // wstGrp2DataSet
            // 
            this.wstGrp2DataSet.DataSetName = "WstGrp2DataSet";
            this.wstGrp2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wstGrp2DataSetBindingSource
            // 
            this.wstGrp2DataSetBindingSource.DataSource = this.wstGrp2DataSet;
            this.wstGrp2DataSetBindingSource.Position = 0;
            // 
            // tblLearnerTableAdapter
            // 
            this.tblLearnerTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Num:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(153, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Age:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(153, 201);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 22);
            this.textBox4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(153, 242);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(162, 22);
            this.textBox5.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Race:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(153, 285);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(162, 22);
            this.textBox6.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Street Address:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(153, 328);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(162, 22);
            this.textBox7.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Suburb:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Durban",
            "PMB",
            "Verulam"});
            this.comboBox1.Location = new System.Drawing.Point(153, 373);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Issue Date:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 427);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 479);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Expiry Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(153, 477);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(162, 22);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Code Type:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "8",
            "10"});
            this.comboBox2.Location = new System.Drawing.Point(153, 520);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 24);
            this.comboBox2.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 575);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 41);
            this.button2.TabIndex = 26;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 575);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 41);
            this.button3.TabIndex = 27;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // LearnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DrivingSchoolBookingSystem.Properties.Resources.final_project_bg;
            this.ClientSize = new System.Drawing.Size(1154, 630);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "LearnerForm";
            this.Text = "LearnerForm";
            this.Load += new System.EventHandler(this.LearnerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLearnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp2DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource wstGrp2DataSetBindingSource;
        private BookingSystem.WstGrp2DataSet wstGrp2DataSet;
        private System.Windows.Forms.BindingSource tblLearnerBindingSource;
        private BookingSystem.WstGrp2DataSetTableAdapters.tblLearnerTableAdapter tblLearnerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerIDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerRaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerCellNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerStreetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerSuburbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerLearnersIssueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learnerLearnersExpiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}