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
    public class DetailsModel : PageModel
    {
        private readonly GroceryStoreWebApp.Data.ApplicationDbContext _context;

        public DetailsModel(GroceryStoreWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);

            if (product is not null)
            {
                Product = product;

                return Page();
            }

            return NotFound();
        }
    }
}
