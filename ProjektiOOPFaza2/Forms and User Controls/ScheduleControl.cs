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
using System.Collections;

namespace ProjektiOOPFaza2.Forms_and_User_Controls
{
    public partial class ScheduleControl : UserControl
    {
        public ScheduleControl()
        {
            InitializeComponent();

        }

        Schedule s = new Schedule();
        public static Doctor d = new Doctor();
        DataTable Ids = new DataTable();



        private void ScheduleControl_Load(object sender, EventArgs e)
        {
            DataTable dt = s.Select();


            DgvScheduleList.DataSource = dt;

            DtpDate.MinDate = DateTime.Today;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the textbox

            
            DoctorInfos();

            SqlDataAdapter sda = new SqlDataAdapter($"SELECT DoctorId FROM TblDoctor WHERE FirstName Like '{d.Name}' AND LastName Like '{d.LastName}' AND Specialty Like '{d.Specialty}'", conn);
            //  DataTable dt = new DataTable();
            // sda.Fill(dt);


            sda.Fill(Ids);

            //  string specialty = CboDoctor.Text.Trim(' ');
            //  MessageBox.Show(specialty);
            //Get the value from the input fields
            s.PatientId = int.Parse(TxtPatientId.Text);
            s.DoctorId = int.Parse(Ids.Rows[0]["DoctorId"].ToString());   // int.Parse(sda.ToString());

            s.Date = Convert.ToDateTime(DtpDate.Text);
            s.Time = Convert.ToDateTime(CboTime.Text);
            s.Reason = TxtReason.Text;


            //Inserting Data into database using the method
            bool success = s.Insert(s);
            if (success == true)
            {
                //Succesfully Inserted
                MessageBox.Show("New Schedule Successfully Inserted");
                Clear();
            }
            else
            {
                //Failed to add contact
                MessageBox.Show("Failed to add New Schedule. Try Again.");
            }

            //Load Data on Data Gridview
            DataTable dt = s.Select();
            DgvScheduleList.DataSource = dt;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {


            if (TxtScheduleId.Text != "")
            {
                // Get the data from textboxes
                s.ScheduleId = int.Parse(TxtScheduleId.Text);
                s.PatientId = int.Parse(TxtPatientId.Text);
                s.DoctorId = int.Parse(CboDoctor.Text);
                s.Date = Convert.ToDateTime(DtpDate.Text);
                s.Time = Convert.ToDateTime(CboTime.Text);
                s.Reason = TxtReason.Text;
            }


            //Update data in database
            bool success = s.Update(s);
            if (success)
            {
                //Updated successfully
                MessageBox.Show("Schedule has been successfully updated.");
                //Load Data on Data Gridview
                DataTable dt = s.Select();
                DgvScheduleList.DataSource = dt;
            }
            else
            {
                //Failed to Update
                MessageBox.Show("Failed to Update Schedule. Try Again.");
            }

            Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtScheduleId.Text != "")
            {
                // Get the data from textboxes
                s.ScheduleId = int.Parse(TxtScheduleId.Text);
            }

            bool success = s.Delete(s);
            if (success)
            {
                //Deleted successfully
                MessageBox.Show("Schedule has been successfully deleted.");
                //Load Data on Data Gridview
                DataTable dt = s.Select();
                DgvScheduleList.DataSource = dt;
                Clear();
            }
            else
            {
                //Failed to Delete
                MessageBox.Show("Failed to Delete Schedule. Try Again.");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            TxtScheduleId.Text = "";
            TxtPatientId.Text = "";
            CboDoctor.Text = "";
            DtpDate.Value = DateTime.Now;
            DtpDate.MinDate = DateTime.Today;
            CboTime.Text = "";
            TxtReason.Text = "";
        }

        private void DgvScheduleList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the Data From DataGrid View and Load it to the text boxes respectively
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;

            TxtScheduleId.Text = DgvScheduleList.Rows[rowIndex].Cells[0].Value.ToString();
            TxtPatientId.Text = DgvScheduleList.Rows[rowIndex].Cells[1].Value.ToString();
            CboDoctor.Text = DgvScheduleList.Rows[rowIndex].Cells[2].Value.ToString();

            DtpDate.MinDate = Convert.ToDateTime(DgvScheduleList.Rows[rowIndex].Cells[3].Value);

            DtpDate.Text = DgvScheduleList.Rows[rowIndex].Cells[3].Value.ToString();
            CboTime.Text = DgvScheduleList.Rows[rowIndex].Cells[4].Value.ToString();
            TxtReason.Text = DgvScheduleList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstring);




        public void DoctorInfos()
        {
            if (CboDoctor.Text != "")
            {
                string[] splittedCboText = CboDoctor.Text.Split(' ');

                d.Name = splittedCboText[0] + " " + splittedCboText[1];
                d.LastName = splittedCboText[2];
                d.Specialty = splittedCboText[3];
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from the textbox
            string keyword = TxtSearch.Text;
            

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TblSchedule WHERE PatientId Like '%" + keyword + "%' OR DoctorId Like '%" + keyword + "%'  OR Reason Like '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DgvScheduleList.DataSource = dt;
        }
    }
}
