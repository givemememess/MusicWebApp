﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MusicWebApplication.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}