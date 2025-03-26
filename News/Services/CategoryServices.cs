using Microsoft.EntityFrameworkCore;
using News.Models;

namespace News.Services
{
    public class CategoryServices
    {
        private readonly AppDbContext _context;

       
        public CategoryServices(AppDbContext context)
        {
            _context = context;
        }

        
        public List<Category> GetCategories()
        {
            return _context.Category.ToList();
        }


    }
}
