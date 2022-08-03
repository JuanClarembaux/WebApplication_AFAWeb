using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class VehicleController : Controller
    {

        private DbContext db = new DbContext();

        public IActionResult Index()
        {
            return View();
        }
    }
}
