using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiOOPFaza2.Classes
{
    class Appointment
    {
        public int AppointmentId { get; set; }
        public int ScheduleId { get; set; }
        public string Diagnosis { get; set; }
        public string Services { get; set; }
        public string Treatment { get; set; }
        public decimal Price { get; set; }

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
                string sql = "SELECT * FROM TblAppointment";

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
        public bool Insert(Appointment a)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Create a SQL Query to insert Data
                string sql = "INSERT INTO TblAppointment (ScheduleId, Diagnosis, Services, Treatment, Price) VALUES (@ScheduleId, @Diagnosis, @Services, @Treatment, @Price)";
               



                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);



                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@ScheduleId", a.ScheduleId);
                cmd.Parameters.AddWithValue("@Diagnosis", a.Diagnosis);
                cmd.Parameters.AddWithValue("@Services", a.Services);
                cmd.Parameters.AddWithValue("@Treatment", a.Treatment);
                cmd.Parameters.AddWithValue("@Price", a.Price);


                //Connection Open Here
                conn.Open();


                int rows = cmd.ExecuteNonQuery();
                
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
        public bool Update(Appointment a)
        {
            //Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //SQL to update data in our Database
                string sql = "UPDATE TblAppointment SET ScheduleId=@ScheduleId, Diagnosis=@Diagnosis, Services=@Services, Treatment=@Treatment ,Price=@Price WHERE AppointmentId=@AppointmentId";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);


                //Create Parameters to add value
                cmd.Parameters.AddWithValue("@AppointmentId", a.AppointmentId);
                cmd.Parameters.AddWithValue("@Diagnosis", a.Diagnosis);
                cmd.Parameters.AddWithValue("@Services", a.Services);
                cmd.Parameters.AddWithValue("@Treatment", a.Treatment);
                cmd.Parameters.AddWithValue("@Price", a.Price);
                cmd.Parameters.AddWithValue("@ScheduleId", a.ScheduleId);

                //Open Database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
    

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
        public bool Delete(Appointment a)
        {
            //Create a default return value and set its value to false
            bool isSuccess = false;

            //Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //SQL to Delete Data
                string sql = "DELETE FROM TblAppointment WHERE AppointmentId=@AppointmentId";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@AppointmentId", a.AppointmentId);

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
