using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agrimada.Memberspace.Models;
using Agrimada.Memberspace.Data;
using Agrimada.Shared.Models;

namespace Agrimada.Memberspace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> SeedData()
        {
            if (!context.Categories.Any())
            {
                context.Categories.Add(new Category { Name = "Fruit" });
                context.Categories.Add(new Category { Name = "Legume" });
                await context.SaveChangesAsync();
            }

            if (!context.Products.Any())
            {
                var fruit = context.Categories.FirstOrDefault(x => x.Id == 1);
                if (fruit != null)
                {
                    context.Products.Add(new Product { Name = "Letchi", CategoryId = 1, Category = fruit });
                    context.Products.Add(new Product { Name = "Orange", CategoryId = 1, Category = fruit });
                    context.Products.Add(new Product { Name = "Pampelmouse", CategoryId = 1, Category = fruit });
                    context.Products.Add(new Product { Name = "Ananas", CategoryId = 1, Category = fruit });
                    await context.SaveChangesAsync();
                }
            }

            return Ok();
        }
    }
}
