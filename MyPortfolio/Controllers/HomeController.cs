using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        [Route("/index")]
        [Route("home/index")]
        public ViewResult Index()
        {
            return View();
        }
        [Route("/contact")]
        [Route("home/contact")]
        public ViewResult Contact()
        {
            return View(); 
        }
        
        [Route("/about")]
        [Route("home/about")]
        public ViewResult About()
        {
            return View();
        }
        [Route("/services")]
        [Route("home/services")]
        public ViewResult Services()
        {
            return View();
        }
    }
}
