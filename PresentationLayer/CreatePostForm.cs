using BusinessLayer;
using ServiceLayer.Controllers;
using System;
using System.Windows.Forms;

namespace PresentationLayer
    {
    public partial class CreatePostForm : Form
        {
        PostController _postController = new PostController(DbContextController.CreateContext());
        User userLoggedIn;
        string titleEntered;
        string contentEntered;
        public CreatePostForm()
            {
            InitializeComponent();
            }

        public CreatePostForm(User userLoggedIn)
            {
            InitializeComponent();
            this.userLoggedIn = userLoggedIn;
            }

        private void CreatePostForm_Load(object sender, EventArgs e)
            {
            this.UsernameLabel.Text = "Username: " + userLoggedIn.Username;
            }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
            {
            titleEntered = TitleTextBox.Text;
            }

        private void ContentTextBox_TextChanged(object sender, EventArgs e)
            {
            contentEntered = ContentTextBox.Text;
            }

        private void CreatePostButton_Click(object sender, EventArgs e)
            {
            try
                {
                Post createdPost = new Post(null, titleEntered);
                createdPost.Content = contentEntered;
                _postController.Create(createdPost);             
                MessageBox.Show("Post created successfully!");
                } 
            catch (Exception ex)
                {
                throw ex;
                }
            }
        }
    }
