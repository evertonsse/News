namespace News.Models
{
    public class Post
    {
        public int Id { get; set; } 
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int hits { get; set; } 
        public int CategoryId { get; set; }



    }
}
