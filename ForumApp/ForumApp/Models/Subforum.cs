﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForumApp.Models
{
    public class Subforum
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Subforumul trebuie sa apartina de un forum!")]
        public int ForumId { get; set; }

        [Required(ErrorMessage = "Tipul subforumului este obligatoriu!")]
        public int SubforumType { get; set; }

        [Required(ErrorMessage = "Numele subforumului este obligatoriu!")]
        [MinLength(5, ErrorMessage = "Lungimea minima trebuie sa fie de 5 caractere")]
        [StringLength(100, ErrorMessage = "Lungimea maxima trebuie sa fie de 100 de caractere")]
        public string SubforumName { get; set; }

        public int MsgCount { get; set; }
        public int ViewCount { get; set; }
        
        // [Required(ErrorMessage = "Precizarea userului care a creat subforumul este obligatorie!")]

        public string? Creator { get; set; }

        public string? LastPostUsr { get; set; }

        public string? SubforumDesc { get; set; }

        [Required(ErrorMessage = "Data crearii subforumului este obligatorie!")]
        public DateTime CreationDate { get; set; }
        public virtual Forum? Forum { get; set; }
        public virtual Section? Section { get; set; }

        public virtual ICollection<Post>? Posts { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem>? AccessLevel { get; set; }

    }
}
