using basics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace basics.Controllers;

public class BootcampController : Controller
{
    public IActionResult Index()
    {

        var bootcamp = new Bootcamp();

        bootcamp.Id = 1;
        bootcamp.Title = ".NET Core Bootcamp";
        bootcamp.Description = ":NET Core Bootcampi bugün başladı";
        bootcamp.Image = "1.png";

        return View(bootcamp);
    }
    public IActionResult List()
    {
        return View(Repository.Bootcamps);
    }

    public IActionResult Details(int? id){

        if(id==null){
            return RedirectToAction("List");
        }
        var bootcamp = Repository.GetById(id);
        return View(bootcamp);
    }
}