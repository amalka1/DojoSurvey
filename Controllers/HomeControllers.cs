using Microsoft.AspNetCore.Mvc;
namespace Dojo.Controllers ;
public class HomeController : Controller
{
    [HttpGet("Index")]
    public ViewResult Indexi()
    {
        return View("Index");
    }
    [HttpPost("first")]
    public IActionResult First (string Textfield, string Location, string Language, string Message )
    {
        ViewBag.Name = Textfield;
        ViewBag.locatioon = Location;
        ViewBag.Languagee = Language;
        ViewBag.Messagee = Message;
        return View("First");
    }
}