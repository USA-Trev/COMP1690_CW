
namespace CarRentalUI.Forms
{
    partial class TrainingSessions
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
            this.lblTrainingSessionHeader = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupTrainingTypes = new System.Windows.Forms.GroupBox();
            this.radioAdvancedDriving = new System.Windows.Forms.RadioButton();
            this.radioCyclistAwareness = new System.Windows.Forms.RadioButton();
            this.radioNightDriving = new System.Windows.Forms.RadioButton();
            this.radioReduceFuelConsumption = new System.Windows.Forms.RadioButton();
            this.training_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblAvailableSessions = new System.Windows.Forms.Label();
            this.lblDriversSessions = new System.Windows.Forms.Label();
            this.session_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_training_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupSessionStatus = new System.Windows.Forms.GroupBox();
            this.radioComplete = new System.Windows.Forms.RadioButton();
            this.radioIncomplete = new System.Windows.Forms.RadioButton();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupTrainingTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupSessionStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(850, 121);
            this.tbID.MaxLength = 25;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 161;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(783, 124);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 13);
            this.lblID.TabIndex = 160;
            this.lblID.Text = "Driver\'s ID";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(1022, 147);
            this.tbLastName.MaxLength = 25;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(955, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 158;
            this.label3.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(849, 147);
            this.tbFirstName.MaxLength = 25;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 157;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(783, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 156;
            this.label4.Text = "First Name:";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(1111, 432);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(91, 23);
            this.btnClearSearch.TabIndex = 155;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            // 
            // btnDriverEdit
            // 
            this.btnDriverEdit.Location = new System.Drawing.Point(940, 432);
            this.btnDriverEdit.Name = "btnDriverEdit";
            this.btnDriverEdit.Size = new System.Drawing.Size(120, 23);
            this.btnDriverEdit.TabIndex = 154;
            this.btnDriverEdit.Text = "Edit Driver\'s Training";
            this.btnDriverEdit.UseVisualStyleBackColor = true;
            // 
            // tbDriverEdit
            // 
            this.tbDriverEdit.Location = new System.Drawing.Point(876, 435);
            this.tbDriverEdit.MaxLength = 25;
            this.tbDriverEdit.Name = "tbDriverEdit";
            this.tbDriverEdit.Size = new System.Drawing.Size(58, 20);
            this.tbDriverEdit.TabIndex = 153;
            // 
            // lblDriverEdit
            // 
            this.lblDriverEdit.AutoSize = true;
            this.lblDriverEdit.Location = new System.Drawing.Point(783, 438);
            this.lblDriverEdit.Name = "lblDriverEdit";
            this.lblDriverEdit.Size = new System.Drawing.Size(87, 13);
            this.lblDriverEdit.TabIndex = 152;
            this.lblDriverEdit.Text = "Enter Driver\'s ID:";
            // 
            // btnGridDrivers
            // 
            this.btnGridDrivers.Location = new System.Drawing.Point(1096, 204);
            this.btnGridDrivers.Name = "btnGridDrivers";
            this.btnGridDrivers.Size = new System.Drawing.Size(97, 23);
            this.btnGridDrivers.TabIndex = 151;
            this.btnGridDrivers.Text = "Search";
            this.btnGridDrivers.UseVisualStyleBackColor = true;
            // 
            // tbGridDrivers
            // 
            this.tbGridDrivers.Location = new System.Drawing.Point(918, 207);
            this.tbGridDrivers.MaxLength = 25;
            this.tbGridDrivers.Name = "tbGridDrivers";
            this.tbGridDrivers.Size = new System.Drawing.Size(172, 20);
            this.tbGridDrivers.TabIndex = 150;
            // 
            // lblGridDrivers
            // 
            this.lblGridDrivers.AutoSize = true;
            this.lblGridDrivers.Location = new System.Drawing.Point(774, 210);
            this.lblGridDrivers.Name = "lblGridDrivers";
            this.lblGridDrivers.Size = new System.Drawing.Size(138, 13);
            this.lblGridDrivers.TabIndex = 149;
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
            this.gridDrivers.Location = new System.Drawing.Point(777, 234);
            this.gridDrivers.Name = "gridDrivers";
            this.gridDrivers.ReadOnly = true;
            this.gridDrivers.Size = new System.Drawing.Size(416, 193);
            this.gridDrivers.TabIndex = 148;
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
            // lblTrainingSessionHeader
            // 
            this.lblTrainingSessionHeader.AutoSize = true;
            this.lblTrainingSessionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainingSessionHeader.Location = new System.Drawing.Point(500, 9);
            this.lblTrainingSessionHeader.Name = "lblTrainingSessionHeader";
            this.lblTrainingSessionHeader.Size = new System.Drawing.Size(201, 25);
            this.lblTrainingSessionHeader.TabIndex = 162;
            this.lblTrainingSessionHeader.Text = "Training Sessions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.training_type,
            this.session_date});
            this.dataGridView1.Location = new System.Drawing.Point(364, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(407, 193);
            this.dataGridView1.TabIndex = 163;
            // 
            // groupTrainingTypes
            // 
            this.groupTrainingTypes.Controls.Add(this.radioAdvancedDriving);
            this.groupTrainingTypes.Controls.Add(this.radioCyclistAwareness);
            this.groupTrainingTypes.Controls.Add(this.radioNightDriving);
            this.groupTrainingTypes.Controls.Add(this.radioReduceFuelConsumption);
            this.groupTrainingTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTrainingTypes.Location = new System.Drawing.Point(364, 124);
            this.groupTrainingTypes.Name = "groupTrainingTypes";
            this.groupTrainingTypes.Size = new System.Drawing.Size(249, 85);
            this.groupTrainingTypes.TabIndex = 164;
            this.groupTrainingTypes.TabStop = false;
            this.groupTrainingTypes.Text = "Training Types:";
            // 
            // radioAdvancedDriving
            // 
            this.radioAdvancedDriving.AutoSize = true;
            this.radioAdvancedDriving.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdvancedDriving.Location = new System.Drawing.Point(123, 45);
            this.radioAdvancedDriving.Name = "radioAdvancedDriving";
            this.radioAdvancedDriving.Size = new System.Drawing.Size(107, 17);
            this.radioAdvancedDriving.TabIndex = 3;
            this.radioAdvancedDriving.Text = "AdvancedDriving";
            this.radioAdvancedDriving.UseVisualStyleBackColor = true;
            // 
            // radioCyclistAwareness
            // 
            this.radioCyclistAwareness.AutoSize = true;
            this.radioCyclistAwareness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCyclistAwareness.Location = new System.Drawing.Point(7, 45);
            this.radioCyclistAwareness.Name = "radioCyclistAwareness";
            this.radioCyclistAwareness.Size = new System.Drawing.Size(110, 17);
            this.radioCyclistAwareness.TabIndex = 2;
            this.radioCyclistAwareness.Text = "Cyclist Awareness";
            this.radioCyclistAwareness.UseVisualStyleBackColor = true;
            // 
            // radioNightDriving
            // 
            this.radioNightDriving.AutoSize = true;
            this.radioNightDriving.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNightDriving.Location = new System.Drawing.Point(163, 22);
            this.radioNightDriving.Name = "radioNightDriving";
            this.radioNightDriving.Size = new System.Drawing.Size(86, 17);
            this.radioNightDriving.TabIndex = 1;
            this.radioNightDriving.Text = "Night Driving";
            this.radioNightDriving.UseVisualStyleBackColor = true;
            // 
            // radioReduceFuelConsumption
            // 
            this.radioReduceFuelConsumption.AutoSize = true;
            this.radioReduceFuelConsumption.Checked = true;
            this.radioReduceFuelConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioReduceFuelConsumption.Location = new System.Drawing.Point(7, 22);
            this.radioReduceFuelConsumption.Name = "radioReduceFuelConsumption";
            this.radioReduceFuelConsumption.Size = new System.Drawing.Size(150, 17);
            this.radioReduceFuelConsumption.TabIndex = 0;
            this.radioReduceFuelConsumption.TabStop = true;
            this.radioReduceFuelConsumption.Text = "Reduce Fuel Consumption";
            this.radioReduceFuelConsumption.UseVisualStyleBackColor = true;
            // 
            // training_type
            // 
            this.training_type.HeaderText = "Training Type";
            this.training_type.Name = "training_type";
            this.training_type.ReadOnly = true;
            // 
            // session_date
            // 
            this.session_date.HeaderText = "Session Date";
            this.session_date.Name = "session_date";
            this.session_date.ReadOnly = true;
            // 
            // btnAddSession
            // 
            this.btnAddSession.Location = new System.Drawing.Point(669, 146);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(63, 59);
            this.btnAddSession.TabIndex = 165;
            this.btnAddSession.Text = "Schedule Session";
            this.btnAddSession.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.session_id,
            this.driver_training_type,
            this.session_status});
            this.dataGridView2.Location = new System.Drawing.Point(12, 234);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(346, 193);
            this.dataGridView2.TabIndex = 166;
            // 
            // lblAvailableSessions
            // 
            this.lblAvailableSessions.AutoSize = true;
            this.lblAvailableSessions.Location = new System.Drawing.Point(361, 214);
            this.lblAvailableSessions.Name = "lblAvailableSessions";
            this.lblAvailableSessions.Size = new System.Drawing.Size(139, 13);
            this.lblAvailableSessions.TabIndex = 167;
            this.lblAvailableSessions.Text = "Available Training Sessions:";
            // 
            // lblDriversSessions
            // 
            this.lblDriversSessions.AutoSize = true;
            this.lblDriversSessions.Location = new System.Drawing.Point(12, 218);
            this.lblDriversSessions.Name = "lblDriversSessions";
            this.lblDriversSessions.Size = new System.Drawing.Size(191, 13);
            this.lblDriversSessions.TabIndex = 168;
            this.lblDriversSessions.Text = "Currently Scheduled Training Sessions:";
            // 
            // session_id
            // 
            this.session_id.HeaderText = "Session ID";
            this.session_id.Name = "session_id";
            this.session_id.ReadOnly = true;
            // 
            // driver_training_type
            // 
            this.driver_training_type.HeaderText = "Training Type";
            this.driver_training_type.Name = "driver_training_type";
            this.driver_training_type.ReadOnly = true;
            // 
            // session_status
            // 
            this.session_status.HeaderText = "Session Status";
            this.session_status.Name = "session_status";
            this.session_status.ReadOnly = true;
            // 
            // groupSessionStatus
            // 
            this.groupSessionStatus.Controls.Add(this.radioComplete);
            this.groupSessionStatus.Controls.Add(this.radioIncomplete);
            this.groupSessionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSessionStatus.Location = new System.Drawing.Point(12, 124);
            this.groupSessionStatus.Name = "groupSessionStatus";
            this.groupSessionStatus.Size = new System.Drawing.Size(133, 85);
            this.groupSessionStatus.TabIndex = 169;
            this.groupSessionStatus.TabStop = false;
            this.groupSessionStatus.Text = "Session Status:";
            // 
            // radioComplete
            // 
            this.radioComplete.AutoSize = true;
            this.radioComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioComplete.Location = new System.Drawing.Point(7, 45);
            this.radioComplete.Name = "radioComplete";
            this.radioComplete.Size = new System.Drawing.Size(69, 17);
            this.radioComplete.TabIndex = 2;
            this.radioComplete.Text = "Complete";
            this.radioComplete.UseVisualStyleBackColor = true;
            // 
            // radioIncomplete
            // 
            this.radioIncomplete.AutoSize = true;
            this.radioIncomplete.Checked = true;
            this.radioIncomplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIncomplete.Location = new System.Drawing.Point(7, 22);
            this.radioIncomplete.Name = "radioIncomplete";
            this.radioIncomplete.Size = new System.Drawing.Size(77, 17);
            this.radioIncomplete.TabIndex = 0;
            this.radioIncomplete.TabStop = true;
            this.radioIncomplete.Text = "Incomplete";
            this.radioIncomplete.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(224, 146);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(63, 59);
            this.btnUpdateStatus.TabIndex = 170;
            this.btnUpdateStatus.Text = "Update Session Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // TrainingSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 467);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.groupSessionStatus);
            this.Controls.Add(this.lblDriversSessions);
            this.Controls.Add(this.lblAvailableSessions);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.groupTrainingTypes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTrainingSessionHeader);
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
            this.Name = "TrainingSessions";
            this.Text = "TrainingSessions";
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupTrainingTypes.ResumeLayout(false);
            this.groupTrainingTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupSessionStatus.ResumeLayout(false);
            this.groupSessionStatus.PerformLayout();
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
        private System.Windows.Forms.Label lblTrainingSessionHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupTrainingTypes;
        private System.Windows.Forms.RadioButton radioAdvancedDriving;
        private System.Windows.Forms.RadioButton radioCyclistAwareness;
        private System.Windows.Forms.RadioButton radioNightDriving;
        private System.Windows.Forms.RadioButton radioReduceFuelConsumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn training_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn session_date;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblAvailableSessions;
        private System.Windows.Forms.Label lblDriversSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn session_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_training_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn session_status;
        private System.Windows.Forms.GroupBox groupSessionStatus;
        private System.Windows.Forms.RadioButton radioComplete;
        private System.Windows.Forms.RadioButton radioIncomplete;
        private System.Windows.Forms.Button btnUpdateStatus;
    }
}