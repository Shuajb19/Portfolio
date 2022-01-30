using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact(Contact contact)
        {
            
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Portfolio;Integrated Security=True"))
            {
                
                string query = "INSERT into dbo.Contact (Emri, Mbiemri, Email, Subjekti, Mesazhi) Values('" + contact.Emri + "', '" + contact.Mbiemri + "', '" + contact.Email + "', '" + contact.Subjekti + "', '" + contact.Mesazhi + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    
                
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
