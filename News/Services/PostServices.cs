
using Microsoft.EntityFrameworkCore;
using News.Models;

namespace News.Services {
    public class PostServices {

        private readonly AppDbContext _context;


        public PostServices(AppDbContext context) {
            _context = context;
        }


        public async Task<List<Post>> GetPosts() {
            return await _context.Post.ToListAsync();
        }


        public async Task<List<Post>> MostAccessedPosts() {
            var posts = await _context.Post.OrderByDescending(post => post.Hits)
                .Take(5)
                .OrderBy(post => post.Hits)
                .Where(post => post.CreatedAt <= DateTime.Now.AddDays(-7))
                .ToListAsync();

            return posts;

        }

    }
}
