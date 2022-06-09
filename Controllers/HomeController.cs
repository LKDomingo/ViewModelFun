using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string str = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Animi veniam assumenda possimus iusto labore, mollitia reprehenderit minus in voluptate nulla dicta laborum dolor consequatur velit, doloribus ratione vitae temporibus iste.";
        return View("Index",str);
    }

    [HttpGet("numbers")]
    public IActionResult Numbers()
    {
        int[] numbers = new int[] {1,2,3,4,5,6,7};
        return View(numbers);
    }

    [HttpGet("users")]
    public IActionResult Users()
    {
        List<User> UserList = new List<User>();
        UserList.Add(new User("Moose", "Phillips"));
        UserList.Add(new User("Sarah", "Phillips"));
        UserList.Add(new User("Jerry"));
        UserList.Add(new User("Rene", "Ricky"));
        return View(UserList);
    }

    [HttpGet("user")]
    public IActionResult User()
    {
        User user = new User("Logan", "Domingo");
        return View(user);
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
