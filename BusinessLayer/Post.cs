using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLayer
    {
    public class Post
        {
        [Key]
        public int ID { get; private set; }

        [MaxLength(200), Required]
        public string Title { get; set; }

        [MaxLength(32000)]
        public string Content { get; set; }

        public Image Photo { get; set; }

        /*[ForeignKey("User")]
        public int UserID { get; set; }*/

        [Required]
        public User User { get; set; }

        public DateTime Created_On { get; set; }

        public DateTime Updated_On { get; set; }

        public bool IsVisible { get; set; }// in the constructor it is initialized as true (default-true)

        public IEnumerable<Reaction> Reactions { get; set; } 

        public IEnumerable<Comment> Comments { get; set; }

        private Post()
            {

            }

        public Post(User user, string title)
            {
            this.User = user;
            this.Title = title;
            this.IsVisible = true;
            this.Created_On = DateTime.Now;
            }
        }
    }
