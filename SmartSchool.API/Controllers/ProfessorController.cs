using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.API.Controllers
{
    public class ProfessorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
