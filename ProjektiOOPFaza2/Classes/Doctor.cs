using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PersonLib;


namespace ProjektiOOPFaza2.Classes
{
    public class Doctor : Person
    {
        public int DoctorId { get; set; }
        // public string FirstName { get; set; }
        // public string LastName { get; set; }
        public string TelephoneNo { get; set; }
        public string Specialty { get; set; }
        // public string City { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }

        public Doctor()
        {

        }

        public Doctor(string firstName, string lastName, string city, string telephoneNo,string specialty, DateTime birthday, string gender) : base(firstName, lastName, city)
        {
            TelephoneNo = telephoneNo;
            Specialty = specialty;
            Birthday = birthday;
            Gender = gender;
        }

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
                string sql = "SELECT * FROM TblDoctor";

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
        public bool Insert(Doctor d)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Create a SQL Query to insert Data
                string sql = "INSERT INTO TblDoctor (FirstName, LastName, TelephoneNo, Specialty, City, Birthday ,Gender) VALUES (@FirstName, @LastName, @TelephoneNo, @Specialty, @City, @Birthday, @Gender)";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", d.Name);
                cmd.Parameters.AddWithValue("@LastName", d.LastName);
                cmd.Parameters.AddWithValue("@TelephoneNo", d.TelephoneNo);
                cmd.Parameters.AddWithValue("@Specialty", d.Specialty);
                cmd.Parameters.AddWithValue("@City", d.Address);
                cmd.Parameters.AddWithValue("@Birthday", d.Birthday);
                cmd.Parameters.AddWithValue("@Gender", d.Gender);

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
            catch (Exception )
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
        public bool Update(Doctor d)
        {
            //Create a defalut return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //SQL to update data in our Database
                string sql = "UPDATE TblDoctor SET FirstName=@FirstName, LastName=@LastName, TelephoneNo=@TelephoneNo, Specialty=@Specialty ,City=@City, Birthday=@Birthday ,Gender=@Gender WHERE DoctorId=@DoctorId";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to add value
                cmd.Parameters.AddWithValue("@FirstName", d.Name);
                cmd.Parameters.AddWithValue("@LastName", d.LastName);
                cmd.Parameters.AddWithValue("@TelephoneNo", d.TelephoneNo);
                cmd.Parameters.AddWithValue("@Specialty", d.Specialty);
                cmd.Parameters.AddWithValue("@City", d.Address);
                cmd.Parameters.AddWithValue("@Birthday", d.Birthday);
                cmd.Parameters.AddWithValue("@Gender", d.Gender);
                cmd.Parameters.AddWithValue("@DoctorId", d.DoctorId);

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
        public bool Delete(Doctor d)
        {
            //Create a default return value and set its value to false
            bool isSuccess = false;

            //Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //SQL to Delete Data
                string sql = "DELETE FROM TblDoctor WHERE DoctorId=@DoctorId";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DoctorId", d.DoctorId);

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
