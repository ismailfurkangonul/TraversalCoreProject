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
    }
}
