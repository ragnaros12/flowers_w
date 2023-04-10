using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Asd.Models;

namespace Asd.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        List<Flower> flowers = new List<Flower> {
            new()
            {
                Description = "Цветок Цветок Цветок Цветок Цветок Цветок Цветок Цветок Цветок",
                Height = 100,
                Id = 1,
                Image = "images/pions.jpeg",
                Name = "Пионы",
                Price = 100
            },
            new()
            {
                Description = "Цветок Цветок Цветок Цветок Цветок Цветок Цветок Цветок Цветок",
                Height = 100,
                Id = 1,
                Image = "images/pions.jpeg",
                Name = "Пионы",
                Price = 100
            },
            new()
            {
                Description = "Цветок Цветок Цветок Цветок Цветок Цветок Цветок Цветок Цветок",
                Height = 100,
                Id = 1,
                Image = "images/pions.jpeg",
                Name = "Пионы",
                Price = 100
            },
            new()
            {
                Description = "Цветок Цветок Цветок Цветок Цветок Цветок Цветок Цветок Цветок",
                Height = 100,
                Id = 1,
                Image = "images/pions.jpeg",
                Name = "Пионы",
                Price = 100
            },
            new()
            {
                Description = "Цветок Цветок Цветок Цветок Цветок Цветок Цветок Цветок Цветок",
                Height = 100,
                Id = 1,
                Image = "images/pions.jpeg",
                Name = "Пионы",
                Price = 100
            }
        };
        return View(flowers);
    }
}