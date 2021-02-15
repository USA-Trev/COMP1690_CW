
namespace CarRentalUI.Forms
{
    partial class Drivers
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
            this.components = new System.ComponentModel.Container();
            this.gridDrivers = new System.Windows.Forms.DataGridView();
            this.lblGridDrivers = new System.Windows.Forms.Label();
            this.lblDriversHeader = new System.Windows.Forms.Label();
            this.btnGridDriversSearch = new System.Windows.Forms.Button();
            this.tbGridDriversSearch = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.tbHoursWorked = new System.Windows.Forms.TextBox();
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
            this.tbPhone = new ComponentsLibrary.PhoneTextBox(this.components);
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnEditDriver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDrivers
            // 
            this.gridDrivers.AllowUserToAddRows = false;
            this.gridDrivers.AllowUserToDeleteRows = false;
            this.gridDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDrivers.Location = new System.Drawing.Point(322, 114);
            this.gridDrivers.MultiSelect = false;
            this.gridDrivers.Name = "gridDrivers";
            this.gridDrivers.ReadOnly = true;
            this.gridDrivers.Size = new System.Drawing.Size(466, 193);
            this.gridDrivers.TabIndex = 1;
            // 
            // lblGridDrivers
            // 
            this.lblGridDrivers.AutoSize = true;
            this.lblGridDrivers.Location = new System.Drawing.Point(325, 90);
            this.lblGridDrivers.Name = "lblGridDrivers";
            this.lblGridDrivers.Size = new System.Drawing.Size(138, 13);
            this.lblGridDrivers.TabIndex = 6;
            this.lblGridDrivers.Text = "Lookup a driver: (last name)";
            // 
            // lblDriversHeader
            // 
            this.lblDriversHeader.AutoSize = true;
            this.lblDriversHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriversHeader.Location = new System.Drawing.Point(355, 9);
            this.lblDriversHeader.Name = "lblDriversHeader";
            this.lblDriversHeader.Size = new System.Drawing.Size(87, 25);
            this.lblDriversHeader.TabIndex = 7;
            this.lblDriversHeader.Text = "Drivers";
            // 
            // btnGridDriversSearch
            // 
            this.btnGridDriversSearch.Location = new System.Drawing.Point(647, 85);
            this.btnGridDriversSearch.Name = "btnGridDriversSearch";
            this.btnGridDriversSearch.Size = new System.Drawing.Size(141, 23);
            this.btnGridDriversSearch.TabIndex = 68;
            this.btnGridDriversSearch.Text = "Search";
            this.btnGridDriversSearch.UseVisualStyleBackColor = true;
            this.btnGridDriversSearch.Click += new System.EventHandler(this.btnGridDriversSearch_Click);
            // 
            // tbGridDriversSearch
            // 
            this.tbGridDriversSearch.Location = new System.Drawing.Point(469, 87);
            this.tbGridDriversSearch.MaxLength = 25;
            this.tbGridDriversSearch.Name = "tbGridDriversSearch";
            this.tbGridDriversSearch.Size = new System.Drawing.Size(172, 20);
            this.tbGridDriversSearch.TabIndex = 67;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(128, 93);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(59, 13);
            this.lblID.TabIndex = 86;
            this.lblID.Text = "Driver\'s ID:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(193, 90);
            this.tbID.MaxLength = 25;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 85;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(108, 275);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(79, 13);
            this.lblHoursWorked.TabIndex = 84;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // tbHoursWorked
            // 
            this.tbHoursWorked.Location = new System.Drawing.Point(193, 272);
            this.tbHoursWorked.MaxLength = 25;
            this.tbHoursWorked.Name = "tbHoursWorked";
            this.tbHoursWorked.ReadOnly = true;
            this.tbHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.tbHoursWorked.TabIndex = 83;
            this.tbHoursWorked.Text = "0";
            // 
            // lblLicenceExpiration
            // 
            this.lblLicenceExpiration.AutoSize = true;
            this.lblLicenceExpiration.Location = new System.Drawing.Point(33, 249);
            this.lblLicenceExpiration.Name = "lblLicenceExpiration";
            this.lblLicenceExpiration.Size = new System.Drawing.Size(154, 13);
            this.lblLicenceExpiration.TabIndex = 82;
            this.lblLicenceExpiration.Text = "Licence Expiration: (yyyymmdd)";
            // 
            // lblLicenceNumber
            // 
            this.lblLicenceNumber.AutoSize = true;
            this.lblLicenceNumber.Location = new System.Drawing.Point(99, 223);
            this.lblLicenceNumber.Name = "lblLicenceNumber";
            this.lblLicenceNumber.Size = new System.Drawing.Size(88, 13);
            this.lblLicenceNumber.TabIndex = 81;
            this.lblLicenceNumber.Text = "Licence Number:";
            // 
            // tbLicenceExpiration
            // 
            this.tbLicenceExpiration.Location = new System.Drawing.Point(193, 246);
            this.tbLicenceExpiration.MaxLength = 10;
            this.tbLicenceExpiration.Name = "tbLicenceExpiration";
            this.tbLicenceExpiration.Size = new System.Drawing.Size(100, 20);
            this.tbLicenceExpiration.TabIndex = 80;
            // 
            // tbLicenceNumber
            // 
            this.tbLicenceNumber.Location = new System.Drawing.Point(193, 220);
            this.tbLicenceNumber.MaxLength = 20;
            this.tbLicenceNumber.Name = "tbLicenceNumber";
            this.tbLicenceNumber.Size = new System.Drawing.Size(100, 20);
            this.tbLicenceNumber.TabIndex = 79;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(106, 197);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 78;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(152, 175);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 77;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(126, 145);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 76;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(127, 119);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 75;
            this.lblFirstName.Text = "First Name:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(193, 168);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 74;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(193, 142);
            this.tbLastName.MaxLength = 25;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 73;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(193, 116);
            this.tbFirstName.MaxLength = 25;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 72;
            // 
            // tbPhone
            // 
            this.tbPhone.ForeColor = System.Drawing.Color.Red;
            this.tbPhone.Location = new System.Drawing.Point(193, 194);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 87;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(419, 312);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(91, 23);
            this.btnClearSearch.TabIndex = 88;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(691, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 23);
            this.btnDelete.TabIndex = 89;
            this.btnDelete.Text = "Delete Driver";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(155, 312);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(138, 23);
            this.btnSubmit.TabIndex = 90;
            this.btnSubmit.Text = "Create / Update Driver";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnEditDriver
            // 
            this.btnEditDriver.Location = new System.Drawing.Point(322, 313);
            this.btnEditDriver.Name = "btnEditDriver";
            this.btnEditDriver.Size = new System.Drawing.Size(91, 23);
            this.btnEditDriver.TabIndex = 91;
            this.btnEditDriver.Text = "Select Driver";
            this.btnEditDriver.UseVisualStyleBackColor = true;
            this.btnEditDriver.Click += new System.EventHandler(this.btnEditDriver_Click);
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.btnEditDriver);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.tbHoursWorked);
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
            this.Controls.Add(this.btnGridDriversSearch);
            this.Controls.Add(this.tbGridDriversSearch);
            this.Controls.Add(this.lblDriversHeader);
            this.Controls.Add(this.lblGridDrivers);
            this.Controls.Add(this.gridDrivers);
            this.Name = "Drivers";
            this.Text = "Drivers";
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDrivers;
        private System.Windows.Forms.Label lblGridDrivers;
        private System.Windows.Forms.Label lblDriversHeader;
        private System.Windows.Forms.Button btnGridDriversSearch;
        private System.Windows.Forms.TextBox tbGridDriversSearch;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox tbHoursWorked;
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
        private ComponentsLibrary.PhoneTextBox tbPhone;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnEditDriver;
    }
}