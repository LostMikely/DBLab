using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            dbconn.con.Open();
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            sqlCommand = new SqlCommand("SELECT Type from PhoneTypes", dbconn.con);
            sqlDataReader = sqlCommand.ExecuteReader();
            if(sqlDataReader.HasRows)
            while (sqlDataReader.Read())
            {
                gcbPhoneType.Items.Add(sqlDataReader.GetString(0));
            }
            sqlDataReader.Close();
            sqlCommand = new SqlCommand("SELECT Type from StudentTypes", dbconn.con);
            sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
                while (sqlDataReader.Read())
                {
                    cbxStudentType.Items.Add(sqlDataReader.GetString(0));
                }
            sqlDataReader.Close();
            dbconn.con.Close();
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
            cbxStudentType.ResetText();
            dgvPhoneNumbers.Rows.Clear();
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            char gender;
            if (rbtFemale.Checked) gender = 'F';
            else if (rbtMale.Checked) gender = 'M';
            else throw new Exception("Something weird just happened...");

            if(dbconn.CallSPAddStudent(tbxStudentID.Text, tbxFirstName.Text, tbxLastName.Text, gender, tbxStreetAddress.Text, tbxZipCode.Text, tbxCity.Text, tbxCountry.Text, dtpBirthdate.Value.ToString(), cbxStudentType.Text))
            {
                MessageBox.Show("Student added! :)", "Great success!");
                ResetAddStudentControl();
            }
        }

        private void btnPhoneAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
