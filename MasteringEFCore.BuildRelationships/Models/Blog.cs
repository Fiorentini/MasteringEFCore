using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.BuildRelationships.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Url(ErrorMessage = "URl inválida!")]
        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }

        public int AuthorId { get; set; }

        public User Author { get; set; }
    }
}
