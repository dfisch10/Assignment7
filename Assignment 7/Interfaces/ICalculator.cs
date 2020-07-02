namespace Assignment_7
{
    public interface ICalculator
    {
        #region Parameters
        double[] Operands { get; set; }
        #endregion

        #region Methods
        double Add(ICalculator calculator);
        double Subtract(ICalculator calculator);
        double Multiply(ICalculator calculator);
        double Divide(ICalculator calculator);
        #endregion
    }
}