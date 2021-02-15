using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using CarRentalClassLibrary.Classes;
using BCrypt.Net;
using System.Data.SqlClient;

namespace CarRentalUI.Forms
{
    public partial class Login : Form
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();
        public Login()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (boxUsername.Text.Length != 0 && boxPassword.Text.Length != 0)
            {
                string confirmPassword = Interaction.InputBox("Please enter your password again for confirmation.", "Confirm Password", "", 1, -1);
                int minUsernameLength = 6;
                int minPasswordLength = 8;

                if (boxUsername.Text.Length >= minUsernameLength && boxPassword.Text.Length >= minPasswordLength && boxPassword.Text == confirmPassword)
                {
                    try
                    {
                        // Salt and Hash password.
                        string salt = BCrypt.Net.BCrypt.GenerateSalt();
                        string hash = BCrypt.Net.BCrypt.HashPassword(boxPassword.Text, salt);

                        // Generate query string for new Admin insert statement.
                        string adminInsert = "INSERT INTO Admin (Username, PasswordHash, PasswordSalt) " +
                            "VALUES (" + "'" + boxUsername.Text + "'" + ", " + "'" + hash + "'" + ", " + "'" + salt + "'" + ");";

                        // Open new DB connection and execute Admin insert.
                        DatabaseConnection db = new DatabaseConnection();
                        db.Open();
                        db.ExecuteQuery(adminInsert);
                        db.Close();

                        // Prompt user that account has been created.
                        MessageBox.Show("Account created successfully.",
                            "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        // Redirect to Admin Homepage.
                        this.Hide();
                        Home home = new Home();
                        home.Show();
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
                }
                else
                {
                    if (boxUsername.Text.Length < minUsernameLength)
                    {
                        // Username did not meet the minimum required 6-character length.
                        MessageBox.Show("Username must be at least 6 characters long.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (boxPassword.Text.Length < minPasswordLength)
                    {
                        // Password did not meet the minimum required 8-character length.
                        MessageBox.Show("Password must be at leasat 8 characters long.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Password and Confirmation did not match.
                        MessageBox.Show("The input password and confirmation password did not match.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Username and/or password is null.
                MessageBox.Show("Neither username nor password can be empty.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();
            DataTable dt = new DataTable();

            try
            {
                // Retrieve hashed password and salt from database
                string query = "SELECT PasswordHash, PasswordSalt FROM Admin WHERE Username = '" + boxUsername.Text + "';";
                db.Open();
                dt = db.OutputResults(query);
                db.Close();
                string storedHashedPW = (string)dt.Rows[0].ItemArray[0];
                string storedSalt = (string)dt.Rows[0].ItemArray[1];

                // Hash input password with salt from DB
                string hash = BCrypt.Net.BCrypt.HashPassword(boxPassword.Text, storedSalt);

                if (hash == storedHashedPW)
                {
                    // Successful login - redirect to Admin homepage.
                    this.Hide();
                    Home home = new Home();
                    home.Show();
                }
                else
                {
                    // Invalid user credentials
                    MessageBox.Show("Invalid password.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.IndexOutOfRangeException ex)
            {
                // The input username did not return any rows from the DB
                MessageBox.Show("Incorrect username.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                log.Error(
                            Environment.NewLine + "---------------- START ----------------" + Environment.NewLine +
                            ex.Message + Environment.NewLine
                            + ex.StackTrace + Environment.NewLine +
                            "----------------- END -----------------" +
                            Environment.NewLine + Environment.NewLine
                            );

                MessageBox.Show("An error occurred.",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
