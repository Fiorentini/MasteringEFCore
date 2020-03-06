using System;
using System.Collections.Generic;
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

        public DateTime PublishedDateTime { get; set; }

        [ForeignKey("SomeBlogId")]
        public int BlogId { get; set; }

        public Blog Blog { get; set; }

        public ICollection<TagPost> TagPosts { get; set; }
    }
}
