
namespace CarRentalUI.Forms
{
    partial class Home
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
            this.gridLicenceExpr = new System.Windows.Forms.DataGridView();
            this.lblHomeHeader = new System.Windows.Forms.Label();
            this.gridTrainingExpr = new System.Windows.Forms.DataGridView();
            this.gridQualificationExpr = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLicenceExpr = new System.Windows.Forms.Label();
            this.lblQualificationExpr = new System.Windows.Forms.Label();
            this.lblTrainingExpr = new System.Windows.Forms.Label();
            this.btnLicenceExport = new System.Windows.Forms.Button();
            this.btnQualificationExport = new System.Windows.Forms.Button();
            this.btnTrainingExport = new System.Windows.Forms.Button();
            this.groupNavigation = new System.Windows.Forms.GroupBox();
            this.btnLookupDriver = new System.Windows.Forms.Button();
            this.btnIncidentRecords = new System.Windows.Forms.Button();
            this.btnTrainingSession = new System.Windows.Forms.Button();
            this.btnTraining = new System.Windows.Forms.Button();
            this.btnQualifications = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLicenceExpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrainingExpr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQualificationExpr)).BeginInit();
            this.groupNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLicenceExpr
            // 
            this.gridLicenceExpr.AllowUserToAddRows = false;
            this.gridLicenceExpr.AllowUserToDeleteRows = false;
            this.gridLicenceExpr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLicenceExpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLicenceExpr.Location = new System.Drawing.Point(306, 86);
            this.gridLicenceExpr.MultiSelect = false;
            this.gridLicenceExpr.Name = "gridLicenceExpr";
            this.gridLicenceExpr.ReadOnly = true;
            this.gridLicenceExpr.Size = new System.Drawing.Size(475, 93);
            this.gridLicenceExpr.TabIndex = 0;
            // 
            // lblHomeHeader
            // 
            this.lblHomeHeader.AutoSize = true;
            this.lblHomeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeHeader.Location = new System.Drawing.Point(352, 9);
            this.lblHomeHeader.Name = "lblHomeHeader";
            this.lblHomeHeader.Size = new System.Drawing.Size(72, 25);
            this.lblHomeHeader.TabIndex = 1;
            this.lblHomeHeader.Text = "Home";
            // 
            // gridTrainingExpr
            // 
            this.gridTrainingExpr.AllowUserToAddRows = false;
            this.gridTrainingExpr.AllowUserToDeleteRows = false;
            this.gridTrainingExpr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTrainingExpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrainingExpr.Location = new System.Drawing.Point(306, 345);
            this.gridTrainingExpr.MultiSelect = false;
            this.gridTrainingExpr.Name = "gridTrainingExpr";
            this.gridTrainingExpr.ReadOnly = true;
            this.gridTrainingExpr.Size = new System.Drawing.Size(475, 93);
            this.gridTrainingExpr.TabIndex = 3;
            // 
            // gridQualificationExpr
            // 
            this.gridQualificationExpr.AllowUserToAddRows = false;
            this.gridQualificationExpr.AllowUserToDeleteRows = false;
            this.gridQualificationExpr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridQualificationExpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQualificationExpr.Location = new System.Drawing.Point(306, 218);
            this.gridQualificationExpr.MultiSelect = false;
            this.gridQualificationExpr.Name = "gridQualificationExpr";
            this.gridQualificationExpr.ReadOnly = true;
            this.gridQualificationExpr.Size = new System.Drawing.Size(475, 93);
            this.gridQualificationExpr.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(771, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLicenceExpr
            // 
            this.lblLicenceExpr.AutoSize = true;
            this.lblLicenceExpr.Location = new System.Drawing.Point(306, 67);
            this.lblLicenceExpr.Name = "lblLicenceExpr";
            this.lblLicenceExpr.Size = new System.Drawing.Size(162, 13);
            this.lblLicenceExpr.TabIndex = 5;
            this.lblLicenceExpr.Text = "Licences expiring within 30 days:";
            // 
            // lblQualificationExpr
            // 
            this.lblQualificationExpr.AutoSize = true;
            this.lblQualificationExpr.Location = new System.Drawing.Point(306, 202);
            this.lblQualificationExpr.Name = "lblQualificationExpr";
            this.lblQualificationExpr.Size = new System.Drawing.Size(182, 13);
            this.lblQualificationExpr.TabIndex = 6;
            this.lblQualificationExpr.Text = "Qualifications expiring within 30 days:";
            // 
            // lblTrainingExpr
            // 
            this.lblTrainingExpr.AutoSize = true;
            this.lblTrainingExpr.Location = new System.Drawing.Point(306, 329);
            this.lblTrainingExpr.Name = "lblTrainingExpr";
            this.lblTrainingExpr.Size = new System.Drawing.Size(157, 13);
            this.lblTrainingExpr.TabIndex = 7;
            this.lblTrainingExpr.Text = "Training expiring within 30 days:";
            // 
            // btnLicenceExport
            // 
            this.btnLicenceExport.Location = new System.Drawing.Point(787, 86);
            this.btnLicenceExport.Name = "btnLicenceExport";
            this.btnLicenceExport.Size = new System.Drawing.Size(59, 23);
            this.btnLicenceExport.TabIndex = 8;
            this.btnLicenceExport.Text = "Export";
            this.btnLicenceExport.UseVisualStyleBackColor = true;
            // 
            // btnQualificationExport
            // 
            this.btnQualificationExport.Location = new System.Drawing.Point(787, 218);
            this.btnQualificationExport.Name = "btnQualificationExport";
            this.btnQualificationExport.Size = new System.Drawing.Size(59, 23);
            this.btnQualificationExport.TabIndex = 9;
            this.btnQualificationExport.Text = "Export";
            this.btnQualificationExport.UseVisualStyleBackColor = true;
            // 
            // btnTrainingExport
            // 
            this.btnTrainingExport.Location = new System.Drawing.Point(787, 345);
            this.btnTrainingExport.Name = "btnTrainingExport";
            this.btnTrainingExport.Size = new System.Drawing.Size(59, 23);
            this.btnTrainingExport.TabIndex = 10;
            this.btnTrainingExport.Text = "Export";
            this.btnTrainingExport.UseVisualStyleBackColor = true;
            // 
            // groupNavigation
            // 
            this.groupNavigation.Controls.Add(this.btnLookupDriver);
            this.groupNavigation.Controls.Add(this.btnIncidentRecords);
            this.groupNavigation.Controls.Add(this.btnTrainingSession);
            this.groupNavigation.Controls.Add(this.btnTraining);
            this.groupNavigation.Controls.Add(this.btnQualifications);
            this.groupNavigation.Controls.Add(this.btnDrivers);
            this.groupNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNavigation.Location = new System.Drawing.Point(12, 86);
            this.groupNavigation.Name = "groupNavigation";
            this.groupNavigation.Size = new System.Drawing.Size(288, 199);
            this.groupNavigation.TabIndex = 11;
            this.groupNavigation.TabStop = false;
            this.groupNavigation.Text = "Navigation:";
            // 
            // btnLookupDriver
            // 
            this.btnLookupDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookupDriver.Location = new System.Drawing.Point(6, 167);
            this.btnLookupDriver.Name = "btnLookupDriver";
            this.btnLookupDriver.Size = new System.Drawing.Size(275, 23);
            this.btnLookupDriver.TabIndex = 5;
            this.btnLookupDriver.Text = "Lookup Drivers";
            this.btnLookupDriver.UseVisualStyleBackColor = true;
            this.btnLookupDriver.Click += new System.EventHandler(this.btnLookupDriver_Click);
            // 
            // btnIncidentRecords
            // 
            this.btnIncidentRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidentRecords.Location = new System.Drawing.Point(6, 138);
            this.btnIncidentRecords.Name = "btnIncidentRecords";
            this.btnIncidentRecords.Size = new System.Drawing.Size(275, 23);
            this.btnIncidentRecords.TabIndex = 4;
            this.btnIncidentRecords.Text = "Drivers\' Incident Records";
            this.btnIncidentRecords.UseVisualStyleBackColor = true;
            this.btnIncidentRecords.Click += new System.EventHandler(this.btnIncidentRecords_Click);
            // 
            // btnTrainingSession
            // 
            this.btnTrainingSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainingSession.Location = new System.Drawing.Point(6, 109);
            this.btnTrainingSession.Name = "btnTrainingSession";
            this.btnTrainingSession.Size = new System.Drawing.Size(275, 23);
            this.btnTrainingSession.TabIndex = 3;
            this.btnTrainingSession.Text = "Assign Drivers to Training Sessions";
            this.btnTrainingSession.UseVisualStyleBackColor = true;
            this.btnTrainingSession.Click += new System.EventHandler(this.btnTrainingSession_Click);
            // 
            // btnTraining
            // 
            this.btnTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraining.Location = new System.Drawing.Point(6, 80);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(275, 23);
            this.btnTraining.TabIndex = 2;
            this.btnTraining.Text = "Add / Edit / Delete Training";
            this.btnTraining.UseVisualStyleBackColor = true;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // btnQualifications
            // 
            this.btnQualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQualifications.Location = new System.Drawing.Point(6, 51);
            this.btnQualifications.Name = "btnQualifications";
            this.btnQualifications.Size = new System.Drawing.Size(275, 23);
            this.btnQualifications.TabIndex = 1;
            this.btnQualifications.Text = "Add / Edit / Delete Qualifications";
            this.btnQualifications.UseVisualStyleBackColor = true;
            this.btnQualifications.Click += new System.EventHandler(this.btnQualifications_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.Location = new System.Drawing.Point(7, 22);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(275, 23);
            this.btnDrivers.TabIndex = 0;
            this.btnDrivers.Text = "Add / Edit / Delete Drivers";
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.groupNavigation);
            this.Controls.Add(this.btnTrainingExport);
            this.Controls.Add(this.btnQualificationExport);
            this.Controls.Add(this.btnLicenceExport);
            this.Controls.Add(this.lblTrainingExpr);
            this.Controls.Add(this.lblQualificationExpr);
            this.Controls.Add(this.lblLicenceExpr);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gridTrainingExpr);
            this.Controls.Add(this.gridQualificationExpr);
            this.Controls.Add(this.lblHomeHeader);
            this.Controls.Add(this.gridLicenceExpr);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.gridLicenceExpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrainingExpr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQualificationExpr)).EndInit();
            this.groupNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLicenceExpr;
        private System.Windows.Forms.Label lblHomeHeader;
        private System.Windows.Forms.DataGridView gridTrainingExpr;
        private System.Windows.Forms.DataGridView gridQualificationExpr;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblLicenceExpr;
        private System.Windows.Forms.Label lblQualificationExpr;
        private System.Windows.Forms.Label lblTrainingExpr;
        private System.Windows.Forms.Button btnLicenceExport;
        private System.Windows.Forms.Button btnQualificationExport;
        private System.Windows.Forms.Button btnTrainingExport;
        private System.Windows.Forms.GroupBox groupNavigation;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnLookupDriver;
        private System.Windows.Forms.Button btnIncidentRecords;
        private System.Windows.Forms.Button btnTrainingSession;
        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Button btnQualifications;
    }
}