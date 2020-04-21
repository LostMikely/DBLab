using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace DBLabs
{
    public partial class AddStudentControl : UserControl
    {
        private DBConnection dbconn;

        public AddStudentControl()
        {
            /*
             * Constructor the control
             * 
             * You DONT need to edit this constructor.
             * 
             */
            InitializeComponent();
        }

        public void AddStudentControlSettings(ref DBConnection dbconn)
        {
            /*
             * Since UserControls cannot take arguments to the constructor 
             * this function is called after the constructor to perform this.
             * 
             * You DONT need to edit this function.
             * 
             */
            this.dbconn = dbconn; 
        }

        private void LoadAddStudentControl(object sender, EventArgs e)
        {
            /*
             * This function contains all code that needs to be executed when the control is first loaded
             * 
             * You need to edit this code. 
             * Example: Population of Comboboxes and gridviews etc.
             * 
             */
            DateTime TenYearsAgo = DateTime.Now.AddYears(-10);
            dtpBirthdate.MaxDate = TenYearsAgo;

            var studentTypes = new List<String>();
            dbconn.FetchStudentTypes(studentTypes);
            cbxStudentType.Items.AddRange(studentTypes.ToArray());

            var phoneTypes = new List<String>();
            dbconn.FetchPhoneTypes(phoneTypes);
            gcbPhoneType.Items.AddRange(phoneTypes.ToArray());
        }

        public void ResetAddStudentControl()
        {
            /*
             * This function contains all code that needs to be executed when the control is reloaded
             * 
             * You need to edit this code. 
             * Example: Emptying textboxes and gridviews
             * 
             */
            tbxStudentID.ResetText();
            tbxFirstName.ResetText();
            tbxLastName.ResetText();
            rbtFemale.Checked = true;
            tbxStreetAddress.ResetText();
            tbxZipCode.ResetText();
            tbxCity.ResetText();
            tbxCountry.ResetText();
            dtpBirthdate.ResetText();
            cbxStudentType.SelectedItem = null;
            dgvPhoneNumbers.Rows.Clear();
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string gender;
            if (rbtFemale.Checked) gender = "female";
            else if (rbtMale.Checked) gender = "male";
            else throw new Exception("Something weird just happened...");

            if(dbconn.CallSPAddStudent(tbxStudentID.Text, tbxFirstName.Text, tbxLastName.Text, gender, tbxStreetAddress.Text, tbxZipCode.Text, tbxCity.Text, tbxCountry.Text, dtpBirthdate.Value.ToString(), cbxStudentType.Text, dgvPhoneNumbers.Rows))
            {
                MessageBox.Show("Student added! :)", "Great success!");
                ResetAddStudentControl();
            }
        }

        private void btnDeleteNumber_Click(object sender, EventArgs e)
        {
            if(dgvPhoneNumbers.SelectedRows.Count == 1)
                if(dgvPhoneNumbers.SelectedRows[0].Index != dgvPhoneNumbers.RowCount - 1)
                    dgvPhoneNumbers.Rows.Remove(dgvPhoneNumbers.SelectedRows[0]);
        }
    }
}
