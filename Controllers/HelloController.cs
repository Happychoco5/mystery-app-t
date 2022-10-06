using ContosoPizza.Models;
using ContosoPizza.Services;
using ContosoPizza.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("/")]
public class HelloController : ControllerBase
{
    String hello = "Hello";
    //Hi there ;)
    [HttpGet]
    public ActionResult<string> Get(){
        return hello;
    }
}