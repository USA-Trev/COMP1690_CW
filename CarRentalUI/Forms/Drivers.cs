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
    public partial class Drivers : Form
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();

        // DB resources used in the events below
        DatabaseConnection db = new DatabaseConnection();
        DataTable dt = new DataTable();
        string populateGridQuery = "SELECT DriverID, FirstName, LastName, Email FROM Driver;";

        public Drivers()
        {
            InitializeComponent();
            RefreshGridDrivers();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                if (tbFirstName.Text != null && tbLastName.Text != null && tbPhone.Text != null
                && tbEmail.Text != null && tbLicenceNumber.Text != null && tbLicenceExpiration.Text != null
                && tbLicenceExpiration.Text.Length == 8)
                {
                    // New driver object - textbox inputs are passed into the new driver
                    Driver d = new Driver(tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbPhone.Text,
                        tbLicenceNumber.Text, tbLicenceExpiration.Text, 0);

                    // Generate INSERT statement for query
                    string driverInsertQuery = "INSERT INTO Driver(FirstName, LastName, Email, PhoneNumber, " +
                        "LicenceNumber, LicenceExpiration, HoursWorked) " +
                        "VALUES (" + "'" + d.firstName + "'" + ", " + "'" + d.lastName + "'"
                        + ", " + "'" + d.email + "'" + ", " + "'" + d.phoneNumber + "'" + ", " + "'" + d.licenceNumber + "'"
                        + ", " + "'" + d.licenceExpiration + "'" + ", " + 0 + ");";

                    // Execute the INSERT driver SQL statement.
                    try
                    {
                        db.Open();
                        db.ExecuteQuery(driverInsertQuery);
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

                    // Notify user that new driver has been added to DB
                    MessageBox.Show("New driver successfully added.", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    RefreshGridDrivers();
                }
                else
                {
                    MessageBox.Show("Details input incorrectly", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (tbFirstName.Text != null && tbLastName.Text != null && tbPhone.Text != null
                && tbEmail.Text != null && tbLicenceNumber.Text != null && tbLicenceExpiration.Text != null
                && tbLicenceExpiration.Text.Length == 8)
                {
                    // New driver object - textbox inputs are passed into the new driver
                    Driver d = new Driver(tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbPhone.Text,
                        tbLicenceNumber.Text, tbLicenceExpiration.Text, Int32.Parse(tbHoursWorked.Text));

                    // Generate UPDATE statement for query
                    string driverUpdateQuery = "UPDATE Driver SET FirstName = " + "'" + d.firstName + "'" + ", " + "LastName = " + "'" + d.lastName + "'" + ", " + "Email = " + "'" + d.email + "'" +
                        ", " + "PhoneNumber = " + "'" + d.phoneNumber + "'" + ", " + "LicenceNumber = " + "'" + d.licenceNumber + "'" + ", " +
                        "LicenceExpiration = " + "'" + d.licenceExpiration + "'" + ", " + "HoursWorked = " + "'" + d.hoursWorked + "'" + " WHERE DriverID = " + "'" + tbID.Text + "'" + ";";

                    // Execute the UPDATE driver SQL statement.
                    try
                    {
                        db.Open();
                        db.ExecuteQuery(driverUpdateQuery);
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

                    RefreshGridDrivers();

                    // Notify user that driver info has been updated
                    MessageBox.Show("Driver's info successfully updated.", "Success!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Details input incorrectly", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            RefreshGridDrivers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRowDriverID = GetSelectedRowDriverID();

            string deleteDriverQuery = "DELETE FROM Driver WHERE DriverID = " + "'" + selectedRowDriverID + "'" + ";";
            try
            {
                db.Open();
                db.ExecuteQuery(deleteDriverQuery);
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

            RefreshGridDrivers();
        }

        private void btnEditDriver_Click(object sender, EventArgs e)
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
            }
        }

        private void btnGridDriversSearch_Click(object sender, EventArgs e)
        {
            string searchText = tbGridDriversSearch.Text;
            string selectDriverQuery = "SELECT DriverID, FirstName, LastName, Email FROM Driver WHERE LastName = " + "'" + searchText + "';";
            db.Open();
            dt = db.OutputResults(selectDriverQuery);
            db.Close();

            gridDrivers.DataSource = dt;
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
    }
}
