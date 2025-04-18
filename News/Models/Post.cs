﻿namespace News.Models {
    public class Post {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int Hits { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }
        public required Category Category { get; set; }

        public List<Images> Images { get; set; } = new(); // Relacionamento 1:N
    }

}
