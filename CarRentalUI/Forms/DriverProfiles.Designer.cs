
namespace CarRentalUI.Forms
{
    partial class DriverProfiles
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
        private void InitializeComponent()
        {
            this.lblProfileHeader = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnDriverEdit = new System.Windows.Forms.Button();
            this.btnGridDrivers = new System.Windows.Forms.Button();
            this.tbGridDriversSearch = new System.Windows.Forms.TextBox();
            this.lblGridDrivers = new System.Windows.Forms.Label();
            this.gridDrivers = new System.Windows.Forms.DataGridView();
            this.lblQualifications = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridQualifications = new System.Windows.Forms.DataGridView();
            this.lblTraining = new System.Windows.Forms.Label();
            this.gridTraining = new System.Windows.Forms.DataGridView();
            this.lblTrainingSessions = new System.Windows.Forms.Label();
            this.gridTrainingSessions = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.tbHoursWorked = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblLicenceExpiration = new System.Windows.Forms.Label();
            this.lblLicenceNumber = new System.Windows.Forms.Label();
            this.tbLicenceExpiration = new System.Windows.Forms.TextBox();
            this.tbLicenceNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQualifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrainingSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfileHeader
            // 
            this.lblProfileHeader.AutoSize = true;
            this.lblProfileHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileHeader.Location = new System.Drawing.Point(558, 9);
            this.lblProfileHeader.Name = "lblProfileHeader";
            this.lblProfileHeader.Size = new System.Drawing.Size(162, 25);
            this.lblProfileHeader.TabIndex = 2;
            this.lblProfileHeader.Text = "Driver Profiles";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(689, 412);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(91, 23);
            this.btnClearSearch.TabIndex = 104;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnDriverEdit
            // 
            this.btnDriverEdit.Location = new System.Drawing.Point(563, 412);
            this.btnDriverEdit.Name = "btnDriverEdit";
            this.btnDriverEdit.Size = new System.Drawing.Size(120, 23);
            this.btnDriverEdit.TabIndex = 103;
            this.btnDriverEdit.Text = "Select Driver";
            this.btnDriverEdit.UseVisualStyleBackColor = true;
            this.btnDriverEdit.Click += new System.EventHandler(this.btnDriverEdit_Click);
            // 
            // btnGridDrivers
            // 
            this.btnGridDrivers.Location = new System.Drawing.Point(1177, 87);
            this.btnGridDrivers.Name = "btnGridDrivers";
            this.btnGridDrivers.Size = new System.Drawing.Size(97, 23);
            this.btnGridDrivers.TabIndex = 100;
            this.btnGridDrivers.Text = "Search";
            this.btnGridDrivers.UseVisualStyleBackColor = true;
            this.btnGridDrivers.Click += new System.EventHandler(this.btnGridDrivers_Click);
            // 
            // tbGridDriversSearch
            // 
            this.tbGridDriversSearch.Location = new System.Drawing.Point(704, 90);
            this.tbGridDriversSearch.MaxLength = 25;
            this.tbGridDriversSearch.Name = "tbGridDriversSearch";
            this.tbGridDriversSearch.Size = new System.Drawing.Size(467, 20);
            this.tbGridDriversSearch.TabIndex = 99;
            // 
            // lblGridDrivers
            // 
            this.lblGridDrivers.AutoSize = true;
            this.lblGridDrivers.Location = new System.Drawing.Point(560, 93);
            this.lblGridDrivers.Name = "lblGridDrivers";
            this.lblGridDrivers.Size = new System.Drawing.Size(138, 13);
            this.lblGridDrivers.TabIndex = 98;
            this.lblGridDrivers.Text = "Lookup a driver: (last name)";
            // 
            // gridDrivers
            // 
            this.gridDrivers.AllowUserToAddRows = false;
            this.gridDrivers.AllowUserToDeleteRows = false;
            this.gridDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDrivers.Location = new System.Drawing.Point(563, 116);
            this.gridDrivers.Name = "gridDrivers";
            this.gridDrivers.ReadOnly = true;
            this.gridDrivers.Size = new System.Drawing.Size(711, 290);
            this.gridDrivers.TabIndex = 97;
            // 
            // lblQualifications
            // 
            this.lblQualifications.AutoSize = true;
            this.lblQualifications.Location = new System.Drawing.Point(222, 97);
            this.lblQualifications.Name = "lblQualifications";
            this.lblQualifications.Size = new System.Drawing.Size(119, 13);
            this.lblQualifications.TabIndex = 130;
            this.lblQualifications.Text = "Qualifications Obtained:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(143, 409);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 23);
            this.btnRefresh.TabIndex = 129;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // gridQualifications
            // 
            this.gridQualifications.AllowUserToAddRows = false;
            this.gridQualifications.AllowUserToDeleteRows = false;
            this.gridQualifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridQualifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQualifications.Location = new System.Drawing.Point(225, 116);
            this.gridQualifications.Name = "gridQualifications";
            this.gridQualifications.ReadOnly = true;
            this.gridQualifications.Size = new System.Drawing.Size(332, 84);
            this.gridQualifications.TabIndex = 128;
            // 
            // lblTraining
            // 
            this.lblTraining.AutoSize = true;
            this.lblTraining.Location = new System.Drawing.Point(222, 203);
            this.lblTraining.Name = "lblTraining";
            this.lblTraining.Size = new System.Drawing.Size(101, 13);
            this.lblTraining.TabIndex = 132;
            this.lblTraining.Text = "Training Completed:";
            // 
            // gridTraining
            // 
            this.gridTraining.AllowUserToAddRows = false;
            this.gridTraining.AllowUserToDeleteRows = false;
            this.gridTraining.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTraining.Location = new System.Drawing.Point(225, 219);
            this.gridTraining.Name = "gridTraining";
            this.gridTraining.ReadOnly = true;
            this.gridTraining.Size = new System.Drawing.Size(332, 84);
            this.gridTraining.TabIndex = 131;
            // 
            // lblTrainingSessions
            // 
            this.lblTrainingSessions.AutoSize = true;
            this.lblTrainingSessions.Location = new System.Drawing.Point(140, 306);
            this.lblTrainingSessions.Name = "lblTrainingSessions";
            this.lblTrainingSessions.Size = new System.Drawing.Size(147, 13);
            this.lblTrainingSessions.TabIndex = 134;
            this.lblTrainingSessions.Text = "Scheduled Training Sessions:";
            // 
            // gridTrainingSessions
            // 
            this.gridTrainingSessions.AllowUserToAddRows = false;
            this.gridTrainingSessions.AllowUserToDeleteRows = false;
            this.gridTrainingSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTrainingSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrainingSessions.Location = new System.Drawing.Point(143, 322);
            this.gridTrainingSessions.Name = "gridTrainingSessions";
            this.gridTrainingSessions.ReadOnly = true;
            this.gridTrainingSessions.Size = new System.Drawing.Size(414, 84);
            this.gridTrainingSessions.TabIndex = 133;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(37, 97);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(59, 13);
            this.lblID.TabIndex = 166;
            this.lblID.Text = "Driver\'s ID:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(102, 94);
            this.tbID.MaxLength = 25;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 165;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(17, 283);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(79, 13);
            this.lblHoursWorked.TabIndex = 164;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // tbHoursWorked
            // 
            this.tbHoursWorked.Location = new System.Drawing.Point(102, 280);
            this.tbHoursWorked.MaxLength = 20;
            this.tbHoursWorked.Name = "tbHoursWorked";
            this.tbHoursWorked.ReadOnly = true;
            this.tbHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.tbHoursWorked.TabIndex = 163;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(102, 176);
            this.tbPhone.MaxLength = 25;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 162;
            // 
            // lblLicenceExpiration
            // 
            this.lblLicenceExpiration.AutoSize = true;
            this.lblLicenceExpiration.Location = new System.Drawing.Point(-1, 257);
            this.lblLicenceExpiration.Name = "lblLicenceExpiration";
            this.lblLicenceExpiration.Size = new System.Drawing.Size(97, 13);
            this.lblLicenceExpiration.TabIndex = 161;
            this.lblLicenceExpiration.Text = "Licence Expiration:";
            // 
            // lblLicenceNumber
            // 
            this.lblLicenceNumber.AutoSize = true;
            this.lblLicenceNumber.Location = new System.Drawing.Point(8, 231);
            this.lblLicenceNumber.Name = "lblLicenceNumber";
            this.lblLicenceNumber.Size = new System.Drawing.Size(88, 13);
            this.lblLicenceNumber.TabIndex = 160;
            this.lblLicenceNumber.Text = "Licence Number:";
            // 
            // tbLicenceExpiration
            // 
            this.tbLicenceExpiration.Location = new System.Drawing.Point(102, 254);
            this.tbLicenceExpiration.MaxLength = 20;
            this.tbLicenceExpiration.Name = "tbLicenceExpiration";
            this.tbLicenceExpiration.ReadOnly = true;
            this.tbLicenceExpiration.Size = new System.Drawing.Size(100, 20);
            this.tbLicenceExpiration.TabIndex = 159;
            // 
            // tbLicenceNumber
            // 
            this.tbLicenceNumber.Location = new System.Drawing.Point(102, 228);
            this.tbLicenceNumber.MaxLength = 20;
            this.tbLicenceNumber.Name = "tbLicenceNumber";
            this.tbLicenceNumber.ReadOnly = true;
            this.tbLicenceNumber.Size = new System.Drawing.Size(100, 20);
            this.tbLicenceNumber.TabIndex = 158;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(15, 179);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 157;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(61, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 156;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(35, 153);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 155;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(36, 127);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 154;
            this.lblFirstName.Text = "First Name:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(102, 202);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 153;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(102, 150);
            this.tbLastName.MaxLength = 25;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 152;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(102, 124);
            this.tbFirstName.MaxLength = 25;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 151;
            // 
            // DriverProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 450);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.tbHoursWorked);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lblLicenceExpiration);
            this.Controls.Add(this.lblLicenceNumber);
            this.Controls.Add(this.tbLicenceExpiration);
            this.Controls.Add(this.tbLicenceNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblTrainingSessions);
            this.Controls.Add(this.gridTrainingSessions);
            this.Controls.Add(this.lblTraining);
            this.Controls.Add(this.gridTraining);
            this.Controls.Add(this.lblQualifications);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gridQualifications);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnDriverEdit);
            this.Controls.Add(this.btnGridDrivers);
            this.Controls.Add(this.tbGridDriversSearch);
            this.Controls.Add(this.lblGridDrivers);
            this.Controls.Add(this.gridDrivers);
            this.Controls.Add(this.lblProfileHeader);
            this.Name = "DriverProfiles";
            this.Text = "DriverProfiles";
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQualifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrainingSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfileHeader;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnDriverEdit;
        private System.Windows.Forms.Button btnGridDrivers;
        private System.Windows.Forms.TextBox tbGridDriversSearch;
        private System.Windows.Forms.Label lblGridDrivers;
        private System.Windows.Forms.DataGridView gridDrivers;
        private System.Windows.Forms.Label lblQualifications;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView gridQualifications;
        private System.Windows.Forms.Label lblTraining;
        private System.Windows.Forms.DataGridView gridTraining;
        private System.Windows.Forms.Label lblTrainingSessions;
        private System.Windows.Forms.DataGridView gridTrainingSessions;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox tbHoursWorked;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblLicenceExpiration;
        private System.Windows.Forms.Label lblLicenceNumber;
        private System.Windows.Forms.TextBox tbLicenceExpiration;
        private System.Windows.Forms.TextBox tbLicenceNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
    }
}