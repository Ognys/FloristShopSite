using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FloristShop.Models;

namespace FloristShop.Controllers;

public class HomeController : Controller
{

    private readonly FlowerRopsitory _repo;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, FlowerRopsitory repo)
    {
        _logger = logger;
        _repo = repo;
    }
    

    public async Task<IActionResult> Index()
    {

        await _repo.CreateFlowerData();

        var flowers = await _repo.GetAll();
        return View(flowers);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
