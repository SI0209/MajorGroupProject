namespace DrivingSchoolBookingSystem
{
    partial class Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
            this.passwordUpdatetxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmpasswordtxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updatePasswordbtn = new System.Windows.Forms.Button();
            this.passwordformcheckboc = new System.Windows.Forms.CheckBox();
            this.clearbuttonpasswordform = new System.Windows.Forms.Button();
            this.backbtnpasswordform = new System.Windows.Forms.Button();
            this.taEmployee = new DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblEmployeeTableAdapter();
            this.dsBookingSystem = new DrivingSchoolBookingSystem.WstGrp2DataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsBookingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordUpdatetxtbox
            // 
            this.passwordUpdatetxtbox.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.passwordUpdatetxtbox.Location = new System.Drawing.Point(226, 223);
            this.passwordUpdatetxtbox.Name = "passwordUpdatetxtbox";
            this.passwordUpdatetxtbox.PasswordChar = '*';
            this.passwordUpdatetxtbox.Size = new System.Drawing.Size(294, 26);
            this.passwordUpdatetxtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(227, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Password";
            // 
            // confirmpasswordtxtbox
            // 
            this.confirmpasswordtxtbox.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.confirmpasswordtxtbox.Location = new System.Drawing.Point(226, 301);
            this.confirmpasswordtxtbox.Name = "confirmpasswordtxtbox";
            this.confirmpasswordtxtbox.PasswordChar = '*';
            this.confirmpasswordtxtbox.Size = new System.Drawing.Size(294, 26);
            this.confirmpasswordtxtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(227, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Password";
            // 
            // updatePasswordbtn
            // 
            this.updatePasswordbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updatePasswordbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updatePasswordbtn.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePasswordbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.updatePasswordbtn.Location = new System.Drawing.Point(298, 405);
            this.updatePasswordbtn.Name = "updatePasswordbtn";
            this.updatePasswordbtn.Size = new System.Drawing.Size(175, 46);
            this.updatePasswordbtn.TabIndex = 4;
            this.updatePasswordbtn.Text = "UPDATE";
            this.updatePasswordbtn.UseVisualStyleBackColor = false;
            this.updatePasswordbtn.Click += new System.EventHandler(this.updatePasswordbtn_Click);
            // 
            // passwordformcheckboc
            // 
            this.passwordformcheckboc.AutoSize = true;
            this.passwordformcheckboc.BackColor = System.Drawing.Color.Transparent;
            this.passwordformcheckboc.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordformcheckboc.Location = new System.Drawing.Point(583, 303);
            this.passwordformcheckboc.Name = "passwordformcheckboc";
            this.passwordformcheckboc.Size = new System.Drawing.Size(122, 23);
            this.passwordformcheckboc.TabIndex = 5;
            this.passwordformcheckboc.Text = "View Password";
            this.passwordformcheckboc.UseVisualStyleBackColor = false;
            this.passwordformcheckboc.CheckedChanged += new System.EventHandler(this.passwordformcheckboc_CheckedChanged);
            // 
            // clearbuttonpasswordform
            // 
            this.clearbuttonpasswordform.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearbuttonpasswordform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearbuttonpasswordform.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbuttonpasswordform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.clearbuttonpasswordform.Location = new System.Drawing.Point(626, 403);
            this.clearbuttonpasswordform.Name = "clearbuttonpasswordform";
            this.clearbuttonpasswordform.Size = new System.Drawing.Size(131, 48);
            this.clearbuttonpasswordform.TabIndex = 6;
            this.clearbuttonpasswordform.Text = "CLEAR";
            this.clearbuttonpasswordform.UseVisualStyleBackColor = false;
            this.clearbuttonpasswordform.Click += new System.EventHandler(this.clearbuttonpasswordform_Click);
            // 
            // backbtnpasswordform
            // 
            this.backbtnpasswordform.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbtnpasswordform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtnpasswordform.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtnpasswordform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.backbtnpasswordform.Location = new System.Drawing.Point(40, 403);
            this.backbtnpasswordform.Name = "backbtnpasswordform";
            this.backbtnpasswordform.Size = new System.Drawing.Size(126, 48);
            this.backbtnpasswordform.TabIndex = 7;
            this.backbtnpasswordform.Text = "BACK";
            this.backbtnpasswordform.UseVisualStyleBackColor = false;
            this.backbtnpasswordform.Click += new System.EventHandler(this.backbtnpasswordform_Click);
            // 
            // taEmployee
            // 
            this.taEmployee.ClearBeforeFill = true;
            // 
            // dsBookingSystem
            // 
            this.dsBookingSystem.DataSetName = "WstGrp2DataSet";
            this.dsBookingSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backbtnpasswordform);
            this.Controls.Add(this.clearbuttonpasswordform);
            this.Controls.Add(this.passwordformcheckboc);
            this.Controls.Add(this.updatePasswordbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmpasswordtxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordUpdatetxtbox);
            this.DoubleBuffered = true;
            this.Name = "Password";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBookingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordUpdatetxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmpasswordtxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updatePasswordbtn;
        private System.Windows.Forms.CheckBox passwordformcheckboc;
        private System.Windows.Forms.Button clearbuttonpasswordform;
        private System.Windows.Forms.Button backbtnpasswordform;
        private DrivingSchoolBookingSystem.WstGrp2DataSetTableAdapters.tblEmployeeTableAdapter taEmployee;
        private DrivingSchoolBookingSystem.WstGrp2DataSet dsBookingSystem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}