using BoysNGirls.Models.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BoysNGirls.Areas.Teachers.Controllers
{
    [Area("Teachers")]
    public class HomeController : Controller
    {

        private ITaskService _taskService;

        // Inject task service through constructor
        public HomeController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public IActionResult Index()
        {
            ViewBag.Message = "There is one teacher in the class";
            ViewBag.Tasks = string.Equals(_taskService.GetType(), "teacher", StringComparison.OrdinalIgnoreCase) ? _taskService.GetTasks() : new List<Task>();
            return View();
        }
    }
}
