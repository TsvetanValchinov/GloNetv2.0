using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServiceLayer.Controllers;
using BusinessLayer;

namespace PresentationLayer
    {
    public partial class RegistrationForm : Form
        {
        string inputUsername;
        string inputPassword;
        public RegistrationForm()
            {
            InitializeComponent();
            }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
            {
            inputUsername = UsernameTextBox.Text;
            }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
            {
            inputPassword = PasswordTextBox.Text;
            }

        private void RegistrationButton_Click(object sender, EventArgs e)
            {
            try
                {
                UserController _userController = new UserController(DbContextController.CreateContext());
                _userController.CheckIfUsernameIsUsed(inputUsername);
                if (_userController.CheckIfUsernameIsUsed(inputUsername) == false)
                    {
                    User userToSignUp = new User(inputUsername, inputPassword);
                    _userController.Create(userToSignUp);
                    MessageBox.Show("Registration Successful!");
                    }
                else
                    {
                    MessageBox.Show("This username is already used. Please enter different username!");
                    }
                }
            catch (Exception ex)
                {
                throw ex;
                }
            
            }

        private void RegistrationForm_Load(object sender, EventArgs e)
            {

            }

        private void GoBackButton_Click(object sender, EventArgs e)
            {
            HomePageForm homePageForm = new HomePageForm();
            this.Hide();
            homePageForm.Show();
            this.Dispose(true);
            this.Close();
            }
        }
    }
