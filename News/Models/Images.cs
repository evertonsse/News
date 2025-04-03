using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace News.Models {
    public class Images {
        public int Id { get; set; }
        public string Path { get; set; } = string.Empty;
        public bool Thumbnail { get; set; }
        public int PostId { get; set; }
        public required Post Post { get; set; }

    }
}
