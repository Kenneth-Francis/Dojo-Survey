using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;

public class DojoSurveyController : Controller
{
    [HttpGet("")]
    public ViewResult Survey()
    {
        return View();
    }

    [HttpPost("process")]
    public IActionResult Process
    (
        string Name,
        string Location,
        string Language,
        string Comment
    )
    {
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        ViewBag.Comment = Comment != null ? Comment : "No comment";

        return View("Result");
    }
}
