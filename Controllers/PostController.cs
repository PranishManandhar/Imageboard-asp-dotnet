using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ImageBoard.Models;

namespace ImageBoard.Controllers;

public class PostController : Controller
{
    private readonly ILogger<PostController> _logger;

    public PostController(ILogger<PostController> logger)
    {
        _logger = logger;
    }

    public IActionResult Post()
    {
        return View();
    }
}