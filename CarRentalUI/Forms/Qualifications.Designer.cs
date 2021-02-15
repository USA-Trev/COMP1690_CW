
namespace CarRentalUI.Forms
{
    partial class Qualifications
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
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnDriverEdit = new System.Windows.Forms.Button();
            this.tbDriverEdit = new System.Windows.Forms.TextBox();
            this.lblDriverEdit = new System.Windows.Forms.Label();
            this.btnGridDrivers = new System.Windows.Forms.Button();
            this.tbGridDrivers = new System.Windows.Forms.TextBox();
            this.lblGridDrivers = new System.Windows.Forms.Label();
            this.gridDrivers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name_licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name_licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQualificationsHeader = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupGeoTests = new System.Windows.Forms.GroupBox();
            this.radioWest = new System.Windows.Forms.RadioButton();
            this.radioEast = new System.Windows.Forms.RadioButton();
            this.radioSouth = new System.Windows.Forms.RadioButton();
            this.radioNorth = new System.Windows.Forms.RadioButton();
            this.radioCentral = new System.Windows.Forms.RadioButton();
            this.btnAddQualification = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualification_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbQualificationID = new System.Windows.Forms.TextBox();
            this.lblQualificationID = new System.Windows.Forms.Label();
            this.btnDeleteQualification = new System.Windows.Forms.Button();
            this.lblQualifications = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).BeginInit();
            this.groupGeoTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(697, 392);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(91, 23);
            this.btnClearSearch.TabIndex = 96;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            // 
            // btnDriverEdit
            // 
            this.btnDriverEdit.Location = new System.Drawing.Point(526, 392);
            this.btnDriverEdit.Name = "btnDriverEdit";
            this.btnDriverEdit.Size = new System.Drawing.Size(120, 23);
            this.btnDriverEdit.TabIndex = 95;
            this.btnDriverEdit.Text = "Edit Driver\'s Tests";
            this.btnDriverEdit.UseVisualStyleBackColor = true;
            // 
            // tbDriverEdit
            // 
            this.tbDriverEdit.Location = new System.Drawing.Point(462, 395);
            this.tbDriverEdit.MaxLength = 25;
            this.tbDriverEdit.Name = "tbDriverEdit";
            this.tbDriverEdit.Size = new System.Drawing.Size(58, 20);
            this.tbDriverEdit.TabIndex = 94;
            // 
            // lblDriverEdit
            // 
            this.lblDriverEdit.AutoSize = true;
            this.lblDriverEdit.Location = new System.Drawing.Point(369, 398);
            this.lblDriverEdit.Name = "lblDriverEdit";
            this.lblDriverEdit.Size = new System.Drawing.Size(87, 13);
            this.lblDriverEdit.TabIndex = 93;
            this.lblDriverEdit.Text = "Enter Driver\'s ID:";
            // 
            // btnGridDrivers
            // 
            this.btnGridDrivers.Location = new System.Drawing.Point(691, 165);
            this.btnGridDrivers.Name = "btnGridDrivers";
            this.btnGridDrivers.Size = new System.Drawing.Size(97, 23);
            this.btnGridDrivers.TabIndex = 92;
            this.btnGridDrivers.Text = "Search";
            this.btnGridDrivers.UseVisualStyleBackColor = true;
            // 
            // tbGridDrivers
            // 
            this.tbGridDrivers.Location = new System.Drawing.Point(513, 167);
            this.tbGridDrivers.MaxLength = 25;
            this.tbGridDrivers.Name = "tbGridDrivers";
            this.tbGridDrivers.Size = new System.Drawing.Size(172, 20);
            this.tbGridDrivers.TabIndex = 91;
            // 
            // lblGridDrivers
            // 
            this.lblGridDrivers.AutoSize = true;
            this.lblGridDrivers.Location = new System.Drawing.Point(369, 170);
            this.lblGridDrivers.Name = "lblGridDrivers";
            this.lblGridDrivers.Size = new System.Drawing.Size(138, 13);
            this.lblGridDrivers.TabIndex = 90;
            this.lblGridDrivers.Text = "Lookup a driver: (last name)";
            // 
            // gridDrivers
            // 
            this.gridDrivers.AllowUserToAddRows = false;
            this.gridDrivers.AllowUserToDeleteRows = false;
            this.gridDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.first_name_licence,
            this.last_name_licence});
            this.gridDrivers.Location = new System.Drawing.Point(372, 194);
            this.gridDrivers.Name = "gridDrivers";
            this.gridDrivers.ReadOnly = true;
            this.gridDrivers.Size = new System.Drawing.Size(416, 193);
            this.gridDrivers.TabIndex = 89;
            // 
            // id
            // 
            this.id.HeaderText = "Driver ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // first_name_licence
            // 
            this.first_name_licence.HeaderText = "First Name";
            this.first_name_licence.Name = "first_name_licence";
            this.first_name_licence.ReadOnly = true;
            // 
            // last_name_licence
            // 
            this.last_name_licence.HeaderText = "Last Name";
            this.last_name_licence.Name = "last_name_licence";
            this.last_name_licence.ReadOnly = true;
            // 
            // lblQualificationsHeader
            // 
            this.lblQualificationsHeader.AutoSize = true;
            this.lblQualificationsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualificationsHeader.Location = new System.Drawing.Point(328, 9);
            this.lblQualificationsHeader.Name = "lblQualificationsHeader";
            this.lblQualificationsHeader.Size = new System.Drawing.Size(156, 25);
            this.lblQualificationsHeader.TabIndex = 97;
            this.lblQualificationsHeader.Text = "Qualifications";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(436, 81);
            this.tbID.MaxLength = 25;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 119;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(369, 84);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 13);
            this.lblID.TabIndex = 118;
            this.lblID.Text = "Driver\'s ID";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(608, 107);
            this.tbLastName.MaxLength = 25;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(435, 107);
            this.tbFirstName.MaxLength = 25;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 114;
            this.label4.Text = "First Name:";
            // 
            // groupGeoTests
            // 
            this.groupGeoTests.Controls.Add(this.radioWest);
            this.groupGeoTests.Controls.Add(this.radioEast);
            this.groupGeoTests.Controls.Add(this.radioSouth);
            this.groupGeoTests.Controls.Add(this.radioNorth);
            this.groupGeoTests.Controls.Add(this.radioCentral);
            this.groupGeoTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGeoTests.Location = new System.Drawing.Point(12, 62);
            this.groupGeoTests.Name = "groupGeoTests";
            this.groupGeoTests.Size = new System.Drawing.Size(205, 100);
            this.groupGeoTests.TabIndex = 120;
            this.groupGeoTests.TabStop = false;
            this.groupGeoTests.Text = "Geographic Tests:";
            // 
            // radioWest
            // 
            this.radioWest.AutoSize = true;
            this.radioWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWest.Location = new System.Drawing.Point(7, 68);
            this.radioWest.Name = "radioWest";
            this.radioWest.Size = new System.Drawing.Size(89, 17);
            this.radioWest.TabIndex = 4;
            this.radioWest.Text = "West London";
            this.radioWest.UseVisualStyleBackColor = true;
            // 
            // radioEast
            // 
            this.radioEast.AutoSize = true;
            this.radioEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEast.Location = new System.Drawing.Point(110, 45);
            this.radioEast.Name = "radioEast";
            this.radioEast.Size = new System.Drawing.Size(85, 17);
            this.radioEast.TabIndex = 3;
            this.radioEast.Text = "East London";
            this.radioEast.UseVisualStyleBackColor = true;
            // 
            // radioSouth
            // 
            this.radioSouth.AutoSize = true;
            this.radioSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSouth.Location = new System.Drawing.Point(7, 45);
            this.radioSouth.Name = "radioSouth";
            this.radioSouth.Size = new System.Drawing.Size(92, 17);
            this.radioSouth.TabIndex = 2;
            this.radioSouth.Text = "South London";
            this.radioSouth.UseVisualStyleBackColor = true;
            // 
            // radioNorth
            // 
            this.radioNorth.AutoSize = true;
            this.radioNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNorth.Location = new System.Drawing.Point(110, 22);
            this.radioNorth.Name = "radioNorth";
            this.radioNorth.Size = new System.Drawing.Size(90, 17);
            this.radioNorth.TabIndex = 1;
            this.radioNorth.Text = "North London";
            this.radioNorth.UseVisualStyleBackColor = true;
            // 
            // radioCentral
            // 
            this.radioCentral.AutoSize = true;
            this.radioCentral.Checked = true;
            this.radioCentral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCentral.Location = new System.Drawing.Point(7, 22);
            this.radioCentral.Name = "radioCentral";
            this.radioCentral.Size = new System.Drawing.Size(97, 17);
            this.radioCentral.TabIndex = 0;
            this.radioCentral.TabStop = true;
            this.radioCentral.Text = "Central London";
            this.radioCentral.UseVisualStyleBackColor = true;
            // 
            // btnAddQualification
            // 
            this.btnAddQualification.Location = new System.Drawing.Point(223, 88);
            this.btnAddQualification.Name = "btnAddQualification";
            this.btnAddQualification.Size = new System.Drawing.Size(75, 59);
            this.btnAddQualification.TabIndex = 121;
            this.btnAddQualification.Text = "Add Qualification";
            this.btnAddQualification.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.qualification_title});
            this.dataGridView1.Location = new System.Drawing.Point(12, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(318, 162);
            this.dataGridView1.TabIndex = 122;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Qualification ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // qualification_title
            // 
            this.qualification_title.HeaderText = "Qualification Title";
            this.qualification_title.Name = "qualification_title";
            this.qualification_title.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(270, 362);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 23);
            this.btnRefresh.TabIndex = 126;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // tbQualificationID
            // 
            this.tbQualificationID.Location = new System.Drawing.Point(128, 362);
            this.tbQualificationID.MaxLength = 5;
            this.tbQualificationID.Name = "tbQualificationID";
            this.tbQualificationID.Size = new System.Drawing.Size(39, 20);
            this.tbQualificationID.TabIndex = 125;
            // 
            // lblQualificationID
            // 
            this.lblQualificationID.AutoSize = true;
            this.lblQualificationID.Location = new System.Drawing.Point(12, 365);
            this.lblQualificationID.Name = "lblQualificationID";
            this.lblQualificationID.Size = new System.Drawing.Size(110, 13);
            this.lblQualificationID.TabIndex = 124;
            this.lblQualificationID.Text = "Enter Qualification ID:";
            // 
            // btnDeleteQualification
            // 
            this.btnDeleteQualification.Location = new System.Drawing.Point(12, 388);
            this.btnDeleteQualification.Name = "btnDeleteQualification";
            this.btnDeleteQualification.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteQualification.TabIndex = 123;
            this.btnDeleteQualification.Text = "Remove Qualification";
            this.btnDeleteQualification.UseVisualStyleBackColor = true;
            // 
            // lblQualifications
            // 
            this.lblQualifications.AutoSize = true;
            this.lblQualifications.Location = new System.Drawing.Point(12, 175);
            this.lblQualifications.Name = "lblQualifications";
            this.lblQualifications.Size = new System.Drawing.Size(156, 13);
            this.lblQualifications.TabIndex = 127;
            this.lblQualifications.Text = "Selected Driver\'s Qualifications:";
            // 
            // Qualifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.lblQualifications);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbQualificationID);
            this.Controls.Add(this.lblQualificationID);
            this.Controls.Add(this.btnDeleteQualification);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddQualification);
            this.Controls.Add(this.groupGeoTests);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblQualificationsHeader);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnDriverEdit);
            this.Controls.Add(this.tbDriverEdit);
            this.Controls.Add(this.lblDriverEdit);
            this.Controls.Add(this.btnGridDrivers);
            this.Controls.Add(this.tbGridDrivers);
            this.Controls.Add(this.lblGridDrivers);
            this.Controls.Add(this.gridDrivers);
            this.Name = "Qualifications";
            this.Text = "Qualifications";
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).EndInit();
            this.groupGeoTests.ResumeLayout(false);
            this.groupGeoTests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnDriverEdit;
        private System.Windows.Forms.TextBox tbDriverEdit;
        private System.Windows.Forms.Label lblDriverEdit;
        private System.Windows.Forms.Button btnGridDrivers;
        private System.Windows.Forms.TextBox tbGridDrivers;
        private System.Windows.Forms.Label lblGridDrivers;
        private System.Windows.Forms.DataGridView gridDrivers;
        private System.Windows.Forms.Label lblQualificationsHeader;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupGeoTests;
        private System.Windows.Forms.RadioButton radioWest;
        private System.Windows.Forms.RadioButton radioEast;
        private System.Windows.Forms.RadioButton radioSouth;
        private System.Windows.Forms.RadioButton radioNorth;
        private System.Windows.Forms.RadioButton radioCentral;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name_licence;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name_licence;
        private System.Windows.Forms.Button btnAddQualification;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualification_title;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbQualificationID;
        private System.Windows.Forms.Label lblQualificationID;
        private System.Windows.Forms.Button btnDeleteQualification;
        private System.Windows.Forms.Label lblQualifications;
    }
}