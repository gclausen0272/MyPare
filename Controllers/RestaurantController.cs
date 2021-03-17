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
    readonly EFCoreWebDemoContext _libraryContext;  
  
    public RestaurantController(EFCoreWebDemoContext context)  
    {  
        _libraryContext = context;  
    } 

        //The code in the Index method retrieves all authors from the database and passes them to the View. 
        //The AsNoTracking method is used to prevent the context from unnecessarily tracking the data because
        // it is intended for read-only use. The DbContext is instantiated in a using block to ensure that it is disposed properly.
        public async Task<IActionResult> Index()
        {
            using (var context = _libraryContext)
            {
                var model = context.Restaurants;
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
           ICollection<Restaurant> db =await _libraryContext.Restaurants.ToArrayAsync();

              foreach (Restaurant a in db ){
                  if(a.RestaurantID == author.RestaurantID){
                      author.RestaurantID = author.RestaurantID*10+1;
                  }
                }           
                 _libraryContext.Add(author);
                 await _libraryContext.SaveChangesAsync();
                return RedirectToAction("Index");
        }
    }
}