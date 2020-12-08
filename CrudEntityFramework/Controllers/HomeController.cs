using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudEntityFramework.Models;
using CrudEntityFramework.Data;
using Microsoft.EntityFrameworkCore;

namespace CrudEntityFramework.Controllers
{
  public class HomeController : Controller
  {
    // Se crea esta variable
    private readonly ApplicationDbContext _context;

    // Constructor
    public HomeController(ApplicationDbContext context)
    {
      // Se tednra acceso a cualquiera de las tablas que esten mapeadas en "ApplicationDbContest.cs"
      _context = context;
    }

    // Se teclea esta palabra para indicar que tipo es "Get" porque va a retornar una tabla Regilla de tipo BootStrap.
    //se coloca "async Task" para optimizar el desempeño de la aplicacion.
    [HttpGet]

    public async Task<IActionResult>Index()
    {
      // Se agrega la libreria : Microsoft.EntityFrameworkCore;
      return View(await _context.Usuario.ToListAsync());
    }

    [HttpGet]
    public IActionResult Create()
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
