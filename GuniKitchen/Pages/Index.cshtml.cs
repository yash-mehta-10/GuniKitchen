using GuniKitchen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuniKitchen.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;
        private readonly GuniKitchen.Data.ApplicationDbContext _context;

        public IndexModel(GuniKitchen.Data.ApplicationDbContext context)
        {
            //_logger = logger;
            _context = context;
        }

        public IList<Product> Product { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products
                .Include(p => p.ProductType).ToListAsync();
        }
        /*public void OnGet()
        {

        }*/
    }

}
