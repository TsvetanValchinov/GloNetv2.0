using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
    {
    public class User
        {
        [Key]
        public int ID { get; private set; }

        [Required, MaxLength(64)] // it will be unique
        public string Username { get; set; }

        [Required]
        //[Range(4,32, ErrorMessage = "The password must be between 4 and 32 characters!")] 
        public string Password { get; set; }// it will use SHA256 class to hash the password

        public Image ProfilePhoto { get; set; }

        public IEnumerable<User> FollowedUsers { get; set; }// stores other users that this user follows

        public IEnumerable<User> FollowersUsers { get; set; }// stores other users that follow this user

        public IEnumerable<Reaction> Reactions { get; set; }//stores the reactions made by this user

        public IEnumerable<Post> Posts { get; set; }// stores the posts of this user

        public IEnumerable<Comment> Comments { get; set; }// stores the comments of this user
        private User()
            {

            }

        public User(string username, string password)
            {
            this.Username = username;
            this.Password = password;
            }
        }
    }
