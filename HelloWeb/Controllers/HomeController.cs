using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWeb.Models;
using Microsoft.EntityFrameworkCore;

using HelloWeb.Data;


namespace HelloWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Basic()
        {
            ViewData["Message"] = "Your basic page.";
            return View();
        }

        public IActionResult Advanced()
        {
            string operatingSystem;
            var person = new Person();
            using (var context = new MachineContext())
            {
                
                var os = context.OperatingSys.Where(o => o.Name == "Windows 10").Select(o => o.Name);
                if (os.Count() > 0)
                {
                    operatingSystem = os.FirstOrDefault();
                    person.FirstName = "Lester";
                    person.LastName = "Serdenia";

                    person.OS = operatingSystem;
   
                }
            }





            return View(person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public static void AddOperatingSystem(string osName)
        {

            OperatingSys os = new OperatingSys();
            os.Name = osName;

            using (var context = new MachineContext())
            {
                context.OperatingSys.Add(os);
                int i = context.SaveChanges();
            }
        }
    }
}
