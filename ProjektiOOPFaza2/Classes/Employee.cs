using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLib;


namespace ProjektiOOPFaza2.Classes
{
    class Employee : Person
    {

        public int EmployeeId { get; set; }
       // public string FirstName { get; set; }
        
        // public string LastName { get; set; }

        // public string City { get; set; }

        public string TelephoneNo { get; set; }

        public string Position { get; set; }

        public DateTime Birthday { get; set; }

        public string Gender { get; set; }



        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public Employee(string firstName, string lastName, string city, string telephoneNo, string position, DateTime birthday, string gender) : base(firstName, lastName, city)
        {
            TelephoneNo = telephoneNo;
            Position = position;
            Birthday = birthday;
            Gender = gender;
        }

        public Employee()
        {
        }

        //Selecting Data from Database
        public DataTable Select()
        {
            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM TblEmployee";

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
        public bool Insert(Employee e)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Step 2: Create a SQL Query to insert Data
                string sql = "INSERT INTO TblEmployee (FirstName, LastName, TelephoneNo, Position, City, Birthday ,Gender) VALUES (@FirstName, @LastName, @TelephoneNo, @Position, @City, @Birthday, @Gender)";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", e.Name);
                cmd.Parameters.AddWithValue("@LastName", e.LastName);
                cmd.Parameters.AddWithValue("@TelephoneNo", e.TelephoneNo);
                cmd.Parameters.AddWithValue("@Position", e.Position);
                cmd.Parameters.AddWithValue("@City", e.Address);
                cmd.Parameters.AddWithValue("@Birthday", e.Birthday);
                cmd.Parameters.AddWithValue("@Gender", e.Gender);

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
        public bool Update(Employee e)
        {
            //Create a defalut return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //SQL to update data in our Database
                string sql = "UPDATE TblEmployee SET FirstName=@FirstName, LastName=@LastName, TelephoneNo=@TelephoneNo, Position=@Position ,City=@City, Birthday=@Birthday ,Gender=@Gender WHERE EmployeeId=@EmployeeId";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to add value
                cmd.Parameters.AddWithValue("@FirstName", e.Name);
                cmd.Parameters.AddWithValue("@LastName", e.LastName);
                cmd.Parameters.AddWithValue("@TelephoneNo", e.TelephoneNo);
                cmd.Parameters.AddWithValue("@Position", e.Position);
                cmd.Parameters.AddWithValue("@City", e.Address);
                cmd.Parameters.AddWithValue("@Birthday", e.Birthday);
                cmd.Parameters.AddWithValue("@Gender", e.Gender);
                cmd.Parameters.AddWithValue("@EmployeeId", e.EmployeeId);

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
        public bool Delete(Employee e)
        {
            //Create a default return value and set its value to false
            bool isSuccess = false;

            //Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //SQL to Delete Data
                string sql = "DELETE FROM TblEmployee WHERE EmployeeId=@EmployeeId";

                //Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", e.EmployeeId);

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
