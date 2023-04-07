using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Data.EntityFramework;
using TraversalCoreProje.Service.Concrete;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();

            return View(values);  
        }
    }
}
