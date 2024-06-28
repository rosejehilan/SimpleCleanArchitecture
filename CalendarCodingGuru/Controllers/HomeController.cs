using CalendarCodingGuru.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Application.Interfaces;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace CalendarCodingGuru.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalendarDayServices _calendarDayServices;

        public HomeController(ILogger<HomeController> logger, ICalendarDayServices calendarDayServices)
        {
            _logger = logger;
            _calendarDayServices = calendarDayServices;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> GetEvents()
        {
            
            var calendarDays = await _calendarDayServices.GetAllAsync();
            
            var result = Json(calendarDays);
            return result;
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
