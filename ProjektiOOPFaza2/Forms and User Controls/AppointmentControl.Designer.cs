namespace ProjektiOOPFaza2.Forms_and_User_Controls
{
    partial class AppointmentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtScheduleId = new System.Windows.Forms.TextBox();
            this.LblScheduleId = new System.Windows.Forms.Label();
            this.TxtAppointmentId = new System.Windows.Forms.TextBox();
            this.LblAppointmentId = new System.Windows.Forms.Label();
            this.TxtDiagnosis = new System.Windows.Forms.TextBox();
            this.LblDiagnosis = new System.Windows.Forms.Label();
            this.LblTreatment = new System.Windows.Forms.Label();
            this.TxtTreatment = new System.Windows.Forms.TextBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.DgvAppointmentList = new System.Windows.Forms.DataGridView();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LblServices = new System.Windows.Forms.Label();
            this.Chk1 = new System.Windows.Forms.CheckBox();
            this.Chk2 = new System.Windows.Forms.CheckBox();
            this.Chk3 = new System.Windows.Forms.CheckBox();
            this.Chk4 = new System.Windows.Forms.CheckBox();
            this.Chk5 = new System.Windows.Forms.CheckBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInvoice = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtScheduleId
            // 
            this.TxtScheduleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtScheduleId.Location = new System.Drawing.Point(144, 58);
            this.TxtScheduleId.Name = "TxtScheduleId";
            this.TxtScheduleId.Size = new System.Drawing.Size(205, 26);
            this.TxtScheduleId.TabIndex = 79;
            this.TxtScheduleId.Leave += new System.EventHandler(this.TxtScheduleId_Leave);
            // 
            // LblScheduleId
            // 
            this.LblScheduleId.AutoSize = true;
            this.LblScheduleId.BackColor = System.Drawing.Color.Transparent;
            this.LblScheduleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScheduleId.Location = new System.Drawing.Point(33, 62);
            this.LblScheduleId.Name = "LblScheduleId";
            this.LblScheduleId.Size = new System.Drawing.Size(84, 18);
            this.LblScheduleId.TabIndex = 77;
            this.LblScheduleId.Text = "Schedule Id";
            // 
            // TxtAppointmentId
            // 
            this.TxtAppointmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAppointmentId.Location = new System.Drawing.Point(144, 22);
            this.TxtAppointmentId.Name = "TxtAppointmentId";
            this.TxtAppointmentId.ReadOnly = true;
            this.TxtAppointmentId.Size = new System.Drawing.Size(205, 26);
            this.TxtAppointmentId.TabIndex = 80;
            // 
            // LblAppointmentId
            // 
            this.LblAppointmentId.AutoSize = true;
            this.LblAppointmentId.BackColor = System.Drawing.Color.Transparent;
            this.LblAppointmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppointmentId.Location = new System.Drawing.Point(33, 26);
            this.LblAppointmentId.Name = "LblAppointmentId";
            this.LblAppointmentId.Size = new System.Drawing.Size(105, 18);
            this.LblAppointmentId.TabIndex = 78;
            this.LblAppointmentId.Text = "Appointment Id";
            // 
            // TxtDiagnosis
            // 
            this.TxtDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiagnosis.Location = new System.Drawing.Point(144, 99);
            this.TxtDiagnosis.Multiline = true;
            this.TxtDiagnosis.Name = "TxtDiagnosis";
            this.TxtDiagnosis.Size = new System.Drawing.Size(205, 55);
            this.TxtDiagnosis.TabIndex = 89;
            // 
            // LblDiagnosis
            // 
            this.LblDiagnosis.AutoSize = true;
            this.LblDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.LblDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiagnosis.Location = new System.Drawing.Point(33, 103);
            this.LblDiagnosis.Name = "LblDiagnosis";
            this.LblDiagnosis.Size = new System.Drawing.Size(74, 18);
            this.LblDiagnosis.TabIndex = 88;
            this.LblDiagnosis.Text = "Diagnosis";
            // 
            // LblTreatment
            // 
            this.LblTreatment.AutoSize = true;
            this.LblTreatment.BackColor = System.Drawing.Color.Transparent;
            this.LblTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTreatment.Location = new System.Drawing.Point(33, 290);
            this.LblTreatment.Name = "LblTreatment";
            this.LblTreatment.Size = new System.Drawing.Size(75, 18);
            this.LblTreatment.TabIndex = 88;
            this.LblTreatment.Text = "Treatment";
            // 
            // TxtTreatment
            // 
            this.TxtTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTreatment.Location = new System.Drawing.Point(144, 286);
            this.TxtTreatment.Multiline = true;
            this.TxtTreatment.Name = "TxtTreatment";
            this.TxtTreatment.Size = new System.Drawing.Size(205, 53);
            this.TxtTreatment.TabIndex = 89;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(490, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(449, 26);
            this.TxtSearch.TabIndex = 96;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.BackColor = System.Drawing.Color.Transparent;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(396, 7);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(60, 20);
            this.LblSearch.TabIndex = 95;
            this.LblSearch.Text = "Search";
            this.LblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DgvAppointmentList
            // 
            this.DgvAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAppointmentList.Location = new System.Drawing.Point(400, 58);
            this.DgvAppointmentList.Name = "DgvAppointmentList";
            this.DgvAppointmentList.ReadOnly = true;
            this.DgvAppointmentList.Size = new System.Drawing.Size(539, 281);
            this.DgvAppointmentList.TabIndex = 94;
            this.DgvAppointmentList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAppointmentList_RowHeaderMouseClick);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Orange;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(866, 366);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(73, 35);
            this.BtnClear.TabIndex = 90;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Crimson;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(776, 366);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(73, 35);
            this.BtnDelete.TabIndex = 91;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(686, 366);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(73, 35);
            this.BtnUpdate.TabIndex = 92;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(593, 366);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(73, 35);
            this.BtnAdd.TabIndex = 93;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblServices
            // 
            this.LblServices.AutoSize = true;
            this.LblServices.BackColor = System.Drawing.Color.Transparent;
            this.LblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServices.Location = new System.Drawing.Point(34, 205);
            this.LblServices.Name = "LblServices";
            this.LblServices.Size = new System.Drawing.Size(65, 18);
            this.LblServices.TabIndex = 88;
            this.LblServices.Text = "Services";
            // 
            // Chk1
            // 
            this.Chk1.AutoSize = true;
            this.Chk1.Location = new System.Drawing.Point(144, 166);
            this.Chk1.Name = "Chk1";
            this.Chk1.Size = new System.Drawing.Size(15, 14);
            this.Chk1.TabIndex = 97;
            this.Chk1.UseVisualStyleBackColor = true;
            this.Chk1.CheckedChanged += new System.EventHandler(this.Chk1_CheckedChanged);
            // 
            // Chk2
            // 
            this.Chk2.AutoSize = true;
            this.Chk2.Location = new System.Drawing.Point(144, 189);
            this.Chk2.Name = "Chk2";
            this.Chk2.Size = new System.Drawing.Size(15, 14);
            this.Chk2.TabIndex = 98;
            this.Chk2.UseVisualStyleBackColor = true;
            this.Chk2.CheckedChanged += new System.EventHandler(this.Chk2_CheckedChanged);
            // 
            // Chk3
            // 
            this.Chk3.AutoSize = true;
            this.Chk3.Location = new System.Drawing.Point(144, 209);
            this.Chk3.Name = "Chk3";
            this.Chk3.Size = new System.Drawing.Size(15, 14);
            this.Chk3.TabIndex = 97;
            this.Chk3.UseVisualStyleBackColor = true;
            this.Chk3.CheckedChanged += new System.EventHandler(this.Chk3_CheckedChanged);
            // 
            // Chk4
            // 
            this.Chk4.AutoSize = true;
            this.Chk4.Location = new System.Drawing.Point(144, 232);
            this.Chk4.Name = "Chk4";
            this.Chk4.Size = new System.Drawing.Size(15, 14);
            this.Chk4.TabIndex = 98;
            this.Chk4.UseVisualStyleBackColor = true;
            this.Chk4.CheckedChanged += new System.EventHandler(this.Chk4_CheckedChanged);
            // 
            // Chk5
            // 
            this.Chk5.AutoSize = true;
            this.Chk5.Location = new System.Drawing.Point(144, 255);
            this.Chk5.Name = "Chk5";
            this.Chk5.Size = new System.Drawing.Size(15, 14);
            this.Chk5.TabIndex = 98;
            this.Chk5.UseVisualStyleBackColor = true;
            this.Chk5.CheckedChanged += new System.EventHandler(this.Chk5_CheckedChanged);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(34, 366);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(50, 18);
            this.PriceLbl.TabIndex = 88;
            this.PriceLbl.Text = "Price: ";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(141, 366);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(36, 18);
            this.LblPrice.TabIndex = 88;
            this.LblPrice.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 88;
            this.label1.Text = "€";
            // 
            // BtnInvoice
            // 
            this.BtnInvoice.BackColor = System.Drawing.Color.LightSalmon;
            this.BtnInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInvoice.ForeColor = System.Drawing.Color.White;
            this.BtnInvoice.Location = new System.Drawing.Point(490, 366);
            this.BtnInvoice.Name = "BtnInvoice";
            this.BtnInvoice.Size = new System.Drawing.Size(84, 35);
            this.BtnInvoice.TabIndex = 93;
            this.BtnInvoice.Text = "Invoices";
            this.BtnInvoice.UseVisualStyleBackColor = false;
            this.BtnInvoice.Click += new System.EventHandler(this.BtnInvoice_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(400, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 35);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AppointmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Chk5);
            this.Controls.Add(this.Chk4);
            this.Controls.Add(this.Chk3);
            this.Controls.Add(this.Chk2);
            this.Controls.Add(this.Chk1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.DgvAppointmentList);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.BtnInvoice);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtTreatment);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.LblTreatment);
            this.Controls.Add(this.TxtDiagnosis);
            this.Controls.Add(this.LblServices);
            this.Controls.Add(this.LblDiagnosis);
            this.Controls.Add(this.TxtScheduleId);
            this.Controls.Add(this.LblScheduleId);
            this.Controls.Add(this.TxtAppointmentId);
            this.Controls.Add(this.LblAppointmentId);
            this.Name = "AppointmentControl";
            this.Size = new System.Drawing.Size(970, 410);
            this.Load += new System.EventHandler(this.AppointmentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtScheduleId;
        private System.Windows.Forms.Label LblScheduleId;
        private System.Windows.Forms.TextBox TxtAppointmentId;
        private System.Windows.Forms.Label LblAppointmentId;
        private System.Windows.Forms.TextBox TxtDiagnosis;
        private System.Windows.Forms.Label LblDiagnosis;
        private System.Windows.Forms.Label LblTreatment;
        private System.Windows.Forms.TextBox TxtTreatment;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.DataGridView DgvAppointmentList;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LblServices;
        private System.Windows.Forms.CheckBox Chk1;
        private System.Windows.Forms.CheckBox Chk2;
        private System.Windows.Forms.CheckBox Chk3;
        private System.Windows.Forms.CheckBox Chk4;
        private System.Windows.Forms.CheckBox Chk5;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnInvoice;
        private System.Windows.Forms.Button btnSave;
    }
}
