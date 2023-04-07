using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using TraversalCoreProje.Data.Concrete;
using TraversalCoreProje.Data.EntityFramework;
using TraversalCoreProje.Service.Concrete;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
           // var values = featureManager.TGetList();
           //ViewBag.image1 = featureManager.Get
            return View();
        }
    }
}
