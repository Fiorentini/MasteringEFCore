using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.BuildRelationships.Models
{
    public class User
    {
        public int Id { get; set; }

        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Somentes letras são permitidas!")]
        public string Name { get; set; }

        public ICollection<Post> Blogs { get; set; }

        public Address Address { get; set; }
    }
}
