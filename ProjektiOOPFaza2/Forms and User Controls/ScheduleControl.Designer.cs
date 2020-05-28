namespace ProjektiOOPFaza2.Forms_and_User_Controls
{
    partial class ScheduleControl
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
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.DgvScheduleList = new System.Windows.Forms.DataGridView();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblDoctor = new System.Windows.Forms.Label();
            this.TxtPatientId = new System.Windows.Forms.TextBox();
            this.LblPatientId = new System.Windows.Forms.Label();
            this.TxtScheduleId = new System.Windows.Forms.TextBox();
            this.LblScheduleId = new System.Windows.Forms.Label();
            this.CboDoctor = new System.Windows.Forms.ComboBox();
            this.LblTime = new System.Windows.Forms.Label();
            this.CboTime = new System.Windows.Forms.ComboBox();
            this.TxtReason = new System.Windows.Forms.TextBox();
            this.LblReason = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvScheduleList)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpDate
            // 
            this.DtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate.CustomFormat = "dd MMMM yyyy";
            this.DtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DtpDate.Location = new System.Drawing.Point(135, 140);
            this.DtpDate.MaxDate = new System.DateTime(2700, 12, 28, 0, 0, 0, 0);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(205, 26);
            this.DtpDate.TabIndex = 85;
            this.DtpDate.Value = new System.DateTime(2019, 12, 27, 0, 0, 0, 0);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(482, 7);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(449, 26);
            this.TxtSearch.TabIndex = 84;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.BackColor = System.Drawing.Color.Transparent;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(388, 10);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(60, 20);
            this.LblSearch.TabIndex = 83;
            this.LblSearch.Text = "Search";
            this.LblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DgvScheduleList
            // 
            this.DgvScheduleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvScheduleList.Location = new System.Drawing.Point(392, 61);
            this.DgvScheduleList.Name = "DgvScheduleList";
            this.DgvScheduleList.ReadOnly = true;
            this.DgvScheduleList.Size = new System.Drawing.Size(539, 281);
            this.DgvScheduleList.TabIndex = 82;
            this.DgvScheduleList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvScheduleList_RowHeaderMouseClick);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Orange;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(823, 369);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(110, 35);
            this.BtnClear.TabIndex = 78;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Crimson;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(680, 369);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(110, 35);
            this.BtnDelete.TabIndex = 79;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(532, 369);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 35);
            this.BtnUpdate.TabIndex = 80;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(388, 369);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 35);
            this.BtnAdd.TabIndex = 81;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(39, 146);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(39, 18);
            this.LblDate.TabIndex = 68;
            this.LblDate.Text = "Date";
            // 
            // LblDoctor
            // 
            this.LblDoctor.AutoSize = true;
            this.LblDoctor.BackColor = System.Drawing.Color.Transparent;
            this.LblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDoctor.Location = new System.Drawing.Point(38, 105);
            this.LblDoctor.Name = "LblDoctor";
            this.LblDoctor.Size = new System.Drawing.Size(54, 18);
            this.LblDoctor.TabIndex = 69;
            this.LblDoctor.Text = "Doctor";
            // 
            // TxtPatientId
            // 
            this.TxtPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPatientId.Location = new System.Drawing.Point(135, 57);
            this.TxtPatientId.Name = "TxtPatientId";
            this.TxtPatientId.Size = new System.Drawing.Size(205, 26);
            this.TxtPatientId.TabIndex = 75;
            // 
            // LblPatientId
            // 
            this.LblPatientId.AutoSize = true;
            this.LblPatientId.BackColor = System.Drawing.Color.Transparent;
            this.LblPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientId.Location = new System.Drawing.Point(38, 61);
            this.LblPatientId.Name = "LblPatientId";
            this.LblPatientId.Size = new System.Drawing.Size(68, 18);
            this.LblPatientId.TabIndex = 70;
            this.LblPatientId.Text = "Patient Id";
            // 
            // TxtScheduleId
            // 
            this.TxtScheduleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtScheduleId.Location = new System.Drawing.Point(135, 11);
            this.TxtScheduleId.Name = "TxtScheduleId";
            this.TxtScheduleId.ReadOnly = true;
            this.TxtScheduleId.Size = new System.Drawing.Size(205, 26);
            this.TxtScheduleId.TabIndex = 76;
            // 
            // LblScheduleId
            // 
            this.LblScheduleId.AutoSize = true;
            this.LblScheduleId.BackColor = System.Drawing.Color.Transparent;
            this.LblScheduleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScheduleId.Location = new System.Drawing.Point(38, 15);
            this.LblScheduleId.Name = "LblScheduleId";
            this.LblScheduleId.Size = new System.Drawing.Size(84, 18);
            this.LblScheduleId.TabIndex = 71;
            this.LblScheduleId.Text = "Schedule Id";
            // 
            // CboDoctor
            // 
            this.CboDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboDoctor.FormattingEnabled = true;
            this.CboDoctor.Items.AddRange(new object[] {
            "Dr. Uilliam Smith Kardiolog",
            "Dr. Barry Allen Radiolog",
            "Dr. Oliver Queen Dermatolog",
            "Dr. Emilia Blevins Estetik",
            "Dr. Caitlin Snow Reumatolog"});
            this.CboDoctor.Location = new System.Drawing.Point(135, 101);
            this.CboDoctor.Name = "CboDoctor";
            this.CboDoctor.Size = new System.Drawing.Size(205, 28);
            this.CboDoctor.TabIndex = 77;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.BackColor = System.Drawing.Color.Transparent;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.Location = new System.Drawing.Point(39, 187);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(41, 18);
            this.LblTime.TabIndex = 68;
            this.LblTime.Text = "Time";
            // 
            // CboTime
            // 
            this.CboTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTime.FormattingEnabled = true;
            this.CboTime.Items.AddRange(new object[] {
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30"});
            this.CboTime.Location = new System.Drawing.Point(135, 183);
            this.CboTime.Name = "CboTime";
            this.CboTime.Size = new System.Drawing.Size(205, 28);
            this.CboTime.TabIndex = 77;
            // 
            // TxtReason
            // 
            this.TxtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReason.Location = new System.Drawing.Point(135, 232);
            this.TxtReason.Multiline = true;
            this.TxtReason.Name = "TxtReason";
            this.TxtReason.Size = new System.Drawing.Size(205, 91);
            this.TxtReason.TabIndex = 87;
            // 
            // LblReason
            // 
            this.LblReason.AutoSize = true;
            this.LblReason.BackColor = System.Drawing.Color.Transparent;
            this.LblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReason.Location = new System.Drawing.Point(39, 236);
            this.LblReason.Name = "LblReason";
            this.LblReason.Size = new System.Drawing.Size(60, 18);
            this.LblReason.TabIndex = 86;
            this.LblReason.Text = "Reason";
            // 
            // ScheduleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtReason);
            this.Controls.Add(this.LblReason);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.DgvScheduleList);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CboDoctor);
            this.Controls.Add(this.CboTime);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblDoctor);
            this.Controls.Add(this.TxtPatientId);
            this.Controls.Add(this.LblPatientId);
            this.Controls.Add(this.TxtScheduleId);
            this.Controls.Add(this.LblScheduleId);
            this.Name = "ScheduleControl";
            this.Size = new System.Drawing.Size(970, 410);
            this.Load += new System.EventHandler(this.ScheduleControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvScheduleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.DataGridView DgvScheduleList;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblDoctor;
        private System.Windows.Forms.TextBox TxtPatientId;
        private System.Windows.Forms.Label LblPatientId;
        private System.Windows.Forms.TextBox TxtScheduleId;
        private System.Windows.Forms.Label LblScheduleId;
        private System.Windows.Forms.ComboBox CboDoctor;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.ComboBox CboTime;
        private System.Windows.Forms.TextBox TxtReason;
        private System.Windows.Forms.Label LblReason;
    }
}
