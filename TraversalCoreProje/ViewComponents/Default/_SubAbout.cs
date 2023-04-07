using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Data.EntityFramework;
using TraversalCoreProje.Service.Concrete;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());    
        public IViewComponentResult Invoke()
        {
            var values = subAboutManager.TGetList();
            
            return View(values); 
        
        
        }  
    }
}
