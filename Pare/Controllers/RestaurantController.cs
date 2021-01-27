using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Pare;   
using System.Collections.Generic;
namespace Pare.Controllers
{
    public class RestaurantController : Controller
    {

        //The code in the Index method retrieves all authors from the database and passes them to the View. 
        //The AsNoTracking method is used to prevent the context from unnecessarily tracking the data because
        // it is intended for read-only use. The DbContext is instantiated in a using block to ensure that it is disposed properly.
        public async Task<IActionResult> Index()
        {
            using (var context = new EFCoreWebDemoContext())
            {
                var model = await context.Restaurants.AsNoTracking().ToListAsync();
                return View(model);
            }
            
        }  
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FirstName, LastName")] Restaurant author)
        {
           ICollection<Restaurant> db =await new EFCoreWebDemoContext().Restaurants.ToArrayAsync();
            using (var context = new EFCoreWebDemoContext())
            {
              foreach (Restaurant a in db ){
                  if(a.RestaurantID == author.RestaurantID){
                      author.RestaurantID = author.RestaurantID*10+1;
                  }
                }           
                 context.Add(author);
                 await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}