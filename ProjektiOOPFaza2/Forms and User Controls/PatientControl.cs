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
    public partial class PatientControl : UserControl
    {
        public PatientControl()
        {
            InitializeComponent();
        }

        Patient p = new Patient();

        private void PatientControl_Load(object sender, EventArgs e)
        {
            DataTable dt = p.Select();
            DgvPatientList.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            p.Name = TxtFirstName.Text;
            p.LastName = TxtLastName.Text;
            p.TelephoneNo = TxtContactNo.Text;
            p.Address = TxtCity.Text;
            p.Birthday = DtpBirthday.Value;
            p.Gender = CboGender.Text;

            //Inserting Data into database using the method
            bool success = p.Insert(p);
            if (success == true)
            {
                //Succesfully Inserted
                MessageBox.Show("New Patient Successfully Inserted");
                Clear();
            }
            else
            {
                //Failed to add contact
                MessageBox.Show("Failed to add New Patient. Try Again.");
            }

            //Load Data on Data Gridview
            DataTable dt = p.Select();
            DgvPatientList.DataSource = dt;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtPatientId.Text != "")
            {
                // Get the data from textboxes
                p.PatientId = int.Parse(TxtPatientId.Text);
                p.Name = TxtFirstName.Text;
                p.LastName = TxtLastName.Text;
                p.Birthday = DtpBirthday.Value;
                p.TelephoneNo = TxtContactNo.Text;
                p.Address = TxtCity.Text;
                p.Gender = CboGender.Text;
            }


            //Update data in database
            bool success = p.Update(p);
            if (success)
            {
                //Updated successfully
                MessageBox.Show("Patient has been successfully updated.");
                //Load Data on Data Gridview
                DataTable dt = p.Select();
                DgvPatientList.DataSource = dt;
            }
            else
            {
                //Failed to Update
                MessageBox.Show("Failed to Update Patient. Try Again.");
            }

            Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtPatientId.Text != "")
            {
                // Get the data from textboxes
                p.PatientId = int.Parse(TxtPatientId.Text);
            }

            bool success = p.Delete(p);
            if (success)
            {
                //Deleted successfully
                MessageBox.Show("Patient has been successfully deleted.");
                //Load Data on Data Gridview
                DataTable dt = p.Select();
                DgvPatientList.DataSource = dt;
                Clear();
            }
            else
            {
                //Failed to Delete
                MessageBox.Show("Failed to Delete Patient. Try Again.");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            TxtPatientId.Text = "";
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            DtpBirthday.Value = DtpBirthday.MaxDate;
            TxtContactNo.Text = "";
            TxtCity.Text = "";
            CboGender.Text = "";
        }

        private void DgvPatientList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the Data From DataGrid View and Load it to the text boxes respectively
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;

            TxtPatientId.Text = DgvPatientList.Rows[rowIndex].Cells[0].Value.ToString();
            TxtFirstName.Text = DgvPatientList.Rows[rowIndex].Cells[1].Value.ToString();
            TxtLastName.Text = DgvPatientList.Rows[rowIndex].Cells[2].Value.ToString();
            TxtContactNo.Text = DgvPatientList.Rows[rowIndex].Cells[3].Value.ToString();
            TxtCity.Text = DgvPatientList.Rows[rowIndex].Cells[4].Value.ToString();
            DtpBirthday.Value = Convert.ToDateTime(DgvPatientList.Rows[rowIndex].Cells[5].Value);
            CboGender.Text = DgvPatientList.Rows[rowIndex].Cells[6].Value.ToString();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from the textbox
            string keyword = TxtSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstring);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TblPatient WHERE FirstName Like '%" + keyword + "%' OR LastName Like '%" + keyword + "%'  OR City Like '%" + keyword + "%' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DgvPatientList.DataSource = dt;
        }
    }
}
