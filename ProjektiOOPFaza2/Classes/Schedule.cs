using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektiOOPFaza2.Classes
{
    class Schedule
    {
        public int ScheduleId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Reason { get; set; }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Selecting Data from Database
        public DataTable Select()
        {
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM TblSchedule";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data into DataBase
        public bool Insert(Schedule s)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Create a SQL Query to insert Data
                string sql = "INSERT INTO TblSchedule (PatientId, DoctorId, Date, Time, Reason) VALUES (@PatientId, @DoctorId, @Date, @Time, @Reason)";
                string TimeAndDateSql = "SELECT * FROM TblSchedule WHERE DoctorId = " + s.DoctorId + " AND Date = '" + s.Date +"' AND Time = '"+s.Time+"'";
                


                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlCommand cmd2 = new SqlCommand(TimeAndDateSql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@PatientId", s.PatientId);
                cmd.Parameters.AddWithValue("@DoctorId", s.DoctorId);
                cmd.Parameters.AddWithValue("@Date", s.Date);
                cmd.Parameters.AddWithValue("@Time", s.Time);
                cmd.Parameters.AddWithValue("@Reason", s.Reason);

                DataTable DateAndTimeTable = new DataTable();
                //Connection Open Here
                conn.Open();
                adapter.Fill(DateAndTimeTable);


                int TimeAndDateRows = DateAndTimeTable.Rows.Count;

                //MessageBox.Show("The number of rows is " + TimeAndDateRows);

                int rows = 0;
                if (TimeAndDateRows == 0)
                {
                   rows = cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("This Date and Time is taken. \nPlease choose another Date or Time");
                }
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //Method to Update data in database from our application
        public bool Update(Schedule s)
        {
            //Create a defalut return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //SQL to update data in our Database
                string sql = "UPDATE TblSchedule SET PatientId=@PatientId, DoctorId=@DoctorId, Date=@Date, Time=@Time ,Reason=@Reason WHERE ScheduleId=@ScheduleId";
                string TimeAndDateSql = "SELECT * FROM TblSchedule WHERE DoctorId = " + s.DoctorId + " AND Date = '" + s.Date + "' AND Time = '" + s.Time + "'";  //"SELECT * FROM TblSchedule WHERE Date Like '@Date' AND Time Like '@Time'";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlCommand cmd2 = new SqlCommand(TimeAndDateSql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd2);

                //Create Parameters to add value
                cmd.Parameters.AddWithValue("@PatientId", s.PatientId);
                cmd.Parameters.AddWithValue("@DoctorId", s.DoctorId);
                cmd.Parameters.AddWithValue("@Date", s.Date);
                cmd.Parameters.AddWithValue("@Time", s.Time);
                cmd.Parameters.AddWithValue("@Reason", s.Reason);
                cmd.Parameters.AddWithValue("@ScheduleId", s.ScheduleId);

                DataTable DateAndTimeTable = new DataTable();
                //Open Database Connection
                conn.Open();

                adapter.Fill(DateAndTimeTable);


                int TimeAndDateRows = DateAndTimeTable.Rows.Count;
               // MessageBox.Show("The number of rows is " + TimeAndDateRows);

                int rows = 0;

                
                if (TimeAndDateRows == 0)
                {
                    rows = cmd.ExecuteNonQuery();
                } else
                {
                    MessageBox.Show("This Date and Time is taken. \nPlease choose another Date or Time");
                }

                //if the query runs successfully then the value of rows will be greater than zero else its value will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Method to Delete data from our Database
        public bool Delete(Schedule s)
        {
            //Create a default return value and set its value to false
            bool isSuccess = false;

            //Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //SQL to Delete Data
                string sql = "DELETE FROM TblSchedule WHERE ScheduleId=@ScheduleId";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ScheduleId", s.ScheduleId);

                //Open Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if query run successfully then the value of rows is greater than zero else its value is 0

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
