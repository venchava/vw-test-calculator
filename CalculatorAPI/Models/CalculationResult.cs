namespace CalculatorAPI.Models;

/// <summary>
/// Represents the result of a calculation operation
/// </summary>
public class CalculationResult
{
    /// <summary>
    /// The operation performed (add, subtract, multiply, divide)
    /// </summary>
    public string Operation { get; set; } = string.Empty;

    /// <summary>
    /// First operand
    /// </summary>
    public double A { get; set; }

    /// <summary>
    /// Second operand
    /// </summary>
    public double B { get; set; }

    /// <summary>
    /// Result of the operation
    /// </summary>
    public double Result { get; set; }

    /// <summary>
    /// Timestamp when the calculation was performed
    /// </summary>
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
