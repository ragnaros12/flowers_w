using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Asd.Models;

namespace Asd.Controllers;

public class HomeController : Controller
{
    private Database _database;

    public HomeController(Database database)
    {
        _database = database;
    }

    public IActionResult Index()
    {
        return View(_database.Flowers.ToList());
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Flower flower)
    {
        if (ModelState.IsValid)
        {
            _database.Flowers.Add(flower);
            _database.SaveChanges();
			return Redirect(nameof(Index));
		}
        return Content(string.Join("\n", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)));
    }
}