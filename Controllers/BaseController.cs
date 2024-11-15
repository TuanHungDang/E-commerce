using Microsoft.AspNetCore.Mvc;
using E_commerce.Models;

namespace E_commerce.Controllers;

public class BaseController : Controller
{
    SiteProvider? provider;
    protected SiteProvider Provider =>
            provider ??= new(HttpContext.RequestServices.GetRequiredService<IConfiguration>());

}