using ContosoPizza.Models;
using ContosoPizza.Services;
using ContosoPizza.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
public class MathController : ControllerBase
{
    [HttpGet("/math/{num1}/{num2}/{amount}")] 
    public ActionResult<String> SimpleMath(int num1, int num2, int amount){
        return MathService.SimpleMath(num1, num2, amount);
    }

    [HttpGet("/factorial/{num}")]
    public ActionResult<String> Factorial(int num){
        return "Finished! Result: " + MathService.Factorial(num).ToString();
    }

    [HttpGet("/coordinates/{amount}")]
    public ActionResult<List<Coordinate>> Coordinates(int amount){
        return MathService.CreateCoordinates(amount);
    }

}