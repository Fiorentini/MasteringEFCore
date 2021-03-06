﻿using System;
using System.Collections.Generic;

namespace MasteringEFCore.DatabaseFirst.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDateTime { get; set; }
        public string Title { get; set; }

        public Blog Blog { get; set; }
    }
}
