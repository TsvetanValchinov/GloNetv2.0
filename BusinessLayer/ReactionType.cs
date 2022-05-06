using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer
    {
    public class ReactionType
        {
        [Key]
        public int ID { get; private set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public Image ReactionPhoto { get; set; }
        private ReactionType()
            {

            }

        public ReactionType(string type, Image reactionPhoto)
            {
            this.Type = type;
            this.ReactionPhoto = reactionPhoto;
            }
        }
    }
