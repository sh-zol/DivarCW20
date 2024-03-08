using App.Domain.Core.Advertise.Contracts.Services;
using App.Domain.Services.Advertise;
using Microsoft.AspNetCore.Mvc;

namespace Divar.Controllers
{
    public class AdvertiseController : Controller
    {
       IAdvertiseService advertiseService = new AdvertiseService();
        
        
        public IActionResult Index()
        {
            //call methods
            return View();
        }
    }
}
