namespace ProjektiOOPFaza2
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button BtnSchedule;
        private System.Windows.Forms.Button BtnAppointment;
        private System.Windows.Forms.Button BtnStaff;
        private System.Windows.Forms.Button BtnDoctor;
        private System.Windows.Forms.Button BtnPatient;
        private System.Windows.Forms.Label LblTitle;
        public Forms_and_User_Controls.PatientControl patientControl1;
        private Forms_and_User_Controls.DoctorControl doctorControl1;
        private Forms_and_User_Controls.StaffControl staffControl1;
        private Forms_and_User_Controls.ScheduleControl scheduleControl1;
        private Forms_and_User_Controls.AppointmentControl appointmentControl1;
        private void InitializeComponent()
        {
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtnSchedule = new System.Windows.Forms.Button();
            this.BtnAppointment = new System.Windows.Forms.Button();
            this.BtnStaff = new System.Windows.Forms.Button();
            this.BtnDoctor = new System.Windows.Forms.Button();
            this.BtnPatient = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.staffControl1 = new ProjektiOOPFaza2.Forms_and_User_Controls.StaffControl();
            this.doctorControl1 = new ProjektiOOPFaza2.Forms_and_User_Controls.DoctorControl();
            this.patientControl1 = new ProjektiOOPFaza2.Forms_and_User_Controls.PatientControl();
            this.scheduleControl1 = new ProjektiOOPFaza2.Forms_and_User_Controls.ScheduleControl();
            this.appointmentControl1 = new ProjektiOOPFaza2.Forms_and_User_Controls.AppointmentControl();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.Panel1.Controls.Add(this.BtnSchedule);
            this.Panel1.Controls.Add(this.BtnAppointment);
            this.Panel1.Controls.Add(this.BtnStaff);
            this.Panel1.Controls.Add(this.BtnDoctor);
            this.Panel1.Controls.Add(this.BtnPatient);
            this.Panel1.Location = new System.Drawing.Point(-1, 95);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(217, 407);
            this.Panel1.TabIndex = 37;
            // 
            // BtnSchedule
            // 
            this.BtnSchedule.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.BtnSchedule.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSchedule.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnSchedule.FlatAppearance.BorderSize = 0;
            this.BtnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSchedule.Location = new System.Drawing.Point(3, 181);
            this.BtnSchedule.Name = "BtnSchedule";
            this.BtnSchedule.Size = new System.Drawing.Size(217, 50);
            this.BtnSchedule.TabIndex = 0;
            this.BtnSchedule.Text = "Schedule";
            this.BtnSchedule.UseVisualStyleBackColor = false;
            this.BtnSchedule.Click += new System.EventHandler(this.BtnSchedule_Click);
            // 
            // BtnAppointment
            // 
            this.BtnAppointment.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.BtnAppointment.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAppointment.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnAppointment.FlatAppearance.BorderSize = 0;
            this.BtnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppointment.Location = new System.Drawing.Point(3, 136);
            this.BtnAppointment.Name = "BtnAppointment";
            this.BtnAppointment.Size = new System.Drawing.Size(217, 50);
            this.BtnAppointment.TabIndex = 0;
            this.BtnAppointment.Text = "Appointment";
            this.BtnAppointment.UseVisualStyleBackColor = false;
            this.BtnAppointment.Click += new System.EventHandler(this.BtnAppointment_Click);
            // 
            // BtnStaff
            // 
            this.BtnStaff.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.BtnStaff.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnStaff.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnStaff.FlatAppearance.BorderSize = 0;
            this.BtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStaff.Location = new System.Drawing.Point(3, 90);
            this.BtnStaff.Name = "BtnStaff";
            this.BtnStaff.Size = new System.Drawing.Size(217, 50);
            this.BtnStaff.TabIndex = 0;
            this.BtnStaff.Text = "Staff";
            this.BtnStaff.UseVisualStyleBackColor = false;
            this.BtnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // BtnDoctor
            // 
            this.BtnDoctor.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.BtnDoctor.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDoctor.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnDoctor.FlatAppearance.BorderSize = 0;
            this.BtnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoctor.Location = new System.Drawing.Point(3, 46);
            this.BtnDoctor.Name = "BtnDoctor";
            this.BtnDoctor.Size = new System.Drawing.Size(217, 50);
            this.BtnDoctor.TabIndex = 0;
            this.BtnDoctor.Text = "Doctors";
            this.BtnDoctor.UseVisualStyleBackColor = false;
            this.BtnDoctor.Click += new System.EventHandler(this.BtnDoctor_Click);
            // 
            // BtnPatient
            // 
            this.BtnPatient.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.BtnPatient.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPatient.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnPatient.FlatAppearance.BorderSize = 0;
            this.BtnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatient.Location = new System.Drawing.Point(3, -1);
            this.BtnPatient.Name = "BtnPatient";
            this.BtnPatient.Size = new System.Drawing.Size(217, 50);
            this.BtnPatient.TabIndex = 0;
            this.BtnPatient.Text = "Patients";
            this.BtnPatient.UseVisualStyleBackColor = false;
            this.BtnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(347, 20);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(494, 37);
            this.LblTitle.TabIndex = 24;
            this.LblTitle.Text = "Welcome To Our Medical Clinic";
            // 
            // staffControl1
            // 
            this.staffControl1.Location = new System.Drawing.Point(213, 89);
            this.staffControl1.Name = "staffControl1";
            this.staffControl1.Size = new System.Drawing.Size(970, 413);
            this.staffControl1.TabIndex = 40;
            // 
            // doctorControl1
            // 
            this.doctorControl1.Location = new System.Drawing.Point(213, 89);
            this.doctorControl1.Name = "doctorControl1";
            this.doctorControl1.Size = new System.Drawing.Size(970, 410);
            this.doctorControl1.TabIndex = 39;
            // 
            // patientControl1
            // 
            this.patientControl1.Location = new System.Drawing.Point(213, 95);
            this.patientControl1.Name = "patientControl1";
            this.patientControl1.Size = new System.Drawing.Size(970, 410);
            this.patientControl1.TabIndex = 38;
            // 
            // scheduleControl1
            // 
            this.scheduleControl1.Location = new System.Drawing.Point(213, 92);
            this.scheduleControl1.Name = "scheduleControl1";
            this.scheduleControl1.Size = new System.Drawing.Size(970, 410);
            this.scheduleControl1.TabIndex = 41;
            // 
            // appointmentControl1
            // 
            this.appointmentControl1.Location = new System.Drawing.Point(213, 92);
            this.appointmentControl1.Name = "appointmentControl1";
            this.appointmentControl1.Size = new System.Drawing.Size(970, 410);
            this.appointmentControl1.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 501);
            this.Controls.Add(this.appointmentControl1);
            this.Controls.Add(this.scheduleControl1);
            this.Controls.Add(this.staffControl1);
            this.Controls.Add(this.doctorControl1);
            this.Controls.Add(this.patientControl1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.LblTitle);
            this.Name = "FrmMain";
            this.Text = "Medical Clinic Management";
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
    }
}

