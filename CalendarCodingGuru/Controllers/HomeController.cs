using CalendarCodingGuru.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Application.Interfaces;

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

        public async Task<IActionResult> Index()
        {
            var blogs = await _calendarDayServices.GetAllAsync();
            return View(blogs);
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
