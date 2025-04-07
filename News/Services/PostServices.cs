
using Microsoft.EntityFrameworkCore;
using News.Models;

namespace News.Services {
    public class PostServices {

         private readonly IDbContextFactory<AppDbContext> _contextFactory;

        public PostServices(IDbContextFactory<AppDbContext> contextFactory) {
            _contextFactory = contextFactory;
        }

        public async Task<List<Post>> GetPosts() {

            try {
                using var context = _contextFactory.CreateDbContext();
                return await context.Post.ToListAsync();
            } catch (Exception ex) {
                Console.WriteLine("Erro ao buscar os posts do banco de dados: " + ex);
                throw;
            }

        }




    }
}
