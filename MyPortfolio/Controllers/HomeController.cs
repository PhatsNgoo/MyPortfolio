using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging.Debug;
using Microsoft.Extensions.Logging;
using MyPortfolio.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
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
        static string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            return "Data Source=PHATSNGOO-PC;User ID=sa;Password=Uzur3u2w;";
        }
        [HttpPost]
        public ActionResult<Visitor> SaveVisitorEmail(string email)
        {
            Visitor visitor = new Visitor();
            visitor.email = email;
            _logger.LogError("function called");
            _logger.LogError(email);
            string connString = GetConnectionString();
            SqlConnection myConn = new SqlConnection(connString);
            try
            {
                _logger.LogError("dsql connecting");
                myConn.Open();
                string sqlCmd = @"use [Visitor] Insert into Visitors(VisitorEmail) values ('"+email+"')";
                SqlCommand execCmd = new SqlCommand(sqlCmd, myConn);

                execCmd.ExecuteScalar();
                myConn.Close();
            }
            catch (Exception e)
            {
                _logger.LogError("db connected fail");
                _logger.LogError(e.ToString());
            }
            return visitor;
        }
    }
}
