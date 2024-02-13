using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace RaftEscalator.Controllers;

public class UserController : Controller
{
    public IActionResult Create()
    {
        ViewData["Message"] = "Your Create user Page";

        return View();
    }
}
