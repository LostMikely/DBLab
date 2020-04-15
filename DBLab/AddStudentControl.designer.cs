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
            this.lvwPhoneNumbers = new System.Windows.Forms.ListView();
            this.lvcPhoneType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPhoneAdd = new System.Windows.Forms.Button();
            this.cbxPhoneType = new System.Windows.Forms.ComboBox();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
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
            this.AddStudentGB.SuspendLayout();
            this.gbxPhone.SuspendLayout();
            this.gbxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddStudentGB
            // 
            this.AddStudentGB.Controls.Add(this.btnAddStudent);
            this.AddStudentGB.Controls.Add(this.tbxStudentID);
            this.AddStudentGB.Controls.Add(this.lblId);
            this.AddStudentGB.Controls.Add(this.gbxPhone);
            this.AddStudentGB.Controls.Add(this.label5);
            this.AddStudentGB.Controls.Add(this.cbxStudentType);
            this.AddStudentGB.Controls.Add(this.lblBirthdate);
            this.AddStudentGB.Controls.Add(this.dtpBirthdate);
            this.AddStudentGB.Controls.Add(this.label2);
            this.AddStudentGB.Controls.Add(this.tbxCountry);
            this.AddStudentGB.Controls.Add(this.label1);
            this.AddStudentGB.Controls.Add(this.tbxCity);
            this.AddStudentGB.Controls.Add(this.gbxGender);
            this.AddStudentGB.Controls.Add(this.label4);
            this.AddStudentGB.Controls.Add(this.tbxZipCode);
            this.AddStudentGB.Controls.Add(this.label3);
            this.AddStudentGB.Controls.Add(this.tbxStreetAddress);
            this.AddStudentGB.Controls.Add(this.lblLastName);
            this.AddStudentGB.Controls.Add(this.tbxLastName);
            this.AddStudentGB.Controls.Add(this.lblFirstName);
            this.AddStudentGB.Controls.Add(this.tbxFirstName);
            this.AddStudentGB.Location = new System.Drawing.Point(14, 12);
            this.AddStudentGB.Name = "AddStudentGB";
            this.AddStudentGB.Size = new System.Drawing.Size(1051, 507);
            this.AddStudentGB.TabIndex = 0;
            this.AddStudentGB.TabStop = false;
            this.AddStudentGB.Text = "Add Student";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(15, 328);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 12;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // tbxStudentID
            // 
            this.tbxStudentID.Location = new System.Drawing.Point(97, 25);
            this.tbxStudentID.Name = "tbxStudentID";
            this.tbxStudentID.Size = new System.Drawing.Size(141, 20);
            this.tbxStudentID.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "ID";
            // 
            // gbxPhone
            // 
            this.gbxPhone.Controls.Add(this.lvwPhoneNumbers);
            this.gbxPhone.Controls.Add(this.btnPhoneAdd);
            this.gbxPhone.Controls.Add(this.cbxPhoneType);
            this.gbxPhone.Controls.Add(this.tbxPhoneNumber);
            this.gbxPhone.Location = new System.Drawing.Point(253, 19);
            this.gbxPhone.Name = "gbxPhone";
            this.gbxPhone.Size = new System.Drawing.Size(303, 164);
            this.gbxPhone.TabIndex = 20;
            this.gbxPhone.TabStop = false;
            this.gbxPhone.Text = "Phone Numbers";
            // 
            // lvwPhoneNumbers
            // 
            this.lvwPhoneNumbers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcPhoneType,
            this.lvcPhoneNumber});
            this.lvwPhoneNumbers.FullRowSelect = true;
            this.lvwPhoneNumbers.GridLines = true;
            this.lvwPhoneNumbers.HideSelection = false;
            this.lvwPhoneNumbers.Location = new System.Drawing.Point(6, 46);
            this.lvwPhoneNumbers.Name = "lvwPhoneNumbers";
            this.lvwPhoneNumbers.Size = new System.Drawing.Size(284, 112);
            this.lvwPhoneNumbers.TabIndex = 3;
            this.lvwPhoneNumbers.UseCompatibleStateImageBehavior = false;
            this.lvwPhoneNumbers.View = System.Windows.Forms.View.Details;
            // 
            // lvcPhoneType
            // 
            this.lvcPhoneType.Text = "Type";
            this.lvcPhoneType.Width = 87;
            // 
            // lvcPhoneNumber
            // 
            this.lvcPhoneNumber.Text = "Number";
            this.lvcPhoneNumber.Width = 191;
            // 
            // btnPhoneAdd
            // 
            this.btnPhoneAdd.Location = new System.Drawing.Point(215, 17);
            this.btnPhoneAdd.Name = "btnPhoneAdd";
            this.btnPhoneAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPhoneAdd.TabIndex = 2;
            this.btnPhoneAdd.Text = "Add";
            this.btnPhoneAdd.UseVisualStyleBackColor = true;
            this.btnPhoneAdd.Click += new System.EventHandler(this.btnPhoneAdd_Click);
            // 
            // cbxPhoneType
            // 
            this.cbxPhoneType.FormattingEnabled = true;
            this.cbxPhoneType.Location = new System.Drawing.Point(6, 19);
            this.cbxPhoneType.Name = "cbxPhoneType";
            this.cbxPhoneType.Size = new System.Drawing.Size(76, 21);
            this.cbxPhoneType.TabIndex = 0;
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(88, 19);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(121, 20);
            this.tbxPhoneNumber.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Student Type";
            // 
            // cbxStudentType
            // 
            this.cbxStudentType.FormattingEnabled = true;
            this.cbxStudentType.Location = new System.Drawing.Point(97, 295);
            this.cbxStudentType.Name = "cbxStudentType";
            this.cbxStudentType.Size = new System.Drawing.Size(141, 21);
            this.cbxStudentType.TabIndex = 11;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(12, 272);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(49, 13);
            this.lblBirthdate.TabIndex = 15;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(97, 269);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(141, 20);
            this.dtpBirthdate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Country";
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(97, 243);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(141, 20);
            this.tbxCountry.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "City";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(97, 217);
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
            this.gbxGender.Location = new System.Drawing.Point(97, 104);
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
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zip Code";
            // 
            // tbxZipCode
            // 
            this.tbxZipCode.Location = new System.Drawing.Point(97, 191);
            this.tbxZipCode.Name = "tbxZipCode";
            this.tbxZipCode.Size = new System.Drawing.Size(141, 20);
            this.tbxZipCode.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Street Address";
            // 
            // tbxStreetAddress
            // 
            this.tbxStreetAddress.Location = new System.Drawing.Point(97, 165);
            this.tbxStreetAddress.Name = "tbxStreetAddress";
            this.tbxStreetAddress.Size = new System.Drawing.Size(141, 20);
            this.tbxStreetAddress.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 81);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(97, 78);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(141, 20);
            this.tbxLastName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 55);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(97, 52);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(141, 20);
            this.tbxFirstName.TabIndex = 1;
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
            this.gbxPhone.PerformLayout();
            this.gbxGender.ResumeLayout(false);
            this.gbxGender.PerformLayout();
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
        private System.Windows.Forms.ListView lvwPhoneNumbers;
        private System.Windows.Forms.ColumnHeader lvcPhoneType;
        private System.Windows.Forms.ColumnHeader lvcPhoneNumber;
        private System.Windows.Forms.Button btnPhoneAdd;
        private System.Windows.Forms.ComboBox cbxPhoneType;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxStudentType;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxStudentID;
        private System.Windows.Forms.Button btnAddStudent;
    }
}
