using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLayer
    {
    public class Reaction
        {
        [Key]
        public int ID { get; private set; }

        [ForeignKey("Type")]
        public int TypeID { get; set; }

        [Required]
        public ReactionType Type { get; set; }

       /* [ForeignKey("User")]
        public int UserID { get; set; }*/

        [Required]
        public User User { get; set; }

        [ForeignKey("Post")]
        public int PostID { get; set; }

        [Required]
        public Post Post { get; set; }

        public DateTime Created_On { get; set; }

        public DateTime Updated_On { get; set; }

        private Reaction()
            {

            }

        public Reaction(ReactionType type, User user, Post post)
            {
            this.Type = type;
            this.User = user;
            this.Post = post;
            this.Created_On = DateTime.Now;
            }
        }
    }
