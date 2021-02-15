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
    public partial class Home : Form
    {
        // DB resources used in the events below
        DatabaseConnection db = new DatabaseConnection();
        DataTable dt = new DataTable();
        string licenceGridQuery = "SELECT FirstName, LastName, LicenceNumber, LicenceExpiration FROM Driver " +
            "WHERE LicenceExpiration BETWEEN GETDATE() AND CONVERT(DATE, DATEADD(DAY, 30, GETDATE()));";
        string qualificationGridQuery = "SELECT FirstName, LastName, Email FROM Driver;";
        string trainingGridQuery = "SELECT FirstName, LastName, Email FROM Driver;";

        public Home()
        {
            InitializeComponent();
            RefreshExprGrids();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.Show();
        }

        private void btnQualifications_Click(object sender, EventArgs e)
        {
            Qualifications quals = new Qualifications();
            quals.Show();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            Training training = new Training();
            training.Show();
        }

        private void btnTrainingSession_Click(object sender, EventArgs e)
        {
            TrainingSessions sessions = new TrainingSessions();
            sessions.Show();
        }

        private void btnIncidentRecords_Click(object sender, EventArgs e)
        {
            DriverRecords records = new DriverRecords();
            records.Show();
        }

        private void btnLookupDriver_Click(object sender, EventArgs e)
        {
            DriverProfiles profiles = new DriverProfiles();
            profiles.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void RefreshExprGrids()
        {
            db.Open();
            dt = db.OutputResults(licenceGridQuery);
            gridLicenceExpr.DataSource = dt;
            //dt = db.OutputResults(qualificationGridQuery);
            //gridQualificationExpr.DataSource = dt;
            //dt = db.OutputResults(trainingGridQuery);
            //gridTrainingExpr.DataSource = dt;
            db.Close();
        }
    }
}
