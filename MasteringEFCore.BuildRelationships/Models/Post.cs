using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.BuildRelationships.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        [FutureOnly]
        public DateTime PublishedDateTime { get; set; }

        [ForeignKey("SomeBlogId")]
        public int BlogId { get; set; }

        public Blog Blog { get; set; }

        public ICollection<TagPost> TagPosts { get; set; }
    }

    public class FutureOnlyAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var post = (Post)validationContext.ObjectInstance;
            return post.PublishedDateTime.CompareTo(DateTime.Now) < 0
                        ? new ValidationResult("Data de Publicação só pode ser futura!")
            : ValidationResult.Success;
        }
    }
}
