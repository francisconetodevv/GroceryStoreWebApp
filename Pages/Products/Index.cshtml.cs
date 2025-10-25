using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GroceryStoreWebApp.Data;
using GroceryStoreWebApp.Models;

namespace GroceryStoreWebApp.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly GroceryStoreWebApp.Data.ApplicationDbContext _context;

        public IndexModel(GroceryStoreWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
