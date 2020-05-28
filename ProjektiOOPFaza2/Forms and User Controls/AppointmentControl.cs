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
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace ProjektiOOPFaza2.Forms_and_User_Controls
{
    public partial class AppointmentControl : UserControl
    {
        public AppointmentControl()
        {
            InitializeComponent();
        }

        Doctor d = new Doctor();
        Appointment a = new Appointment();
        string chk1, chk2, chk3, chk4, chk5;
        string[] services = new string[] { };

        DataTable TblSpecialty = new DataTable();
        DataTable InvoiceData = new DataTable();

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            a.ScheduleId = int.Parse(TxtScheduleId.Text);
            a.Diagnosis = TxtDiagnosis.Text;

            a.Services = chk1 + chk2 + chk3 + chk4 + chk5;
            a.Treatment = TxtTreatment.Text;
            a.Price = Convert.ToDecimal(LblPrice.Text);

            //Inserting Data into database using the method
            bool success = a.Insert(a);
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
            DataTable dt = a.Select();
            DgvAppointmentList.DataSource = dt;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {


            if (TxtAppointmentId.Text != "")
            {
                // Get the data from textboxes
                a.AppointmentId = int.Parse(TxtAppointmentId.Text);
                a.ScheduleId = int.Parse(TxtScheduleId.Text);
                a.Diagnosis = TxtDiagnosis.Text;
                a.Services = chk1 + chk2 + chk3 + chk4 + chk5;

                a.Treatment = TxtTreatment.Text;
                a.Price = Convert.ToDecimal(LblPrice.Text);
            }


            //Update data in database
            bool success = a.Update(a);
            if (success)
            {
                //Updated successfully
                MessageBox.Show("Schedule has been successfully updated.");
                //Load Data on Data Gridview
                DataTable dt = a.Select();
                DgvAppointmentList.DataSource = dt;
            }
            else
            {
                //Failed to Update
                MessageBox.Show("Failed to Update Schedule. Try Again.");
            }

            Clear();
        }



        private void TxtScheduleId_Leave(object sender, EventArgs e)
        {
            TblSpecialty.Reset();
            if (TxtScheduleId.Text != "")
            {
                try
                {
                    GetSpecialtyFromScheduleId();
                }
                catch (Exception)
                {

                    MessageBox.Show("There is no schedule with this Schedule Id!! \nPlease type a valid Schedule Id.");
                }

                AssignValuesToCheckBoxes();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtScheduleId.Text != "")
            {
                // Get the data from textboxes
                a.AppointmentId = int.Parse(TxtAppointmentId.Text);
            }

            bool success = a.Delete(a);
            if (success)
            {
                //Deleted successfully
                MessageBox.Show("Schedule has been successfully deleted.");
                //Load Data on Data Gridview
                DataTable dt = a.Select();
                DgvAppointmentList.DataSource = dt;
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

        private void AppointmentControl_Load(object sender, EventArgs e)
        {
            DataTable dt = a.Select();
            DgvAppointmentList.DataSource = dt;


            a.Price = 0.00m;

        }

        private void Chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk1.Checked == true)
            {
                chk1 = Chk1.Text;
            }
            else
            {
                chk1 = "";
            }
            if (d.Specialty == "Kardiolog")
            {
                if (Chk1.Checked == true)
                {
                    a.Price += 10;

                }
                else
                {
                    a.Price -= 10;

                }
            }
            if (d.Specialty == "Radiolog")
            {
                if (Chk1.Checked == true)
                {
                    a.Price += 15;
                }
                else
                {
                    a.Price -= 15;
                }
            }
            if (d.Specialty == "Dermatolog")
            {
                if (Chk1.Checked == true)
                {
                    a.Price += 15;
                }
                else
                {
                    a.Price -= 15;
                }
            }
            if (d.Specialty == "Reumatolog")
            {
                if (Chk1.Checked == true)
                {
                    a.Price += 30;
                }
                else
                {
                    a.Price -= 30;
                }
            }
            if (d.Specialty == "Estetik")
            {
                if (Chk1.Checked == true)
                {
                    a.Price += 40;
                }
                else
                {
                    a.Price -= 40;
                }
            }

            LblPrice.Text = a.Price.ToString();
        }

        private void Chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk2.Checked == true)
            {
                chk2 = Chk2.Text;
            }
            else
            {
                chk2 = "";
            }
            if (d.Specialty == "Kardiolog")
            {
                if (Chk2.Checked == true)
                {
                    a.Price += 15;
                }
                else
                {
                    a.Price -= 15;
                }
            }
            if (d.Specialty == "Radiolog")
            {
                if (Chk2.Checked == true)
                {
                    a.Price += 15;
                }
                else
                {
                    a.Price -= 15;
                }
            }
            if (d.Specialty == "Dermatolog")
            {
                if (Chk2.Checked == true)
                {
                    a.Price += 15;
                }
                else
                {
                    a.Price -= 15;
                }
            }
            if (d.Specialty == "Reumatolog")
            {
                if (Chk2.Checked == true)
                {
                    a.Price += 30;
                }
                else
                {
                    a.Price -= 30;
                }
            }
            if (d.Specialty == "Estetik")
            {
                if (Chk2.Checked == true)
                {
                    a.Price += 50;
                }
                else
                {
                    a.Price -= 50;
                }
            }
            LblPrice.Text = a.Price.ToString();
        }

        private void Chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk1.Checked == true)
            {
                chk3 = Chk3.Text;
            }
            else
            {
                chk3 = "";
            }
            if (d.Specialty == "Kardiolog")
            {
                if (Chk3.Checked == true)
                {
                    a.Price += 20;
                }
                else
                {
                    a.Price -= 20;
                }
            }
            if (d.Specialty == "Radiolog")
            {
                if (Chk3.Checked == true)
                {
                    a.Price += 20;
                }
                else
                {
                    a.Price -= 20;
                }
            }
            if (d.Specialty == "Dermatolog")
            {
                if (Chk3.Checked == true)
                {
                    a.Price += 20;
                }
                else
                {
                    a.Price -= 20;
                }
            }
            if (d.Specialty == "Reumatolog")
            {
                if (Chk3.Checked == true)
                {
                    a.Price += 25;
                }
                else
                {
                    a.Price -= 25;
                }
            }
            if (d.Specialty == "Estetik")
            {
                if (Chk3.Checked == true)
                {
                    a.Price += 45;
                }
                else
                {
                    a.Price -= 45;
                }
            }
            LblPrice.Text = a.Price.ToString();
        }

        private void Chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk4.Checked == true)
            {
                chk4 = Chk4.Text;
            }
            else
            {
                chk4 = "";
            }
            if (d.Specialty == "Kardiolog")
            {
                if (Chk4.Checked == true)
                {
                    a.Price += 25;
                }
                else
                {
                    a.Price -= 25;
                }
            }
            if (d.Specialty == "Radiolog")
            {
                if (Chk4.Checked == true)
                {
                    a.Price += 30;
                }
                else
                {
                    a.Price -= 30;
                }
            }
            if (d.Specialty == "Dermatolog")
            {
                if (Chk4.Checked == true)
                {
                    a.Price += 20;
                }
                else
                {
                    a.Price -= 20;
                }
            }
            if (d.Specialty == "Reumatolog")
            {
                if (Chk4.Checked == true)
                {
                    a.Price += 20;
                }
                else
                {
                    a.Price -= 20;
                }
            }
            if (d.Specialty == "Estetik")
            {
                if (Chk4.Checked == true)
                {
                    a.Price += 35;
                }
                else
                {
                    a.Price -= 35;
                }
            }
            LblPrice.Text = a.Price.ToString();
        }

        private void DgvAppointmentList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the Data From DataGrid View and Load it to the text boxes respectively
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;


            TxtAppointmentId.Text = DgvAppointmentList.Rows[rowIndex].Cells[0].Value.ToString();
            TxtScheduleId.Text = DgvAppointmentList.Rows[rowIndex].Cells[1].Value.ToString();
            TxtDiagnosis.Text = DgvAppointmentList.Rows[rowIndex].Cells[2].Value.ToString();

            services = DgvAppointmentList.Rows[rowIndex].Cells[3].Value.ToString().Split(' ');

            ServicesToCheckBoxes();

            TxtTreatment.Text = DgvAppointmentList.Rows[rowIndex].Cells[4].Value.ToString();
            LblPrice.Text = DgvAppointmentList.Rows[rowIndex].Cells[5].Value.ToString();

           // DgvAppointmentList.DataSource = TblSpecialty;
        }

        private void Chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk5.Checked == true)
            {
                chk5 = Chk5.Text;
            }
            else
            {
                chk5 = "";
            }
            if (d.Specialty == "Kardiolog")
            {
                if (Chk5.Checked == true)
                {
                    a.Price += 30;
                }
                else
                {
                    a.Price -= 30;
                }
            }
            if (d.Specialty == "Radiolog")
            {
                if (Chk5.Checked == true)
                {
                    a.Price += 12;
                }
                else
                {
                    a.Price -= 12;
                }
            }
            if (d.Specialty == "Dermatolog")
            {
                if (Chk5.Checked == true)
                {
                    a.Price += 40;
                }
                else
                {
                    a.Price -= 40;
                }
            }
            if (d.Specialty == "Reumatolog")
            {
                if (Chk5.Checked == true)
                {
                    a.Price += 15;
                }
                else
                {
                    a.Price -= 15;
                }
            }
            if (d.Specialty == "Estetik")
            {
                if (Chk5.Checked == true)
                {
                    a.Price += 25;
                }
                else
                {
                    a.Price -= 25;
                }
            }

            LblPrice.Text = a.Price.ToString();
        }

        private void BtnInvoice_Click(object sender, EventArgs e)
        {
            GetInvoiceDataFromSql();
            DgvAppointmentList.DataSource = InvoiceData;
        }

        public void Clear()
        {
            TxtAppointmentId.Text = "";
            TxtScheduleId.Text = "";
            TxtDiagnosis.Text = "";
            Chk1.Checked = false;
            Chk2.Checked = false;
            Chk3.Checked = false;
            Chk4.Checked = false;
            Chk5.Checked = false;
            TxtTreatment.Text = "";
            LblPrice.Text = "0.00";
            a.Price = 0.00m;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the value from the textbox
            string keyword = TxtSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstring);

           // string sql = "SELECT * FROM TblAppointment, TblSchedule WHERE TblAppointment.ScheduleId = TblSchedule.ScheduleId AND  (PatientId Like '%" + keyword + "%' OR DoctorId Like '%" + keyword + "%'  OR Diagnosis Like '%" + keyword + "%'  OR Treatment Like '%" + keyword + "%')";
           
            string sql = "SELECT TblAppointment.AppointmentId, TblPatient.PatientId, TblPatient.FirstName, TblPatient.LastName, TblDoctor.DoctorId, TblDoctor.FirstName, TblDoctor.LastName, TblDoctor.Specialty, TblAppointment.Diagnosis, TblAppointment.Services, TblAppointment.Treatment, TblAppointment.Price " +
                " FROM TblAppointment, TblSchedule, TblPatient, TblDoctor " +
                " WHERE TblSchedule.ScheduleId = TblAppointment.ScheduleId AND TblPatient.PatientId = TblSchedule.PatientId AND TblDoctor.DoctorId = TblSchedule.DoctorId AND " +
                " (TblSchedule.PatientId Like '%" + keyword + "%' OR TblSchedule.DoctorId Like '%" + keyword + "%'  OR Diagnosis Like '%" + keyword + "%'  OR Treatment Like '%" + keyword + "%' OR  TblPatient.FirstName Like '%" + keyword + "%' )";
            SqlCommand cmd = new SqlCommand(sql, conn);
            
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DgvAppointmentList.DataSource = dt;
        }
        
        string file = @"C:\ClinicInvoices\Invoices.txt";
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            TextWriter tw = new StreamWriter(file);

            for (int i = 0; i < DgvAppointmentList.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DgvAppointmentList.Columns.Count; j++)
                {
                    tw.Write(DgvAppointmentList.Columns[j].Name.ToString() + ": \t" + DgvAppointmentList.Rows[i].Cells[j].Value.ToString()+"\n");
                }
                tw.WriteLine("");
                tw.WriteLine("-------------------------------------------------------------");
            }
            tw.Close();
            MessageBox.Show("Invoice is saved.");
        }

        private void AssignValuesToCheckBoxes()
        {
            if (d.Specialty == "Kardiolog")
            {
                Chk1.Text = "EKG ";
                Chk2.Text = "Ekografi ";
                Chk3.Text = "Eko karotidesh ";
                Chk4.Text = "Holter ritmi ";
                Chk5.Text = "Holter tensioni ";
            }
            else if (d.Specialty == "Radiolog")
            {
                Chk1.Text = "Rrezet X ";
                Chk2.Text = "Rezonance magnetike ";
                Chk3.Text = "Ultratingujt ";
                Chk4.Text = "Tomografi kompjuterike ";
                Chk5.Text = "Tomografi te pozitronit ";
            }
            else if (d.Specialty == "Estetik")
            {
                Chk1.Text = "Filler ";
                Chk2.Text = "Botox ";
                Chk3.Text = "Ultherapy ";
                Chk4.Text = "Peeling kimik ";
                Chk5.Text = "Depilim i perhershem ";
            }
            else if (d.Specialty == "Reumatolog")
            {
                Chk1.Text = "TAC ";
                Chk2.Text = "Radiografia ";
                Chk3.Text = "Testet e gjakut ";
                Chk4.Text = "Testet e urines ";
                Chk5.Text = "Ekografia osteoartikulare ";
            }
            else if (d.Specialty == "Dermatolog")
            {
                Chk1.Text = "Trajtim kondilomash ";
                Chk2.Text = "Heqje nishanesh ";
                Chk3.Text = "Eleminim i njollave ";
                Chk4.Text = "Keratoza ";
                Chk5.Text = "Lipoma ";
            }
        }
        private void GetInvoiceDataFromSql()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            string sql = "SELECT TblAppointment.AppointmentId, TblPatient.PatientId, TblPatient.FirstName, TblPatient.LastName, TblDoctor.DoctorId, TblDoctor.FirstName, TblDoctor.LastName, TblDoctor.Specialty, TblAppointment.Diagnosis, TblAppointment.Services, TblAppointment.Treatment, TblAppointment.Price " +
                " FROM TblAppointment, TblSchedule, TblPatient, TblDoctor " +
                " WHERE TblSchedule.ScheduleId = TblAppointment.ScheduleId AND TblPatient.PatientId = TblSchedule.PatientId AND TblDoctor.DoctorId = TblSchedule.DoctorId";

            SqlDataAdapter InvoiceAdapter = new SqlDataAdapter(sql, conn);
            InvoiceAdapter.Fill(InvoiceData);

            
        }
        private void GetSpecialtyFromScheduleId()
        {

            SqlConnection conn = new SqlConnection(myconnstring);

            string sql = "SELECT DoctorId FROM TblSchedule WHERE ScheduleId=@ScheduleId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            string sql2 = "SELECT Specialty FROM TblDoctor WHERE DoctorId=@DoctorId";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);



            cmd.Parameters.AddWithValue("@ScheduleId", int.Parse(TxtScheduleId.Text));
            adapter.Fill(TblSpecialty);




            if (TblSpecialty.Rows[0]["DoctorId"].ToString() != "")
            {
                d.DoctorId = int.Parse(TblSpecialty.Rows[0]["DoctorId"].ToString());
            }


            cmd2.Parameters.AddWithValue("@DoctorId", d.DoctorId);
            adapter2.Fill(TblSpecialty);

            //counter++;
            //MessageBox.Show("Specialty is " + d.Specialty);
            d.Specialty = TblSpecialty.Rows[TblSpecialty.Rows.Count - 1]["Specialty"].ToString();
        }
        private void ServicesToCheckBoxes()
        {
            TblSpecialty.Reset();
            GetSpecialtyFromScheduleId();
            AssignValuesToCheckBoxes();

            if (d.Specialty == "Kardiolog")
            {
               
                    foreach (var item in services)
                    {
                        if (item == "EKG") { Chk1.Checked = true; break; } else { Chk1.Checked = false; }
                    }
                    foreach (var item in services)
                    {
                        if (item == "Ekografi") { Chk2.Checked = true; break; } else { Chk2.Checked = false; }
                    }
                    foreach (var item in services)
                    {
                        if (item == "karotidesh") { Chk3.Checked = true; break; } else { Chk3.Checked = false; }
                    }
                    foreach (var item in services)
                    {
                        if(item == "ritmi") { Chk4.Checked = true; break; } else { Chk4.Checked = false; }
                    }
                    foreach (var item in services)
                    {
                        if (item == "tensioni") { Chk5.Checked = true; break; } else { Chk5.Checked = false; }
                    }

            }
            else if (d.Specialty == "Estetik")
            {
                foreach (var item in services)
                {
                    if (item == "Filler") { Chk1.Checked = true; break; } else { Chk1.Checked = false; }
                }
                foreach (var item in services)
                {
                    if (item == "Botox") { Chk2.Checked = true; break; } else { Chk2.Checked = false; }
                }
                foreach (var item in services)
                {
                    if (item == "Ultherapy") { Chk3.Checked = true; break; } else { Chk3.Checked = false; }
                }
                foreach (var item in services)
                {
                    if (item == "Peeling") { Chk4.Checked = true; break; } else { Chk4.Checked = false; }
                }
                foreach (var item in services)
                {
                    if (item == "perhershem") { Chk5.Checked = true; break; } else { Chk5.Checked = false; }
                }
                //foreach (var item in services)
                //{
                //  if (item == "Filler") { Chk1.Checked = true; } else { Chk1.Checked = false; }
                //    if (item == "Botox") { Chk2.Checked = true; } else { Chk2.Checked = false; }
                //    if (item == "Ultherapy") { Chk3.Checked = true; } else { Chk3.Checked = false; }
                //    if (item == "Peeling") { Chk4.Checked = true; } else { Chk4.Checked = false; }
                //    if (item == "perhershem") { Chk5.Checked = true; } else { Chk5.Checked = false; }

                //}
            }
            else if (d.Specialty == "Dermatolog")
                {

                foreach (var item in services)
                {
                    if (item == "kondilomash") { Chk1.Checked = true; break; } else { Chk1.Checked = false; }
                }
                foreach (var item in services)
                {
                    if (item == "nishanesh") { Chk2.Checked = true; break; } else { Chk2.Checked = false; }
                }
                foreach (var item in services)
                {
                    if (item == "njollave") { Chk3.Checked = true; break; } else { Chk3.Checked = false; }
                }
                foreach (var item in services)
                {
                    if (item == "Keratoza") { Chk4.Checked = true; break; } else { Chk4.Checked = false; }
                }
                foreach (var item in services)
                {
                    if (item == "Lipoma") { Chk5.Checked = true; break; } else { Chk5.Checked = false; }
                }
               
                }
            else if (d.Specialty == "Reumatolog")
                {

                foreach (var item in services)
                {
                    if (item == "TAC") { Chk1.Checked = true; break; } else { Chk1.Checked = false; }
                }
                foreach (var item in services)
                {
                    if (item == "Radiografia") { Chk2.Checked = true; break; } else { Chk2.Checked = false; }
                }
                foreach (var item in services)
                {
                    if (item == "gjakut") { Chk3.Checked = true; break; } else { Chk3.Checked = false; }
                }
                foreach (var item in services)
                {
                    if (item == "urines") { Chk4.Checked = true; break; } else { Chk4.Checked = false; }
                }
                foreach (var item in services)
                {
                    if (item == "osteoartikulare") { Chk5.Checked = true; break; } else { Chk5.Checked = false; }
                }
}
            else if (d.Specialty == "Radiolog")
                {
                    foreach (var item in services)
                    {
                    if (item == "X") { Chk1.Checked = true; break; } else { Chk1.Checked = false; }
                    if (item == "magnetike") { Chk2.Checked = true; break; } else { Chk2.Checked = false; }
                    if (item == "Ultratingujt") { Chk3.Checked = true; break; } else { Chk3.Checked = false; }
                    if (item == "kompjuterike") { Chk4.Checked = true; break; } else { Chk4.Checked = false; }
                    if (item == "pozitronit") { Chk5.Checked = true; break; } else { Chk5.Checked = false; }
                }
                }
            }

        }
    }
