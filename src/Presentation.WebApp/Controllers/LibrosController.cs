using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Presentation.WebApp.Models;

using Domain;
using Infrastructure;

namespace Presentation.WebApp.Controllers
{
public class LibrosController : Controller
{
    private readonly LibrosDbContext _librosDbContext;

    public LibrosController(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection") 
            ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        
        _librosDbContext = new LibrosDbContext(connectionString);
    }

    public IActionResult Index()
    {
        var data = _librosDbContext.List();
        return View(data);
    }

        public IActionResult Details(Guid id)
        {
            var data = _librosDbContext.Details(id);
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IM253E06Libro data)
        {
            data.Id = Guid.NewGuid();
            _librosDbContext.Create(data);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id)
        {
            var data = _librosDbContext.Details(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(IM253E06Libro data)
        {
            _librosDbContext.Edit(data);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            _librosDbContext.Delete(id);
            return RedirectToAction("Index");
        }
    }
}