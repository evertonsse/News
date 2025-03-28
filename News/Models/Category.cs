﻿using System.ComponentModel.DataAnnotations.Schema;

namespace News.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [NotMapped]
        public int Hits { get; set; }

        public List<Post> Posts { get; set; } = new(); 
    }
}
