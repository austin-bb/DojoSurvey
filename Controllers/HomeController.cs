using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;

  public class HomeController : Controller
  {
    [HttpGet("")]
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost("result")]
    public IActionResult Result(string name, string location, string language, string comment)
    {
      ViewBag.name = name;
      ViewBag.location = location;
      ViewBag.language = language;
      ViewBag.comment = comment;

      return View("Result");
    }
  }