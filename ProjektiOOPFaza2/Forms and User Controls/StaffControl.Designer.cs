namespace ProjektiOOPFaza2.Forms_and_User_Controls
{
    partial class StaffControl
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
            this.DtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.DgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CboGender = new System.Windows.Forms.ComboBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblBirthday = new System.Windows.Forms.Label();
            this.TxtPosition = new System.Windows.Forms.TextBox();
            this.LblPosition = new System.Windows.Forms.Label();
            this.TxtContactNo = new System.Windows.Forms.TextBox();
            this.LblContactNo = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtEmployeeId = new System.Windows.Forms.TextBox();
            this.LblEmployeeId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpBirthday
            // 
            this.DtpBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpBirthday.Location = new System.Drawing.Point(134, 149);
            this.DtpBirthday.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.DtpBirthday.Name = "DtpBirthday";
            this.DtpBirthday.Size = new System.Drawing.Size(205, 20);
            this.DtpBirthday.TabIndex = 108;
            this.DtpBirthday.Value = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(481, 10);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(449, 26);
            this.TxtSearch.TabIndex = 107;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.BackColor = System.Drawing.Color.Transparent;
            this.LblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(387, 13);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(60, 20);
            this.LblSearch.TabIndex = 106;
            this.LblSearch.Text = "Search";
            this.LblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DgvEmployeeList
            // 
            this.DgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmployeeList.Location = new System.Drawing.Point(391, 64);
            this.DgvEmployeeList.Name = "DgvEmployeeList";
            this.DgvEmployeeList.ReadOnly = true;
            this.DgvEmployeeList.Size = new System.Drawing.Size(539, 281);
            this.DgvEmployeeList.TabIndex = 105;
            this.DgvEmployeeList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEmployeeList_RowHeaderMouseClick);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Orange;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(824, 375);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(110, 35);
            this.BtnClear.TabIndex = 101;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Crimson;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(681, 375);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(110, 35);
            this.BtnDelete.TabIndex = 102;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(533, 375);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(110, 35);
            this.BtnUpdate.TabIndex = 103;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(389, 375);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 35);
            this.BtnAdd.TabIndex = 104;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CboGender
            // 
            this.CboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboGender.FormattingEnabled = true;
            this.CboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CboGender.Location = new System.Drawing.Point(134, 333);
            this.CboGender.Name = "CboGender";
            this.CboGender.Size = new System.Drawing.Size(205, 28);
            this.CboGender.TabIndex = 100;
            // 
            // TxtCity
            // 
            this.TxtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCity.Location = new System.Drawing.Point(134, 287);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(205, 26);
            this.TxtCity.TabIndex = 94;
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.BackColor = System.Drawing.Color.Transparent;
            this.LblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGender.Location = new System.Drawing.Point(38, 337);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(57, 18);
            this.LblGender.TabIndex = 86;
            this.LblGender.Text = "Gender";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.BackColor = System.Drawing.Color.Transparent;
            this.LblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCity.Location = new System.Drawing.Point(38, 291);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(33, 18);
            this.LblCity.TabIndex = 87;
            this.LblCity.Text = "City";
            // 
            // LblBirthday
            // 
            this.LblBirthday.AutoSize = true;
            this.LblBirthday.BackColor = System.Drawing.Color.Transparent;
            this.LblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBirthday.Location = new System.Drawing.Point(38, 149);
            this.LblBirthday.Name = "LblBirthday";
            this.LblBirthday.Size = new System.Drawing.Size(61, 18);
            this.LblBirthday.TabIndex = 90;
            this.LblBirthday.Text = "Birthday";
            // 
            // TxtPosition
            // 
            this.TxtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPosition.Location = new System.Drawing.Point(134, 191);
            this.TxtPosition.Name = "TxtPosition";
            this.TxtPosition.Size = new System.Drawing.Size(205, 26);
            this.TxtPosition.TabIndex = 95;
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.BackColor = System.Drawing.Color.Transparent;
            this.LblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPosition.Location = new System.Drawing.Point(37, 195);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(62, 18);
            this.LblPosition.TabIndex = 89;
            this.LblPosition.Text = "Position";
            // 
            // TxtContactNo
            // 
            this.TxtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContactNo.Location = new System.Drawing.Point(134, 238);
            this.TxtContactNo.Name = "TxtContactNo";
            this.TxtContactNo.Size = new System.Drawing.Size(205, 26);
            this.TxtContactNo.TabIndex = 96;
            // 
            // LblContactNo
            // 
            this.LblContactNo.AutoSize = true;
            this.LblContactNo.BackColor = System.Drawing.Color.Transparent;
            this.LblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactNo.Location = new System.Drawing.Point(37, 242);
            this.LblContactNo.Name = "LblContactNo";
            this.LblContactNo.Size = new System.Drawing.Size(84, 18);
            this.LblContactNo.TabIndex = 88;
            this.LblContactNo.Text = "Contact No";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.Location = new System.Drawing.Point(134, 104);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(205, 26);
            this.TxtLastName.TabIndex = 97;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.BackColor = System.Drawing.Color.Transparent;
            this.LblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName.Location = new System.Drawing.Point(37, 108);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(80, 18);
            this.LblLastName.TabIndex = 91;
            this.LblLastName.Text = "Last Name";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.Location = new System.Drawing.Point(134, 60);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(205, 26);
            this.TxtFirstName.TabIndex = 98;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.LblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstName.Location = new System.Drawing.Point(37, 64);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(81, 18);
            this.LblFirstName.TabIndex = 92;
            this.LblFirstName.Text = "First Name";
            // 
            // TxtEmployeeId
            // 
            this.TxtEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmployeeId.Location = new System.Drawing.Point(134, 14);
            this.TxtEmployeeId.Name = "TxtEmployeeId";
            this.TxtEmployeeId.ReadOnly = true;
            this.TxtEmployeeId.Size = new System.Drawing.Size(205, 26);
            this.TxtEmployeeId.TabIndex = 99;
            // 
            // LblEmployeeId
            // 
            this.LblEmployeeId.AutoSize = true;
            this.LblEmployeeId.BackColor = System.Drawing.Color.Transparent;
            this.LblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeId.Location = new System.Drawing.Point(37, 18);
            this.LblEmployeeId.Name = "LblEmployeeId";
            this.LblEmployeeId.Size = new System.Drawing.Size(89, 18);
            this.LblEmployeeId.TabIndex = 93;
            this.LblEmployeeId.Text = "Employee Id";
            // 
            // StaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DtpBirthday);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.DgvEmployeeList);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CboGender);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.LblBirthday);
            this.Controls.Add(this.TxtPosition);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.TxtContactNo);
            this.Controls.Add(this.LblContactNo);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.TxtEmployeeId);
            this.Controls.Add(this.LblEmployeeId);
            this.Name = "StaffControl";
            this.Size = new System.Drawing.Size(970, 420);
            this.Load += new System.EventHandler(this.StaffControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpBirthday;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.DataGridView DgvEmployeeList;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CboGender;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblBirthday;
        private System.Windows.Forms.TextBox TxtPosition;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.TextBox TxtContactNo;
        private System.Windows.Forms.Label LblContactNo;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TextBox TxtEmployeeId;
        private System.Windows.Forms.Label LblEmployeeId;
    }
}
