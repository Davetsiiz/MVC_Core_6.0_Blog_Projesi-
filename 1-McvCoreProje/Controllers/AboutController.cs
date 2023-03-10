using BusinessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.Controllers
{
    public class AboutController : Controller
    {
        
        AboutManager abm = new AboutManager(new EfAboutDal());
        [AllowAnonymous]
        public IActionResult Index()
        {
			var values = abm.GetList();
			return View(values);
        }
        public PartialViewResult SocialMediaAbout()
        {
            
            return PartialView();
        }
    }
}
