﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Controllers
{
    public class ListManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
