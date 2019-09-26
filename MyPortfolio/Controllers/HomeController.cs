using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging.Debug;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        static string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            return "Data Source=PHATSNGOO-PC;Initial Catalog=AdventureWorks;"
                + "Integrated Security=true;";
        }
        // GET: /<controller>/
        [Route("")]
        [Route("/index")]
        [Route("home/index")]
        public ViewResult Index()
        {
            Console.WriteLine("web is starting");
            string connString = GetConnectionString();
            SqlConnection myConn = new SqlConnection(connString);
            try
            {
                myConn.Open();
                Console.WriteLine("db has connected");
                //string testCmd = @"use [Visitor] Insert into Visitors(VisitorEmail) values ('phatsngoo2702@gmail.com')";
                //SqlCommand execCmd = new SqlCommand(testCmd, myConn);

                //execCmd.ExecuteScalar();
                myConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("db connected fail");
                Console.WriteLine(e.ToString());
            }
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
