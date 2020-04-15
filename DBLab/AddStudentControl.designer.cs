namespace DBLabs
{
    partial class AddStudentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddStudentGB = new System.Windows.Forms.GroupBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.tbxStudentID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gbxPhone = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxStudentType = new System.Windows.Forms.ComboBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.gbxGender = new System.Windows.Forms.GroupBox();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxZipCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxStreetAddress = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.dgvPhoneNumbers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbcPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcbPhoneType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gtbPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddStudentGB.SuspendLayout();
            this.gbxPhone.SuspendLayout();
            this.gbxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneNumbers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddStudentGB
            // 
            this.AddStudentGB.Controls.Add(this.groupBox1);
            this.AddStudentGB.Controls.Add(this.gbxPhone);
            this.AddStudentGB.Location = new System.Drawing.Point(14, 12);
            this.AddStudentGB.Name = "AddStudentGB";
            this.AddStudentGB.Size = new System.Drawing.Size(1051, 507);
            this.AddStudentGB.TabIndex = 0;
            this.AddStudentGB.TabStop = false;
            this.AddStudentGB.Text = "Add Student";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(12, 322);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 12;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // tbxStudentID
            // 
            this.tbxStudentID.Location = new System.Drawing.Point(94, 19);
            this.tbxStudentID.Name = "tbxStudentID";
            this.tbxStudentID.Size = new System.Drawing.Size(141, 20);
            this.tbxStudentID.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "ID";
            // 
            // gbxPhone
            // 
            this.gbxPhone.Controls.Add(this.dgvPhoneNumbers);
            this.gbxPhone.Location = new System.Drawing.Point(253, 19);
            this.gbxPhone.Name = "gbxPhone";
            this.gbxPhone.Size = new System.Drawing.Size(359, 364);
            this.gbxPhone.TabIndex = 20;
            this.gbxPhone.TabStop = false;
            this.gbxPhone.Text = "Phone Numbers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Student Type";
            // 
            // cbxStudentType
            // 
            this.cbxStudentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxStudentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxStudentType.FormattingEnabled = true;
            this.cbxStudentType.Location = new System.Drawing.Point(94, 289);
            this.cbxStudentType.Name = "cbxStudentType";
            this.cbxStudentType.Size = new System.Drawing.Size(141, 21);
            this.cbxStudentType.TabIndex = 11;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(9, 266);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(49, 13);
            this.lblBirthdate.TabIndex = 15;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(94, 263);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(141, 20);
            this.dtpBirthdate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Country";
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(94, 237);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(141, 20);
            this.tbxCountry.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "City";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(94, 211);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(141, 20);
            this.tbxCity.TabIndex = 8;
            // 
            // gbxGender
            // 
            this.gbxGender.AutoSize = true;
            this.gbxGender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxGender.Controls.Add(this.rbtFemale);
            this.gbxGender.Controls.Add(this.rbtMale);
            this.gbxGender.Location = new System.Drawing.Point(94, 98);
            this.gbxGender.Name = "gbxGender";
            this.gbxGender.Size = new System.Drawing.Size(125, 55);
            this.gbxGender.TabIndex = 5;
            this.gbxGender.TabStop = false;
            this.gbxGender.Text = "Gender";
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Checked = true;
            this.rbtFemale.Location = new System.Drawing.Point(6, 19);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtFemale.TabIndex = 0;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Female";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Location = new System.Drawing.Point(71, 19);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(48, 17);
            this.rbtMale.TabIndex = 0;
            this.rbtMale.Text = "Male";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zip Code";
            // 
            // tbxZipCode
            // 
            this.tbxZipCode.Location = new System.Drawing.Point(94, 185);
            this.tbxZipCode.Name = "tbxZipCode";
            this.tbxZipCode.Size = new System.Drawing.Size(141, 20);
            this.tbxZipCode.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Street Address";
            // 
            // tbxStreetAddress
            // 
            this.tbxStreetAddress.Location = new System.Drawing.Point(94, 159);
            this.tbxStreetAddress.Name = "tbxStreetAddress";
            this.tbxStreetAddress.Size = new System.Drawing.Size(141, 20);
            this.tbxStreetAddress.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 75);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(94, 72);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(141, 20);
            this.tbxLastName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 49);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(94, 46);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(141, 20);
            this.tbxFirstName.TabIndex = 1;
            // 
            // dgvPhoneNumbers
            // 
            this.dgvPhoneNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneNumbers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcbPhoneType,
            this.gtbPhoneNumber});
            this.dgvPhoneNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhoneNumbers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPhoneNumbers.Location = new System.Drawing.Point(3, 16);
            this.dgvPhoneNumbers.Name = "dgvPhoneNumbers";
            this.dgvPhoneNumbers.Size = new System.Drawing.Size(353, 345);
            this.dgvPhoneNumbers.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tbxStudentID);
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.tbxFirstName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.tbxLastName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxStreetAddress);
            this.groupBox1.Controls.Add(this.cbxStudentType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblBirthdate);
            this.groupBox1.Controls.Add(this.tbxZipCode);
            this.groupBox1.Controls.Add(this.dtpBirthdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gbxGender);
            this.groupBox1.Controls.Add(this.tbxCountry);
            this.groupBox1.Controls.Add(this.tbxCity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 364);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // gbcPhoneNumber
            // 
            this.gbcPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gbcPhoneNumber.HeaderText = "Number";
            this.gbcPhoneNumber.Name = "gbcPhoneNumber";
            // 
            // gcbPhoneType
            // 
            this.gcbPhoneType.HeaderText = "Type";
            this.gcbPhoneType.Name = "gcbPhoneType";
            // 
            // gtbPhoneNumber
            // 
            this.gtbPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gtbPhoneNumber.HeaderText = "Number";
            this.gtbPhoneNumber.Name = "gtbPhoneNumber";
            // 
            // AddStudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddStudentGB);
            this.Name = "AddStudentControl";
            this.Size = new System.Drawing.Size(1087, 533);
            this.Load += new System.EventHandler(this.LoadAddStudentControl);
            this.AddStudentGB.ResumeLayout(false);
            this.AddStudentGB.PerformLayout();
            this.gbxPhone.ResumeLayout(false);
            this.gbxGender.ResumeLayout(false);
            this.gbxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneNumbers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddStudentGB;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.GroupBox gbxGender;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxZipCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxStreetAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.GroupBox gbxPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxStudentType;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxStudentID;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPhoneNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn gbcPhoneNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn gcbPhoneType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtbPhoneNumber;
    }
}
