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
    public partial class DoctorControl : UserControl
    {
        public DoctorControl()
        {
            InitializeComponent();
        }

        Doctor d = new Doctor();

        private void DoctorControl_Load(object sender, EventArgs e)
        {
            DataTable dt = d.Select();
            DgvDoctorList.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            d.Name = TxtFirstName.Text;
            d.LastName = TxtLastName.Text;
            d.TelephoneNo = TxtContactNo.Text;
            d.Specialty = TxtSpecialty.Text;
            d.Address = TxtCity.Text;
            d.Birthday = DtpBirthday.Value;
            d.Gender = CboGender.Text;

            //Inserting Data into database using the method
            bool success = d.Insert(d);
            if (success == true)
            {
                //Succesfully Inserted
                MessageBox.Show("New Doctor Successfully Inserted");
                Clear();
            }
            else
            {
                //Failed to add contact
                MessageBox.Show("Failed to add New Doctor. Try Again.");
            }

            //Load Data on Data Gridview
            DataTable dt = d.Select();
            DgvDoctorList.DataSource = dt;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtDoctorId.Text != "")
            {
                // Get the data from textboxes
                d.DoctorId = int.Parse(TxtDoctorId.Text);
                d.Name = TxtFirstName.Text;
                d.LastName = TxtLastName.Text;
                d.Birthday = DtpBirthday.Value;
                d.TelephoneNo = TxtContactNo.Text;
                d.Specialty = TxtSpecialty.Text;
                d.Address = TxtCity.Text;
                d.Gender = CboGender.Text;
            }


            //Update data in database
            bool success = d.Update(d);
            if (success)
            {
                //Updated successfully
                MessageBox.Show("Doctor has been successfully updated.");
                //Load Data on Data Gridview
                DataTable dt = d.Select();
                DgvDoctorList.DataSource = dt;
            }
            else
            {
                //Failed to Update
                MessageBox.Show("Failed to Update Doctor. Try Again.");
            }

            Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtDoctorId.Text != "")
            {
                // Get the data from textboxes
                d.DoctorId = int.Parse(TxtDoctorId.Text);
            }

            bool success = d.Delete(d);
            if (success)
            {
                //Deleted successfully
                MessageBox.Show("Doctor has been successfully deleted.");
                //Load Data on Data Gridview
                DataTable dt = d.Select();
                DgvDoctorList.DataSource = dt;
                Clear();
            }
            else
            {
                //Failed to Delete
                MessageBox.Show("Failed to Delete Doctor. Try Again.");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            TxtDoctorId.Text = "";
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            DtpBirthday.Value = DtpBirthday.MaxDate;
            TxtContactNo.Text = "";
            TxtSpecialty.Text = "";
            TxtCity.Text = "";
            CboGender.Text = "";
        }

        private void DgvDoctorList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the Data From DataGrid View and Load it to the text boxes respectively
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;

            TxtDoctorId.Text = DgvDoctorList.Rows[rowIndex].Cells[0].Value.ToString();
            TxtFirstName.Text = DgvDoctorList.Rows[rowIndex].Cells[1].Value.ToString();
            TxtLastName.Text = DgvDoctorList.Rows[rowIndex].Cells[2].Value.ToString();
            TxtContactNo.Text = DgvDoctorList.Rows[rowIndex].Cells[3].Value.ToString();
            TxtSpecialty.Text = DgvDoctorList.Rows[rowIndex].Cells[4].Value.ToString();
            TxtCity.Text = DgvDoctorList.Rows[rowIndex].Cells[5].Value.ToString();
            DtpBirthday.Value = Convert.ToDateTime(DgvDoctorList.Rows[rowIndex].Cells[6].Value);
            CboGender.Text = DgvDoctorList.Rows[rowIndex].Cells[7].Value.ToString();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from the textbox
            string keyword = TxtSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstring);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TblDoctor WHERE FirstName Like '%" + keyword + "%' OR LastName Like '%" + keyword + "%'  OR City Like '%" + keyword + "%' OR Specialty Like '%" + keyword + "%' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DgvDoctorList.DataSource = dt;
        }
    }
}
