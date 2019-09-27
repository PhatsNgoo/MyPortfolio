using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class VisitorController:Controller
    {
        private readonly ILogger<VisitorController> _logger;
        public VisitorController(ILogger<VisitorController> logger)
        {
            _logger = logger;
        }
        static string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            return "Data Source=PHATSNGOO-PC;User ID=sa;Password=Uzur3u2w;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public void SaveVisitorEmail(string email)
        {
            _logger.LogError("function called");
            string connString = GetConnectionString();
            SqlConnection myConn = new SqlConnection(connString);
            try
            {
                _logger.LogError("dsql connecting");
                myConn.Open();
                string sqlCmd = @"use [Visitor] Insert into Visitors(VisitorEmail) values ('"+email+"')";
                SqlCommand execCmd = new SqlCommand(sqlCmd, myConn);

                //execCmd.ExecuteScalar();
                myConn.Close();
            }
            catch (Exception e)
            {
                _logger.LogError("db connected fail");
                _logger.LogError(e.ToString());
            }
        }
        [HttpPost]
        public IActionResult Index(string email)
        {
            _logger.LogError("function called");
            string connString = GetConnectionString();
            SqlConnection myConn = new SqlConnection(connString);
            try
            {
                _logger.LogError("dsql connecting");
                myConn.Open();
                string sqlCmd = @"use [Visitor] Insert into Visitors(VisitorEmail) values ('" + email + "')";
                SqlCommand execCmd = new SqlCommand(sqlCmd, myConn);

                //execCmd.ExecuteScalar();
                myConn.Close();
            }
            catch (Exception e)
            {
                _logger.LogError("db connected fail");
                _logger.LogError(e.ToString());
            }
            return Content($"Hello sadas");
        }
    }
}
