﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace DBLabs
{
    public class DBConnection : DBLabsDLL.DBConnectionBase
    {
        public SqlConnection con;
       
        ///*
        // * The constructor
        // */
        public DBConnection()
        {
        }

        /*
         * The function to login to the database
         * 
         * Parameters:
         *              username    The userid used to login to SQL Server
         *              password    The password for the userid
         *              
         * Return value:
         *              true    successful login
         *              false   Error
         */
        public override bool login(string username, string password)
        {
            username = "DVA234_2020_G26";
            password = "Corona2020";
            string conString = "Data Source=www4.idt.mdh.se;" + "Initial Catalog=DVA234_2020_G26_db;" + "User Id=" + username + "; Password=" + password + ";";
            con = new SqlConnection(conString);
            try
            {
                con.Open();
            } catch (SqlException)
            {
                return false;
            }
            con.Close();
            return true;
        }
/*
 --------------------------------------------------------------------------------------------
 IMPLEMENTATION TO BE USED IN LAB 2. 
 --------------------------------------------------------------------------------------------
*/

    // Here you need to implement your own methods that call the stored procedures 
    // addStudent and addStudentPhoneNo
        public bool CallSPAddStudent(string studentID, string firstName, string lastName, string gender, string streetAddress, string zipCode, string city, string country, string birthDate, string studentType, DataGridViewRowCollection phoneEntries)
        {
            if (studentID.Length == 0 || studentID.Length > 8)
            {
                MessageBox.Show("Error: Incorrect student ID", "Data validation error");
                return false;
            }

            if (firstName.Length == 0 || firstName.Length > 50)
            {
                MessageBox.Show("Error: Incorrect first name", "Data validation error");
                return false;
            }

            if (lastName.Length == 0 || lastName.Length > 50)
            {
                MessageBox.Show("Error: Incorrect last name", "Data validation error");
                return false;
            }

            if (gender != "male" && gender != "female")
            {
                MessageBox.Show("Error: Incorrect gender", "Data validation error");
                return false;
            }

            if (streetAddress.Length > 100)
            {
                MessageBox.Show("Error: Incorrect street address", "Data validation error");
                return false;
            }

            if (city.Length == 0 || city.Length > 50)
            {
                MessageBox.Show("Error: Incorrect city", "Data validation error");
                return false;
            }

            if (country.Length == 0 || country.Length > 50)
            {
                MessageBox.Show("Error: Incorrect country", "Data validation error");
                return false;
            }

            if (studentType.Length == 0 || studentType.Length > 50)
            {
                MessageBox.Show("Error: Incorrect student type", "Data validation error");
                return false;
            }

            for (int i = 0; i < phoneEntries.Count - 1; i++)
            {
                if ((String)phoneEntries[i].Cells[0].Value == null)
                {
                    MessageBox.Show($"Error: Type is missing for phone number field no. {i + 1}.", "Data validation error");
                    return false;
                }
                else if ((String)phoneEntries[i].Cells[1].Value == null)
                {
                    MessageBox.Show($"Error: Number is missing for phone number field no. {i + 1}.", "Data validation error");
                    return false;
                }
            }

            int rowsAffected;

            // Call the stored procedure
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("addStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@StreetAddress", streetAddress);
                cmd.Parameters.AddWithValue("@ZipCode", zipCode);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                cmd.Parameters.AddWithValue("@StudentType", studentType);

                rowsAffected = cmd.ExecuteNonQuery();
                
                for (int i = 0; i < phoneEntries.Count - 1; i++)
                {
                    cmd = new SqlCommand("addStudentPhoneNo", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@studentID", studentID);
                    
                    cmd.Parameters.AddWithValue("@phoneType", (String)phoneEntries[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@number", (String)phoneEntries[i].Cells[1].Value);

                    cmd.ExecuteNonQuery();
                }
            } catch (SqlException exception)
            {
                // non-unique StudentID
                if (exception.Number == 2627)
                {
                    MessageBox.Show("Error: Student with this ID already exists", "Primary key violation");
                } else
                {
                    MessageBox.Show($"Error: {exception.Message}", "SQL Error");
                }
                con.Close();
                return false;
            }

            con.Close();
            return (rowsAffected > 0);
        }

        public void FetchStudentTypes(List<String> studentTypes)
        {
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            
            sqlCommand = new SqlCommand("SELECT Type from StudentTypes", con);
            con.Open();
            sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
                while (sqlDataReader.Read())
                {
                    studentTypes.Add(sqlDataReader.GetString(0));
                }
            sqlDataReader.Close();
            con.Close();
        }

        public void FetchPhoneTypes(List<String> phoneTypes)
        {
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            
            sqlCommand = new SqlCommand("SELECT Type from PhoneTypes", con);
            con.Open();
            sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
                while (sqlDataReader.Read())
                {
                    phoneTypes.Add(sqlDataReader.GetString(0));
                }
            sqlDataReader.Close();
            con.Close();
        }

        /*
         --------------------------------------------------------------------------------------------
         STUB IMPLEMENTATIONS TO BE USED IN LAB 3. 
         --------------------------------------------------------------------------------------------
        */


        /********************************************************************************************
         * DATABASE UPDATING METHODS
         *******************************************************************************************/

        /*
         * Add a prerequisite for a course
         * 
         * Parameters:
         *              cc          CourseCode of the course on which to add a prerequisite
         *              preReqcc    CourseCode of the course that is the prerequisite
         *              
         * Return value:
         *              1           Prerequisite added
         *              Any other   Error
         */
        public override int addPreReq(string cc, string preReqcc)
        {
            if (!String.Equals(cc, preReqcc))
            {
                SqlCommand cmd = new SqlCommand("addPrerequisites", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cc", cc);
                cmd.Parameters.AddWithValue("@pr", preReqcc);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    return 0;
                }
                finally
                {
                    con.Close();
                }

                return 1;
            }

            return 0;
        }

        /*
         * Add a course instance for a course
         * 
         * Parameters:
         *              cc          CourseCode of the course on which to add a course instance
         *              year        The year for the course instance
         *              period      The period for the course instance
         *              
         * Return value:
         *              1           Course instance added
         *              Any other   Error
         */
        public override int addInstance(string cc, int year, int period)
        {
            SqlCommand cmd = new SqlCommand("addInstance", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@period", period);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@cc", cc);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
            return 1;
        }

        /*
         * Add a teacher staffing for a course
         * 
         * Parameters:
         *              pnr         "Personnummer" for the teacher to staff
         *              cc          CourseCode of the course on which to add a teacher
         *              year        The year for the course instance
         *              period      The period for the course instance
         *              hours       The number of hours to staff the teacher
         *              
         * Return value:
         *              1           Teacher staffing added
         *              Any other   Error
         */
        public override int addStaff(string pnr, string cc, int year, int period, int hours)
        {
            SqlCommand cmd = new SqlCommand("addStaff", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pnr", pnr);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@period", period);
            cmd.Parameters.AddWithValue("@hours", hours);
            

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();
            }

            return 1;
        }

        /*
         * Add a labassistant staffing for a course
         * 
         * Parameters:
         *              studid      StudentID for the student to staff
         *              cc          CourseCode of the course on which to add a labassistant
         *              year        The year for the course instance
         *              period      The period for the course instance
         *              hours       The number of hours to staff the student
         *              
         * Return value:
         *              1           Labassistant staffing added
         *              Any other   Error
         */
        public override int addLabass(string studid, string cc, int year, int period, int hours, int salary)
        {
            SqlCommand cmd = new SqlCommand("addLabass", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@studid", studid);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@period", period);
            cmd.Parameters.AddWithValue("@hours", hours);
            cmd.Parameters.AddWithValue("@salary", salary);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();
            }

            return 1;
        }


        /*
         * Add a new course
         * 
         * Parameters:
         *              cc          CourseCode of the course on which to add a labassistant
         *              name        The name of the course
         *              credits     The number of credits for the course
         *              responsible The "personnummer" of the course responsible staff
         *              
         * Return value:
         *              1           Course added
         *              Any other   Error
         */
        public override int addCourse(string cc, string name, double credits, string responsible)
        {
            SqlCommand cmd = new SqlCommand("addCourse", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@credits", credits);
            cmd.Parameters.AddWithValue("@courseresponsible", responsible);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();
            }

            return 1;
        }


        /********************************************************************************************
         * DATABASE QUERYING METHODS
         *******************************************************************************************/

        /*
         * Get student data for all students
         * 
         * Parameters
         *              None
         * 
         * Return value:
         *              DataTable with the following columns:
         *                  StudentID       VARCHAR     StudentID for Students
         *                  FirstName       VARCHAR     Students First Name
         *                  LastName        VARCHAR     Students Last Name
         *                  Gender          VARCHAR     Students Gender
         *                  StreetAdress    VARCHAR     Students StreetAdress
         *                  ZipCode         VARCHAR     Students "PostNummer"
         *                  BirthDate       DATETIME    Students BirthDate
         *                  StudentType     VARCHAR     Student type (Program Student, Exchange Student etc)
         *                  City            VARCHAR     Students City
         *                  Country         VARCHAR     Students Country
         *                  program         VARCHAR     Name of the program the student is enrolled to
         *                  PgmStartYear    INTEGER     Year the student enrolled to the program
         *                  credits         FLOAT       The number of credits that the student has completed
         */
        public override DataTable getStudentData()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENTDATA", con);

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            con.Close();

            return dt;
        }

        /*
         * Get list of staff
         * 
         * Parameters
         *              None
         *
         * Return value
         *              DataTable with the following columns:
         *                  pnr             VARCHAR     "Personnummer" for the staff
         *                  fullname        VARCHAR     Full name (First name and Last Name) of the staff.
         */
        public override DataTable getStaff()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM STAFFLIST", con);

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            con.Close();

            return dt;
        }

        /*
         * Get list of Potential Labasses (i.e. students)
         * 
         * Parameters
         *              None
         *
         * Return value
         *              DataTable with the following columns:
         *                  StudentID       VARCHAR     StudentID for all students
         *                  fullname        VARCHAR     Full name (First name and Last Name) of the students.
         */
        public override DataTable getLabasses()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENTLIST", con);

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            con.Close();

            return dt;
        }

        /*
         * Get course data
         * 
         * Parameters
         *              None
         * 
         * Return value
         *              DataTable with the following columns:
         *                  coursecode      VARCHAR     Course Code
         *                  name            VARCHAR     Name of the Course
         *                  credits         FLOAT       Credits of the course
         *                  courseresponsible VARCHAR   "Personnummer" for the course responsible teacher
         */
        public override DataTable getCourses()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM COURSESDATA", con);

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            con.Close();

            return dt;
        }

        /*
         * Returns the salary costs for a course instance based on the teacher and lab assistent staffing.
         * 
         * Parameters:
         *              cc          CourseCode to the course to calculate the cost
         *              year        The year for the course instance
         *              period      The period for the course instance
         *              
         * Return value:
         *              integer     The cost in currency (SEK)
         */
        public override int getCourseCost(string cc, int year, int period)
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.getCourseCost(@cc, @year, @period)", con);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@period", period);

            if (con.State == ConnectionState.Closed)
                con.Open();

            int courseCost = 0;
            Int32.TryParse(cmd.ExecuteScalar().ToString(), out courseCost);

            con.Close();

            return courseCost;
        }

        /*
         * Returns the staffed persons (both teachers and lab assistants) for a course instance
         * 
         * Parameters:
         *              cc          CourseCode to the course to show staffing for
         *              year        The year for the course instance
         *              period      The period for the course instance
         *              
         * Return value:
         *              DataTable with the relevant information
         *                  The table should show name, number of hours, the Task in the course and the hourly salary
         */
        public override DataTable getCourseStaffing(string cc, string year, string period)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM getCourseStaffing(@cc, @year, @period)", con);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@period", int.Parse(period));

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            con.Close();

            return dt;

        }

        /*
         * Returns the student course transcript ("Ladokutdrag")
         * 
         * Parameters:
         *              studId      StudentID for student to show transcript for
         *              
         * Return value:
         *              DataTable with the relevant information
         *                  See lab-instructions for more information about this DataTable
         */
        public override DataTable getStudentRecord(string studId)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM getStudentCourses(@StudentID)", con);
            cmd.Parameters.AddWithValue("@StudentID", studId);

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            con.Close();

            return dt;
        }

        /*
         * Returns the a list of all courses that are prerequisites to a course.
         * 
         * Parameters:
         *              cc      Course Code for the course to list prerequisites
         *              
         * Return value:
         *              DataTable with the relevant information
         *                  The Table should show at least coursecode and course name for all prerequisite courses
         */
        public override DataTable getPreReqs(string cc)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM getPrerequisites(@cc)", con);
            cmd.Parameters.AddWithValue("@cc", cc);

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            con.Close();
            return dt;
        }


        /*
         * Get course instances for a course
         * 
         * Parameters
         *              cc      Course Code for the course to list course instances
         * 
         * Return value
         *              DataTable with the following columns:
         *                  year            INTEGER     The year of the course instance
         *                  period          INTEGER     The period of the course instance
         *                  instance        VARCHAR     The "Display text" for the instance, e.g. year(period) or similar
         */
        public override DataTable getInstances(string cc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("year");
            dt.Columns.Add("period");
            dt.Columns.Add("instance");

            SqlCommand cmd = new SqlCommand("SELECT * FROM getCourseInstances(@cc)", con);
            cmd.Parameters.AddWithValue("@cc", cc);

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            con.Close();

            return dt;
        }

        /*
        * Get list of telephone numbers for a student
        * 
        * Parameters
        *              studId      StudentID for the student
        * 
        * Return value
        *              DataTable with the following columns:
        *                  Type            VARCHAR     The type of telephone number (e.g., Home, Work, Cell etc.)
        *                  Number          VARCHAR     The telephone number
        */
        public override DataTable getStudentPhoneNumbers(string studId)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM getPhoneNumbers(@StudentID)", con);
            cmd.Parameters.AddWithValue("@StudentID", studId);

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            con.Close();

            return dt;
        }

        /*
        --------------------------------------------------------------------------------------------
         STUB IMPLEMENTATIONS TO BE USED IN LAB 4. 
        --------------------------------------------------------------------------------------------
        */


        /*
        * Get list years which have course instances
        * 
        * Parameters
        *              None      
        * 
        * Return value
        *              DataTable with the following column:
        *                  Year            INTEGER     A unique (no duplicates) list of all years which has course instances
        */
        public override DataTable getStaffingYears()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM COURSEYEARS ORDER BY Year DESC", con);

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            con.Close();

            return dt;
        }

        /*
        * Get a matrix of all staffing for a year
        * 
        * Parameters
        *              year     The year to show staffings for      
        * 
        * Return value
        *              DataTable with suitable format
        *                  For more information about the format, see Lab instructions for lab 4
        */
        public override DataTable getStaffingGrid(string year)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("getStaff", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CourseYear", year);

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            DataRow header = dt.NewRow();
            for(int i = 0; i < dt.Columns.Count; i++)
                header[i] = dt.Columns[i];
            dt.Rows.InsertAt(header, 0);

            con.Close();
            return dt;
        }
    }
}