﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudEntityFramework.Models;
using CrudEntityFramework.Data;

namespace CrudEntityFramework.Controllers
{
  public class HomeController : Controller
  {
    private readonly ApplicationDbContext _context;

    // Constructor
    public HomeController(ApplicationDbContext context)
    {
      // Se tednra acceso a cualquiera de las tablas que esten mapeadas en "ApplicationDbContest.cs"
      _context = context;
    }

    public IActionResult Index()
    {
      return View();
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
