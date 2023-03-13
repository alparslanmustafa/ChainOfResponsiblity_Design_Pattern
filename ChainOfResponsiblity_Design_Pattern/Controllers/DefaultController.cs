using ChainOfResponsiblity_Design_Pattern.ChainOfResponsiblityDesignPattern;
using ChainOfResponsiblity_Design_Pattern.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResponsiblity_Design_Pattern.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] 
        public IActionResult Index(WithDraw p)
        {
            Employee treasurer = new Treasurer();
            Employee manager = new Manager();
            Employee director = new Director();
            Employee areadirector = new AreaDirector();

            treasurer.SetNextApprover(manager);
            manager.SetNextApprover(director);
            director.SetNextApprover(areadirector);

            treasurer.ProcessRequest(p);
            return View();
        }
    }
}
