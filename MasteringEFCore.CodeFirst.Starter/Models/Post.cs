﻿using System;

namespace MasteringEFCore.CodeFirst.Starter.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublishedDateTime { get; set; }

        public int BlogId { get; set; }

        public Blog Blog { get; set; }
    }
}