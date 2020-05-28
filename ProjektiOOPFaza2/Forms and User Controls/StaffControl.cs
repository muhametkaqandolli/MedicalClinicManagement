using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektiOOPFaza2.Classes;
using System.Configuration;
using System.Data.SqlClient;

namespace ProjektiOOPFaza2.Forms_and_User_Controls
{
    public partial class StaffControl : UserControl
    {
        public StaffControl()
        {
            InitializeComponent();
        }

        Employee em = new Employee();

        private void StaffControl_Load(object sender, EventArgs e)
        {
            DataTable dt = em.Select();
            DgvEmployeeList.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            em.Name = TxtFirstName.Text;
            em.LastName = TxtLastName.Text;
            em.TelephoneNo = TxtContactNo.Text;
            em.Position = TxtPosition.Text;
            em.Address = TxtCity.Text;
            em.Birthday = DtpBirthday.Value;
            em.Gender = CboGender.Text;

            //Inserting Data into database using the method
            bool success = em.Insert(em);
            if (success == true)
            {
                //Succesfully Inserted
                MessageBox.Show("New Employee Successfully Inserted");
                Clear();
            }
            else
            {
                //Failed to add contact
                MessageBox.Show("Failed to add New Employee. Try Again.");
            }

            //Load Data on Data Gridview
            DataTable dt = em.Select();
            DgvEmployeeList.DataSource = dt;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtEmployeeId.Text != "")
            {
                // Get the data from textboxes
                em.EmployeeId = int.Parse(TxtEmployeeId.Text);
                em.Name = TxtFirstName.Text;
                em.LastName = TxtLastName.Text;
                em.Birthday = DtpBirthday.Value;
                em.TelephoneNo = TxtContactNo.Text;
                em.Position = TxtPosition.Text;
                em.Address = TxtCity.Text;
                em.Gender = CboGender.Text;
            }


            //Update data in database
            bool success = em.Update(em);
            if (success)
            {
                //Updated successfully
                MessageBox.Show("Employee has been successfully updated.");
                //Load Data on Data Gridview
                DataTable dt = em.Select();
                DgvEmployeeList.DataSource = dt;
            }
            else
            {
                //Failed to Update
                MessageBox.Show("Failed to Update Employee. Try Again.");
            }

            Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtEmployeeId.Text != "")
            {
                // Get the data from textboxes
                em.EmployeeId = int.Parse(TxtEmployeeId.Text);
            }

            bool success = em.Delete(em);
            if (success)
            {
                //Deleted successfully
                MessageBox.Show("Employee has been successfully deleted.");
                //Load Data on Data Gridview
                DataTable dt = em.Select();
                DgvEmployeeList.DataSource = dt;
                Clear();
            }
            else
            {
                //Failed to Delete
                MessageBox.Show("Failed to Delete Employee. Try Again.");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            TxtEmployeeId.Text = "";
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            DtpBirthday.Value = DtpBirthday.MaxDate;
            TxtContactNo.Text = "";
            TxtPosition.Text = "";
            TxtCity.Text = "";
            CboGender.Text = "";
        }

        private void DgvEmployeeList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the Data From DataGrid View and Load it to the text boxes respectively
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;

            TxtEmployeeId.Text = DgvEmployeeList.Rows[rowIndex].Cells[0].Value.ToString();
            TxtFirstName.Text = DgvEmployeeList.Rows[rowIndex].Cells[1].Value.ToString();
            TxtLastName.Text = DgvEmployeeList.Rows[rowIndex].Cells[2].Value.ToString();
            TxtContactNo.Text = DgvEmployeeList.Rows[rowIndex].Cells[3].Value.ToString();
            TxtPosition.Text = DgvEmployeeList.Rows[rowIndex].Cells[4].Value.ToString();
            TxtCity.Text = DgvEmployeeList.Rows[rowIndex].Cells[5].Value.ToString();
            DtpBirthday.Value = Convert.ToDateTime(DgvEmployeeList.Rows[rowIndex].Cells[6].Value);
            CboGender.Text = DgvEmployeeList.Rows[rowIndex].Cells[7].Value.ToString();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from the textbox
            string keyword = TxtSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstring);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TblPatient WHERE FirstName Like '%" + keyword + "%' OR LastName Like '%" + keyword + "%'  OR City Like '%" + keyword + "%' OR Position Like '%" + keyword + "%' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DgvEmployeeList.DataSource = dt;
        }
    }
}
