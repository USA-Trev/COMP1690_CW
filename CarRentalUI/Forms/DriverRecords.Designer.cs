
namespace CarRentalUI.Forms
{
    partial class DriverRecords
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.lblRecordsHeader = new System.Windows.Forms.Label();
            this.lblIncidents = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbIncidentID = new System.Windows.Forms.TextBox();
            this.lblIncidentID = new System.Windows.Forms.Label();
            this.btnDeleteIncident = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddIncident = new System.Windows.Forms.Button();
            this.groupIncidentTypes = new System.Windows.Forms.GroupBox();
            this.radioRunningRed = new System.Windows.Forms.RadioButton();
            this.radioDangerousDriving = new System.Windows.Forms.RadioButton();
            this.radioSpeeding = new System.Windows.Forms.RadioButton();
            this.radioAbusiveBehavior = new System.Windows.Forms.RadioButton();
            this.radioAccident = new System.Windows.Forms.RadioButton();
            this.incident_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incident_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupIncidentTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(436, 104);
            this.tbID.MaxLength = 25;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 133;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(369, 107);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 13);
            this.lblID.TabIndex = 132;
            this.lblID.Text = "Driver\'s ID";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(608, 130);
            this.tbLastName.MaxLength = 25;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 130;
            this.label3.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(435, 130);
            this.tbFirstName.MaxLength = 25;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 129;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 128;
            this.label4.Text = "First Name:";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(697, 415);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(91, 23);
            this.btnClearSearch.TabIndex = 127;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            // 
            // btnDriverEdit
            // 
            this.btnDriverEdit.Location = new System.Drawing.Point(526, 415);
            this.btnDriverEdit.Name = "btnDriverEdit";
            this.btnDriverEdit.Size = new System.Drawing.Size(120, 23);
            this.btnDriverEdit.TabIndex = 126;
            this.btnDriverEdit.Text = "Edit Driver\'s Record";
            this.btnDriverEdit.UseVisualStyleBackColor = true;
            // 
            // tbDriverEdit
            // 
            this.tbDriverEdit.Location = new System.Drawing.Point(462, 418);
            this.tbDriverEdit.MaxLength = 25;
            this.tbDriverEdit.Name = "tbDriverEdit";
            this.tbDriverEdit.Size = new System.Drawing.Size(58, 20);
            this.tbDriverEdit.TabIndex = 125;
            // 
            // lblDriverEdit
            // 
            this.lblDriverEdit.AutoSize = true;
            this.lblDriverEdit.Location = new System.Drawing.Point(369, 421);
            this.lblDriverEdit.Name = "lblDriverEdit";
            this.lblDriverEdit.Size = new System.Drawing.Size(87, 13);
            this.lblDriverEdit.TabIndex = 124;
            this.lblDriverEdit.Text = "Enter Driver\'s ID:";
            // 
            // btnGridDrivers
            // 
            this.btnGridDrivers.Location = new System.Drawing.Point(691, 188);
            this.btnGridDrivers.Name = "btnGridDrivers";
            this.btnGridDrivers.Size = new System.Drawing.Size(97, 23);
            this.btnGridDrivers.TabIndex = 123;
            this.btnGridDrivers.Text = "Search";
            this.btnGridDrivers.UseVisualStyleBackColor = true;
            // 
            // tbGridDrivers
            // 
            this.tbGridDrivers.Location = new System.Drawing.Point(513, 190);
            this.tbGridDrivers.MaxLength = 25;
            this.tbGridDrivers.Name = "tbGridDrivers";
            this.tbGridDrivers.Size = new System.Drawing.Size(172, 20);
            this.tbGridDrivers.TabIndex = 122;
            // 
            // lblGridDrivers
            // 
            this.lblGridDrivers.AutoSize = true;
            this.lblGridDrivers.Location = new System.Drawing.Point(369, 193);
            this.lblGridDrivers.Name = "lblGridDrivers";
            this.lblGridDrivers.Size = new System.Drawing.Size(138, 13);
            this.lblGridDrivers.TabIndex = 121;
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
            this.gridDrivers.Location = new System.Drawing.Point(372, 217);
            this.gridDrivers.Name = "gridDrivers";
            this.gridDrivers.ReadOnly = true;
            this.gridDrivers.Size = new System.Drawing.Size(416, 193);
            this.gridDrivers.TabIndex = 120;
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
            // lblRecordsHeader
            // 
            this.lblRecordsHeader.AutoSize = true;
            this.lblRecordsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsHeader.Location = new System.Drawing.Point(327, 9);
            this.lblRecordsHeader.Name = "lblRecordsHeader";
            this.lblRecordsHeader.Size = new System.Drawing.Size(189, 25);
            this.lblRecordsHeader.TabIndex = 134;
            this.lblRecordsHeader.Text = "Incident Records";
            // 
            // lblIncidents
            // 
            this.lblIncidents.AutoSize = true;
            this.lblIncidents.Location = new System.Drawing.Point(12, 198);
            this.lblIncidents.Name = "lblIncidents";
            this.lblIncidents.Size = new System.Drawing.Size(133, 13);
            this.lblIncidents.TabIndex = 142;
            this.lblIncidents.Text = "Selected Driver\'s Incidents";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(270, 385);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 23);
            this.btnRefresh.TabIndex = 141;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // tbIncidentID
            // 
            this.tbIncidentID.Location = new System.Drawing.Point(108, 385);
            this.tbIncidentID.MaxLength = 5;
            this.tbIncidentID.Name = "tbIncidentID";
            this.tbIncidentID.Size = new System.Drawing.Size(39, 20);
            this.tbIncidentID.TabIndex = 140;
            // 
            // lblIncidentID
            // 
            this.lblIncidentID.AutoSize = true;
            this.lblIncidentID.Location = new System.Drawing.Point(12, 388);
            this.lblIncidentID.Name = "lblIncidentID";
            this.lblIncidentID.Size = new System.Drawing.Size(90, 13);
            this.lblIncidentID.TabIndex = 139;
            this.lblIncidentID.Text = "Enter Incident ID:";
            // 
            // btnDeleteIncident
            // 
            this.btnDeleteIncident.Location = new System.Drawing.Point(12, 411);
            this.btnDeleteIncident.Name = "btnDeleteIncident";
            this.btnDeleteIncident.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteIncident.TabIndex = 138;
            this.btnDeleteIncident.Text = "Remove Incident";
            this.btnDeleteIncident.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incident_id,
            this.incident_type});
            this.dataGridView1.Location = new System.Drawing.Point(12, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(318, 162);
            this.dataGridView1.TabIndex = 137;
            // 
            // btnAddIncident
            // 
            this.btnAddIncident.Location = new System.Drawing.Point(255, 111);
            this.btnAddIncident.Name = "btnAddIncident";
            this.btnAddIncident.Size = new System.Drawing.Size(75, 59);
            this.btnAddIncident.TabIndex = 136;
            this.btnAddIncident.Text = "Add Incident";
            this.btnAddIncident.UseVisualStyleBackColor = true;
            // 
            // groupIncidentTypes
            // 
            this.groupIncidentTypes.Controls.Add(this.radioRunningRed);
            this.groupIncidentTypes.Controls.Add(this.radioDangerousDriving);
            this.groupIncidentTypes.Controls.Add(this.radioSpeeding);
            this.groupIncidentTypes.Controls.Add(this.radioAbusiveBehavior);
            this.groupIncidentTypes.Controls.Add(this.radioAccident);
            this.groupIncidentTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupIncidentTypes.Location = new System.Drawing.Point(12, 85);
            this.groupIncidentTypes.Name = "groupIncidentTypes";
            this.groupIncidentTypes.Size = new System.Drawing.Size(237, 100);
            this.groupIncidentTypes.TabIndex = 135;
            this.groupIncidentTypes.TabStop = false;
            this.groupIncidentTypes.Text = "Incident Types:";
            // 
            // radioRunningRed
            // 
            this.radioRunningRed.AutoSize = true;
            this.radioRunningRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRunningRed.Location = new System.Drawing.Point(7, 68);
            this.radioRunningRed.Name = "radioRunningRed";
            this.radioRunningRed.Size = new System.Drawing.Size(123, 17);
            this.radioRunningRed.TabIndex = 4;
            this.radioRunningRed.Text = "Running a Red Light";
            this.radioRunningRed.UseVisualStyleBackColor = true;
            // 
            // radioDangerousDriving
            // 
            this.radioDangerousDriving.AutoSize = true;
            this.radioDangerousDriving.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDangerousDriving.Location = new System.Drawing.Point(83, 45);
            this.radioDangerousDriving.Name = "radioDangerousDriving";
            this.radioDangerousDriving.Size = new System.Drawing.Size(113, 17);
            this.radioDangerousDriving.TabIndex = 3;
            this.radioDangerousDriving.Text = "Dangerous Driving";
            this.radioDangerousDriving.UseVisualStyleBackColor = true;
            // 
            // radioSpeeding
            // 
            this.radioSpeeding.AutoSize = true;
            this.radioSpeeding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSpeeding.Location = new System.Drawing.Point(7, 45);
            this.radioSpeeding.Name = "radioSpeeding";
            this.radioSpeeding.Size = new System.Drawing.Size(70, 17);
            this.radioSpeeding.TabIndex = 2;
            this.radioSpeeding.Text = "Speeding";
            this.radioSpeeding.UseVisualStyleBackColor = true;
            // 
            // radioAbusiveBehavior
            // 
            this.radioAbusiveBehavior.AutoSize = true;
            this.radioAbusiveBehavior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAbusiveBehavior.Location = new System.Drawing.Point(83, 22);
            this.radioAbusiveBehavior.Name = "radioAbusiveBehavior";
            this.radioAbusiveBehavior.Size = new System.Drawing.Size(108, 17);
            this.radioAbusiveBehavior.TabIndex = 1;
            this.radioAbusiveBehavior.Text = "Abusive Behavior";
            this.radioAbusiveBehavior.UseVisualStyleBackColor = true;
            // 
            // radioAccident
            // 
            this.radioAccident.AutoSize = true;
            this.radioAccident.Checked = true;
            this.radioAccident.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAccident.Location = new System.Drawing.Point(7, 22);
            this.radioAccident.Name = "radioAccident";
            this.radioAccident.Size = new System.Drawing.Size(67, 17);
            this.radioAccident.TabIndex = 0;
            this.radioAccident.TabStop = true;
            this.radioAccident.Text = "Accident";
            this.radioAccident.UseVisualStyleBackColor = true;
            // 
            // incident_id
            // 
            this.incident_id.HeaderText = "Incident ID";
            this.incident_id.Name = "incident_id";
            this.incident_id.ReadOnly = true;
            // 
            // incident_type
            // 
            this.incident_type.HeaderText = "Incident Type";
            this.incident_type.Name = "incident_type";
            this.incident_type.ReadOnly = true;
            // 
            // DriverRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIncidents);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbIncidentID);
            this.Controls.Add(this.lblIncidentID);
            this.Controls.Add(this.btnDeleteIncident);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddIncident);
            this.Controls.Add(this.groupIncidentTypes);
            this.Controls.Add(this.lblRecordsHeader);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnDriverEdit);
            this.Controls.Add(this.tbDriverEdit);
            this.Controls.Add(this.lblDriverEdit);
            this.Controls.Add(this.btnGridDrivers);
            this.Controls.Add(this.tbGridDrivers);
            this.Controls.Add(this.lblGridDrivers);
            this.Controls.Add(this.gridDrivers);
            this.Name = "DriverRecords";
            this.Text = "DriverRecords";
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupIncidentTypes.ResumeLayout(false);
            this.groupIncidentTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnDriverEdit;
        private System.Windows.Forms.TextBox tbDriverEdit;
        private System.Windows.Forms.Label lblDriverEdit;
        private System.Windows.Forms.Button btnGridDrivers;
        private System.Windows.Forms.TextBox tbGridDrivers;
        private System.Windows.Forms.Label lblGridDrivers;
        private System.Windows.Forms.DataGridView gridDrivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name_licence;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name_licence;
        private System.Windows.Forms.Label lblRecordsHeader;
        private System.Windows.Forms.Label lblIncidents;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbIncidentID;
        private System.Windows.Forms.Label lblIncidentID;
        private System.Windows.Forms.Button btnDeleteIncident;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddIncident;
        private System.Windows.Forms.GroupBox groupIncidentTypes;
        private System.Windows.Forms.RadioButton radioRunningRed;
        private System.Windows.Forms.RadioButton radioDangerousDriving;
        private System.Windows.Forms.RadioButton radioSpeeding;
        private System.Windows.Forms.RadioButton radioAbusiveBehavior;
        private System.Windows.Forms.RadioButton radioAccident;
        private System.Windows.Forms.DataGridViewTextBoxColumn incident_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn incident_type;
    }
}