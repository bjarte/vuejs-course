using Microsoft.AspNetCore.Mvc;

namespace TheStore.Controllers
{
  public class RootController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Error()
    {
      return View();
    }

    public IActionResult About()
    {
      return View();
    }

    public IActionResult Contact()
    {
      return View();
    }

    public IActionResult Checkout()
    {
      return View();
    }
  }
}
