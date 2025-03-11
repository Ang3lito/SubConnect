using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SubConnect.Models; // Add this

namespace SubConnect.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Email()
        {
            return View();
        }

        public IActionResult Code()
        {
            return View();
        }

        public IActionResult NewPassword()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult AdminPost()
        {
            return View();
        }

        public IActionResult AdminProfile()
        {
            return View();
        }

        public IActionResult AdminNotification()
        {
            return View();
        }

        public IActionResult AdminUserManagement()
        {
            ViewBag.ActiveTab = "AdminUserManagement";
            return View();
        }

        public IActionResult Staff()
        {
            return View();
        }


        public IActionResult AdminFacilityManagement()
        {
            return View();
        }

        public IActionResult FacilityRequest()
        {
            return View();
        }
    }
}

