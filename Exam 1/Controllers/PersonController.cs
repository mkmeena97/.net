using Mahendra_054.DAL;
using Mahendra_054.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mahendra_054.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetPersonDetails(int pid)
        {
            List<PersonCradit> pc = PersonCraditDAL.GetPerson(2); 
            return View(pc);
        }
    }
}
