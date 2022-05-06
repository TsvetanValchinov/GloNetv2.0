using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using ServiceLayer.Controllers;
using System.Linq;

namespace PresentationLayer
    {
    public partial class UserProfileForm : Form
        {
        UserController _userController = new UserController(DbContextController.CreateContext());
         User userLoggedIn;
        string usernameSearched;

        public UserProfileForm()
            {
            InitializeComponent();
            }

        public UserProfileForm(string username)
            {
            InitializeComponent();
            this.userLoggedIn = _userController.findUserByUsername(username);
            }

        private void UserProfileForm_Load(object sender, EventArgs e)
            {
            this.Text = userLoggedIn.Username;
            this.UsernameLabel.Text = userLoggedIn.Username;
            this.postsLabel.Text = "Posts: " + GetUserPostsNumber(); 
            }

        private void SeeAllPostsButton_Click(object sender, EventArgs e)
            {
            // goes to another form with all of the user's posts
            }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
            {
            usernameSearched = SearchTextBox.Text;
            }

        private void SearchButton_Click(object sender, EventArgs e)
            {
            User userSearched = _userController.findUserByUsername(usernameSearched);
            if(userSearched != null)
                {
                SeeOtherUserProfileForm seeOtherUserProfileForm = new SeeOtherUserProfileForm(userLoggedIn, userSearched);
                this.Hide();
                seeOtherUserProfileForm.Show();
                this.Close();
                }
            else
                {
                MessageBox.Show("There is no user with this username!");
                }
            }

        private void LogOutButton_Click(object sender, EventArgs e)
            {
            HomePageForm homePageForm = new HomePageForm();
            this.Hide();
            homePageForm.Show();
            this.Close();
            }

        private void UpdateProfileButton_Click(object sender, EventArgs e)
            {
            UpdateProfileForm updateProfileForm = new UpdateProfileForm(userLoggedIn);
            this.Hide();
            updateProfileForm.Show();
            this.Close();
            }
        private int GetUserPostsNumber()
            {
            List<Post> posts = new List<Post>();
            if (userLoggedIn.Posts == null)
                {
                return 0;
                }
            else
                {
                posts = userLoggedIn.Posts.ToList();
                }
            return posts.Count;
            }

        private void CreateNewPostButton_Click(object sender, EventArgs e)
            {
            CreatePostForm createPostForm = new CreatePostForm(userLoggedIn);
            this.Hide();
            createPostForm.Show();
            this.Close();
            }
        }
    }
