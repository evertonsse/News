using Microsoft.EntityFrameworkCore;
using News.Models;

namespace News.Services {
    public class CategoryServices {
        private readonly AppDbContext _context;


        public CategoryServices(AppDbContext context) {
            _context = context;
        }


        public async Task<List<Category>> GetCategories() {
            return await _context.Category.ToListAsync();
        }


        public async Task<List<Category>> MostAccessedCategories() {
            var categories = await (from c in _context.Category
                                    join posts in _context.Post on c.Id equals posts.CategoryId
                                    group posts by new { c.Id, c.Name, c.Description } into grouped
                                    select new Category {
                                        Id = grouped.Key.Id,
                                        Name = grouped.Key.Name,
                                        Description = grouped.Key.Description,
                                        Hits = grouped.Sum(post => post.Hits)
                                    })
                       .OrderByDescending(category => category.Hits) // Ordena pela soma dos Hits
                       .Take(5) // Limita aos 5 mais acessados
                       .ToListAsync();

            return categories;

        }
    }

}
