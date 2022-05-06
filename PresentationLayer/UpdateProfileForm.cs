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
    public partial class UpdateProfileForm : Form
        {
        UserController _userController = new UserController(DbContextController.CreateContext());
        User userLoggedIn;
        string newUsername;
        string newPassword;
        public UpdateProfileForm()
            {
            InitializeComponent();
            }

        public UpdateProfileForm(User user)
            {
            this.userLoggedIn = user;
            InitializeComponent();
            }
        private void UpdateProfileForm_Load(object sender, EventArgs e)
            {
            this.UsernameLabel.Text = "Username:" + userLoggedIn.Username;
            }

        private void NewUsernameTextBox_TextChanged(object sender, EventArgs e)
            {
            newUsername = NewUsernameTextBox.Text;
            }

        private void NewPasswordTextBox_TextChanged(object sender, EventArgs e)
            {
            newPassword = NewPasswordTextBox.Text;
            }

        private void updateProfileButton_Click(object sender, EventArgs e)
            {
            try
                {
                userLoggedIn.Username = newUsername;
                userLoggedIn.Password = newPassword;
                _userController.Update(userLoggedIn);
                MessageBox.Show("Profile updated successfully!");
                }
            catch (Exception ex)
                {
                throw ex;
                }  
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
