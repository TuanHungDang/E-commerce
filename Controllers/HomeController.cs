using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using E_commerce.Models;

namespace E_commerce.Controllers;

public class HomeController : BaseController
{
    public IActionResult Index(){
        ViewBag.Categories = Provider.Category.GetCategories();
        return View();
    }

}
