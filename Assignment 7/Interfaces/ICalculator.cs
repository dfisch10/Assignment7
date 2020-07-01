namespace Assignment_7
{
    public interface ICalculator
    {
        double[] Operands { get; set; }

        double Add(ICalculator calculator);
        double Subtract(ICalculator calculator);
        double Multiply(ICalculator calculator);
        double Divide(ICalculator calculator);
    }
}