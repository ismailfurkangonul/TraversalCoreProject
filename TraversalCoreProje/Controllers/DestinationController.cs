using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Data.EntityFramework;
using TraversalCoreProje.Service.Concrete;

namespace TraversalCoreProje.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = destinationManager.TGetList();

            return View(values);
        }
        [HttpGet]
        public IActionResult DestinationDetails(int id) 
        
        { 
            var values=destinationManager.TGetByID(id); 
            
           return View(values);   
        
        
        
        }
        [HttpPost]
        public IActionResult DestinationDetails(DestinationController p)
        {



            return View();  
        }
    }
}
