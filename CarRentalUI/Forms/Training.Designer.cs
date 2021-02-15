
namespace CarRentalUI.Forms
{
    partial class Training
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
            this.lblTraining = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbIncidentID = new System.Windows.Forms.TextBox();
            this.lblTrainingID = new System.Windows.Forms.Label();
            this.btnDeleteIncident = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.training_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.training_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTraining = new System.Windows.Forms.Button();
            this.groupTrainingTypes = new System.Windows.Forms.GroupBox();
            this.radioAdvancedDriving = new System.Windows.Forms.RadioButton();
            this.radioCyclistAwareness = new System.Windows.Forms.RadioButton();
            this.radioNightDriving = new System.Windows.Forms.RadioButton();
            this.radioReduceFuelConsumption = new System.Windows.Forms.RadioButton();
            this.lblTrainingHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupTrainingTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(436, 104);
            this.tbID.MaxLength = 25;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 147;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(369, 107);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 13);
            this.lblID.TabIndex = 146;
            this.lblID.Text = "Driver\'s ID";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(608, 130);
            this.tbLastName.MaxLength = 25;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 145;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 144;
            this.label3.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(435, 130);
            this.tbFirstName.MaxLength = 25;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 142;
            this.label4.Text = "First Name:";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(697, 415);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(91, 23);
            this.btnClearSearch.TabIndex = 141;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            // 
            // btnDriverEdit
            // 
            this.btnDriverEdit.Location = new System.Drawing.Point(526, 415);
            this.btnDriverEdit.Name = "btnDriverEdit";
            this.btnDriverEdit.Size = new System.Drawing.Size(120, 23);
            this.btnDriverEdit.TabIndex = 140;
            this.btnDriverEdit.Text = "Edit Driver\'s Training";
            this.btnDriverEdit.UseVisualStyleBackColor = true;
            // 
            // tbDriverEdit
            // 
            this.tbDriverEdit.Location = new System.Drawing.Point(462, 418);
            this.tbDriverEdit.MaxLength = 25;
            this.tbDriverEdit.Name = "tbDriverEdit";
            this.tbDriverEdit.Size = new System.Drawing.Size(58, 20);
            this.tbDriverEdit.TabIndex = 139;
            // 
            // lblDriverEdit
            // 
            this.lblDriverEdit.AutoSize = true;
            this.lblDriverEdit.Location = new System.Drawing.Point(369, 421);
            this.lblDriverEdit.Name = "lblDriverEdit";
            this.lblDriverEdit.Size = new System.Drawing.Size(87, 13);
            this.lblDriverEdit.TabIndex = 138;
            this.lblDriverEdit.Text = "Enter Driver\'s ID:";
            // 
            // btnGridDrivers
            // 
            this.btnGridDrivers.Location = new System.Drawing.Point(691, 188);
            this.btnGridDrivers.Name = "btnGridDrivers";
            this.btnGridDrivers.Size = new System.Drawing.Size(97, 23);
            this.btnGridDrivers.TabIndex = 137;
            this.btnGridDrivers.Text = "Search";
            this.btnGridDrivers.UseVisualStyleBackColor = true;
            // 
            // tbGridDrivers
            // 
            this.tbGridDrivers.Location = new System.Drawing.Point(513, 190);
            this.tbGridDrivers.MaxLength = 25;
            this.tbGridDrivers.Name = "tbGridDrivers";
            this.tbGridDrivers.Size = new System.Drawing.Size(172, 20);
            this.tbGridDrivers.TabIndex = 136;
            // 
            // lblGridDrivers
            // 
            this.lblGridDrivers.AutoSize = true;
            this.lblGridDrivers.Location = new System.Drawing.Point(369, 193);
            this.lblGridDrivers.Name = "lblGridDrivers";
            this.lblGridDrivers.Size = new System.Drawing.Size(138, 13);
            this.lblGridDrivers.TabIndex = 135;
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
            this.gridDrivers.TabIndex = 134;
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
            // lblTraining
            // 
            this.lblTraining.AutoSize = true;
            this.lblTraining.Location = new System.Drawing.Point(12, 198);
            this.lblTraining.Name = "lblTraining";
            this.lblTraining.Size = new System.Drawing.Size(128, 13);
            this.lblTraining.TabIndex = 155;
            this.lblTraining.Text = "Selected Driver\'s Training";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(270, 385);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 23);
            this.btnRefresh.TabIndex = 154;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // tbIncidentID
            // 
            this.tbIncidentID.Location = new System.Drawing.Point(108, 385);
            this.tbIncidentID.MaxLength = 5;
            this.tbIncidentID.Name = "tbIncidentID";
            this.tbIncidentID.Size = new System.Drawing.Size(39, 20);
            this.tbIncidentID.TabIndex = 153;
            // 
            // lblTrainingID
            // 
            this.lblTrainingID.AutoSize = true;
            this.lblTrainingID.Location = new System.Drawing.Point(12, 388);
            this.lblTrainingID.Name = "lblTrainingID";
            this.lblTrainingID.Size = new System.Drawing.Size(90, 13);
            this.lblTrainingID.TabIndex = 152;
            this.lblTrainingID.Text = "Enter Training ID:";
            // 
            // btnDeleteIncident
            // 
            this.btnDeleteIncident.Location = new System.Drawing.Point(12, 411);
            this.btnDeleteIncident.Name = "btnDeleteIncident";
            this.btnDeleteIncident.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteIncident.TabIndex = 151;
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
            this.training_id,
            this.training_type});
            this.dataGridView1.Location = new System.Drawing.Point(12, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(318, 162);
            this.dataGridView1.TabIndex = 150;
            // 
            // training_id
            // 
            this.training_id.HeaderText = "Training ID";
            this.training_id.Name = "training_id";
            this.training_id.ReadOnly = true;
            // 
            // training_type
            // 
            this.training_type.HeaderText = "Training Type";
            this.training_type.Name = "training_type";
            this.training_type.ReadOnly = true;
            // 
            // btnAddTraining
            // 
            this.btnAddTraining.Location = new System.Drawing.Point(267, 111);
            this.btnAddTraining.Name = "btnAddTraining";
            this.btnAddTraining.Size = new System.Drawing.Size(63, 59);
            this.btnAddTraining.TabIndex = 149;
            this.btnAddTraining.Text = "Add Training";
            this.btnAddTraining.UseVisualStyleBackColor = true;
            // 
            // groupTrainingTypes
            // 
            this.groupTrainingTypes.Controls.Add(this.radioAdvancedDriving);
            this.groupTrainingTypes.Controls.Add(this.radioCyclistAwareness);
            this.groupTrainingTypes.Controls.Add(this.radioNightDriving);
            this.groupTrainingTypes.Controls.Add(this.radioReduceFuelConsumption);
            this.groupTrainingTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTrainingTypes.Location = new System.Drawing.Point(12, 85);
            this.groupTrainingTypes.Name = "groupTrainingTypes";
            this.groupTrainingTypes.Size = new System.Drawing.Size(249, 85);
            this.groupTrainingTypes.TabIndex = 148;
            this.groupTrainingTypes.TabStop = false;
            this.groupTrainingTypes.Text = "Training Types:";
            // 
            // radioAdvancedDriving
            // 
            this.radioAdvancedDriving.AutoSize = true;
            this.radioAdvancedDriving.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdvancedDriving.Location = new System.Drawing.Point(123, 45);
            this.radioAdvancedDriving.Name = "radioAdvancedDriving";
            this.radioAdvancedDriving.Size = new System.Drawing.Size(110, 17);
            this.radioAdvancedDriving.TabIndex = 3;
            this.radioAdvancedDriving.Text = "Advanced Driving";
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
            // lblTrainingHeader
            // 
            this.lblTrainingHeader.AutoSize = true;
            this.lblTrainingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainingHeader.Location = new System.Drawing.Point(340, 9);
            this.lblTrainingHeader.Name = "lblTrainingHeader";
            this.lblTrainingHeader.Size = new System.Drawing.Size(98, 25);
            this.lblTrainingHeader.TabIndex = 156;
            this.lblTrainingHeader.Text = "Training";
            // 
            // Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTrainingHeader);
            this.Controls.Add(this.lblTraining);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbIncidentID);
            this.Controls.Add(this.lblTrainingID);
            this.Controls.Add(this.btnDeleteIncident);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddTraining);
            this.Controls.Add(this.groupTrainingTypes);
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
            this.Name = "Training";
            this.Text = "Training";
            ((System.ComponentModel.ISupportInitialize)(this.gridDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupTrainingTypes.ResumeLayout(false);
            this.groupTrainingTypes.PerformLayout();
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
        private System.Windows.Forms.Label lblTraining;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbIncidentID;
        private System.Windows.Forms.Label lblTrainingID;
        private System.Windows.Forms.Button btnDeleteIncident;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddTraining;
        private System.Windows.Forms.GroupBox groupTrainingTypes;
        private System.Windows.Forms.RadioButton radioAdvancedDriving;
        private System.Windows.Forms.RadioButton radioCyclistAwareness;
        private System.Windows.Forms.RadioButton radioNightDriving;
        private System.Windows.Forms.RadioButton radioReduceFuelConsumption;
        private System.Windows.Forms.Label lblTrainingHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn training_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn training_type;
    }
}