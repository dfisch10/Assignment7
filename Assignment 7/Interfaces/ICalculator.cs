namespace Assignment_7
{
    public interface ICalculator
    {
        #region Parameters
        /// <summary>
        /// This parameter is an array of type double which the user inputs and is used for various calculator functions.
        /// </summary>
        double[] Operands { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Takes an ICalculator object's operands that the user inputs, and then returns their sum.
        /// </summary>
        /// <param name="operands">An array of double type numeric values.</param>
        /// <returns>Returns the sum of all the numbers.</returns>
        double Add(ICalculator calculator);

        /// <summary>
        /// Takes an ICalculator object's operands that the user inputs, and then returns the difference.
        /// </summary>
        /// <param name="operands">An array of double type numeric values.</param>
        /// <returns>Returns the difference of all the numbers.</returns>
        double Subtract(ICalculator calculator);

        /// <summary>
        /// Takes an ICalculator object's operands that the user inputs, and then returns their product.
        /// </summary>
        /// <param name="operands">An array of double type numeric values.</param>
        /// <returns>Returns the product of all the numbers.</returns>
        double Multiply(ICalculator calculator);

        /// <summary>
        /// Takes an ICalculator object's operands that the user inputs, and then returns thei quotient.
        /// </summary>
        /// <param name="operands">An array of double type numeric values.</param>
        /// <returns>Returns the quotient of all the numbers.</returns>
        double Divide(ICalculator calculator);
        #endregion
    }
}