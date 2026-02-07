using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers;

/// <summary>
/// Calculator API Controller
/// Provides basic arithmetic operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    /// <summary>
    /// Adds two numbers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Sum of a and b</returns>
    [HttpGet("add")]
    public ActionResult<double> Add(double a, double b)
    {
        return Ok(new { operation = "add", a, b, result = a + b });
    }

    /// <summary>
    /// Subtracts two numbers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Difference of a and b</returns>
    [HttpGet("subtract")]
    public ActionResult<double> Subtract(double a, double b)
    {
        return Ok(new { operation = "subtract", a, b, result = a - b });
    }

    /// <summary>
    /// Multiplies two numbers
    /// </summary>
    /// <param name="a">First number</param>
    /// <param name="b">Second number</param>
    /// <returns>Product of a and b</returns>
    [HttpGet("multiply")]
    public ActionResult<double> Multiply(double a, double b)
    {
        return Ok(new { operation = "multiply", a, b, result = a * b });
    }

    /// <summary>
    /// Divides two numbers
    /// </summary>
    /// <param name="a">Dividend</param>
    /// <param name="b">Divisor</param>
    /// <returns>Quotient of a and b</returns>
    [HttpGet("divide")]
    public ActionResult<double> Divide(double a, double b)
    {
        if (b == 0)
        {
            return BadRequest(new { error = "Division by zero is not allowed" });
        }
        return Ok(new { operation = "divide", a, b, result = a / b });
    }
}
