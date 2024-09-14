using Microsoft.AspNetCore.Mvc;

namespace TestApiDocker.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    

    [HttpGet(Name = "GetHomeData")]
    public string Get()
    {
        return "This is a response";
    }
}

