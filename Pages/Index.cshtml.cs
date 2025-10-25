using GroceryStoreWebApp.Data;
using GroceryStoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GroceryStoreWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ApplicationDbContext _context;
        public IList<Product> Products { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // When a Get request is made to the page, this method is called.
        public async Task OnGetAsync()
        {
            Products = await _context.Product.ToListAsync<Product>();

           
        }
    }
}
