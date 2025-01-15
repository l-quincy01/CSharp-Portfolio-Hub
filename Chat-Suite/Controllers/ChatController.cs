using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chat_Suite.Models;



namespace Chat_Suite.Controllers;

public class ChatController : Controller
{


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }


}
