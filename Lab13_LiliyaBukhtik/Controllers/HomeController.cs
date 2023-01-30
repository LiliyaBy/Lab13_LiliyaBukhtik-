using Lab13_LiliyaBukhtik.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab13_LiliyaBukhtik.Controllers
{
    public class HomeController : Controller
    {
        
       
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }
       
        public IActionResult Exercise1()
        {
                       
            ViewData["Name"] = "Lilia Bukhtik";
            ViewData["Date"] = DateTime.Now;
            ViewData["Environment"] = _webHostEnvironment.EnvironmentName;
            ViewData["ApplicationName"] = _webHostEnvironment.ApplicationName;
            ViewData["Host"] = HttpContext.Request.Host;
            ViewData["Protocol"] = HttpContext.Request.Protocol;
            
            
            return View();
        }

        public IActionResult Exercise2()
        {
            HomeController homecontroller = new(_logger, _webHostEnvironment);
            return new JsonResult(homecontroller);
        }

        public IActionResult Exercise3()
        {
            return View();
        }

        [HttpPost]
        public string Result(string name, Gender gender, int age) 
        {
            if (ModelState.IsValid)
                return (string)(ViewData["Message"] = $"{name} - {gender} - {age}");
            return "Not all fields are filled";
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}