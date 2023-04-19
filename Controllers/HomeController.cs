using DependecyInjection.Models;
using DependecyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependecyInjection.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var userService = new UserService();
            var questionService = new QuestionService();
            return View();
        }

        public IActionResult Privacy()
        {
            var userService = new UserService();
            return View();
        }      
    }
}