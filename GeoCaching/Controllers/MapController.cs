﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeoCaching.Models;

namespace GeoCaching.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Map()
        {
            return View();
        }
    }
}
