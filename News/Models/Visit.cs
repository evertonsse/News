namespace News.Models
{
    public class Visit
    {

        public int Id { get; set; }
        public DateTime date { get; set; } 

        public int PostId { get; set; }


        public required Post Post { get; set; }

    }
}
