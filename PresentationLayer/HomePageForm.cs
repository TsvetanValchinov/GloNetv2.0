using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using ServiceLayer.Controllers;

namespace PresentationLayer
    {
    public partial class HomePageForm : Form
        {
        string inputUsername;
        string inputPassword;
        public HomePageForm()
            {
            InitializeComponent();
            }

        private void HomePageForm_Load(object sender, EventArgs e)
            {

            }

        private void HomePageForm_Closing(object sender, EventArgs e)
            {
            this.Dispose(true);
            Application.Exit();
            }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
            {
             inputUsername = UsernameTextBox.Text;
            }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
            {
            inputPassword = PasswordTextBox.Text;         
            }

        private void WelcomeLabel_Click(object sender, EventArgs e)
            {

            }

        private void SignInButton_Click(object sender, EventArgs e)
            {
            try
                {
                UserController _usercontroler = new UserController(DbContextController.CreateContext());
                User userSignedIn = _usercontroler.CheckForUser(inputUsername, inputPassword);
                if (userSignedIn != null)
                    {
                    // close this form and open other one with information about the [userSignedIn]
                    UserProfileForm userProfileForm = new UserProfileForm(inputUsername);
                    this.Hide();
                    userProfileForm.Show();
                    }
                else
                    {
                    MessageBox.Show("Username or password is incorrect!");
                    }
                }
            catch (Exception ex)
                {
                throw ex;
                }
            
            }

        private void RegistrationButton_Click(object sender, EventArgs e)
            {
            try
                {
                RegistrationForm registrationForm = new RegistrationForm();
                this.Hide();
                registrationForm.Show();
                }
            catch (Exception ex)
                {
                throw ex;
                }
            }
        }
    }
