using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalClassLibrary.Classes;

namespace CarRentalUI.Forms
{
    public partial class DriverProfiles : Form
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();

        // DB resources used in the events below
        DatabaseConnection db = new DatabaseConnection();
        DataTable dt = new DataTable();
        string populateGridQuery = "SELECT DriverID, FirstName, LastName, Email FROM Driver;";

        public DriverProfiles()
        {
            InitializeComponent();
            RefreshGridDrivers();
        }

        private void btnGridDrivers_Click(object sender, EventArgs e)
        {
            string searchText = tbGridDriversSearch.Text;
            string selectDriverQuery = "SELECT DriverID, FirstName, LastName, Email FROM Driver WHERE LastName = " + "'" + searchText + "';";
            db.Open();
            dt = db.OutputResults(selectDriverQuery);
            db.Close();

            gridDrivers.DataSource = dt;
        }

        private void btnDriverEdit_Click(object sender, EventArgs e)
        {
            if (gridDrivers.SelectedCells.Count > 0)
            {
                int selectedRowDriverID = GetSelectedRowDriverID();

                string selectDriverQuery = "SELECT * FROM Driver WHERE DriverID = " + "'" + selectedRowDriverID + "'" + ";";
                try
                {
                    db.Open();
                    dt = db.OutputResults(selectDriverQuery);
                    db.Close();
                }
                catch (Exception ex)
                {
                    // Log exception to file - C:\Users\Trevor\source\repos\CarRental\Logs\RollingLogFile.txt 
                    log.Error(
                        Environment.NewLine + "---------------- START ----------------" + Environment.NewLine +
                        ex.Message + Environment.NewLine
                        + ex.StackTrace + Environment.NewLine +
                        "----------------- END -----------------" +
                        Environment.NewLine + Environment.NewLine
                        );

                    // Prompt user that error occurred.
                    MessageBox.Show("An error occurred.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

                ClearTextBoxes();

                DateTime expiration = DateTime.Parse(dt.Rows[0].ItemArray[6].ToString());
                string trimmedExpiration = expiration.ToShortDateString();

                tbID.Text += dt.Rows[0].ItemArray[0];
                tbFirstName.Text += dt.Rows[0].ItemArray[1];
                tbLastName.Text += dt.Rows[0].ItemArray[2];
                tbEmail.Text += dt.Rows[0].ItemArray[3];
                tbPhone.Text += dt.Rows[0].ItemArray[4];
                tbLicenceNumber.Text += dt.Rows[0].ItemArray[5];
                tbLicenceExpiration.Text += trimmedExpiration;
                tbHoursWorked.Text += dt.Rows[0].ItemArray[7];

                PopulateGrids();
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            RefreshGridDrivers();
        }

        //////////////////////////// Helper Methods ////////////////////////////

        private int GetSelectedRowDriverID()
        {
            // Get driver ID from selected cell's row.
            int selectedRowNo = gridDrivers.CurrentRow.Index;
            DataGridViewRow selectedRow = gridDrivers.Rows[selectedRowNo];
            int selectedRowDriverID = Convert.ToInt32(selectedRow.Cells["DriverID"].Value);

            return selectedRowDriverID;
        }
        private void RefreshGridDrivers()
        {
            db.Open();
            dt = db.OutputResults(populateGridQuery);
            db.Close();

            gridDrivers.DataSource = dt;
        }

        private void ClearTextBoxes()
        {
            tbID.Text = null;
            tbFirstName.Text = null;
            tbLastName.Text = null;
            tbEmail.Text = null;
            tbPhone.Text = null;
            tbLicenceNumber.Text = null;
            tbLicenceExpiration.Text = null;
            tbHoursWorked.Text = null;
        }

        private void PopulateGrids()
        {
            string queryQualifications = "SELECT QualificationTitle AS Obtained_Qualifications FROM Qualification AS Q " +
                "JOIN DriverQualIfication AS DQ ON DQ.QualificationID = Q.QualificationID " +
                "JOIN Driver AS D ON D.DriverID = DQ.DriverID " +
                "WHERE D.DriverID = " + tbID.Text + ";";
            string queryTraining = "SELECT TrainingTitle AS Completed_Training FROM Training AS T " +
                "JOIN DriverTraining AS DT ON DT.TrainingID = T.TrainingID " +
                "JOIN Driver AS D ON D.DriverID = DT.DriverID " +
                "WHERE D.DriverID = " + tbID.Text + ";";
            //string queryTrainingSessions = "";

            db.Open();
            dt = db.OutputResults(queryQualifications);
            gridQualifications.DataSource = dt;
            dt = db.OutputResults(queryTraining);
            gridTraining.DataSource = dt;
            db.Close();
        }
    }
}
