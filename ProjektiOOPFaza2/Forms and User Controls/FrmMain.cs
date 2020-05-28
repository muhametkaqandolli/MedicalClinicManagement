using System;
using System.Windows.Forms;

namespace ProjektiOOPFaza2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();


        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {

            patientControl1.BringToFront();
        }

        private void BtnDoctor_Click(object sender, EventArgs e)
        {

            doctorControl1.BringToFront();
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            staffControl1.BringToFront();
        }

        private void BtnSchedule_Click(object sender, EventArgs e)
        {
            scheduleControl1.BringToFront();
        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            appointmentControl1.BringToFront();
        }
    }
}
