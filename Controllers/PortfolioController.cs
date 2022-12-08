using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace RichPortfolio.Controllers;
public class HelloController : Controller   // Remember inheritance?    
{
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public string Index()
    {
        return "This is my index!";
    }

    [HttpGet] // We will go over this in more detail on the next page    
    [Route("projects")] // We will go over this in more detail on the next page
    public string Projects()
    {
        return "This is my Projects!";
    }

    [HttpGet] // We will go over this in more detail on the next page    
    [Route("contact")] // We will go over this in more detail on the next page
    public string Contact()
    {
        return "This is my Contact!";
    }
}