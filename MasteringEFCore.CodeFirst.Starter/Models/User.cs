using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.CodeFirst.Starter.Models
{
    public class User
    {
        public int Id { get; set; }

        public string DisplayName { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public ICollection<Blog> Blogs { get; set; }

        public ICollection<Post> Posts { get; set; }

        //public ICollection<Comment> Comments { get; set; }

        public Address Address { get; set; }

        public int PersonId { get; set; }

        //public Person Person { get; set; }
    }
}
