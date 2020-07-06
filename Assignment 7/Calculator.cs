using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Assignment_7
{
    public class Calculator : ICalculator
    {
        #region Parameters
        public double[] Operands { get; set; }
        #endregion

        #region Methods

        /// <summary>
        /// Takes an ICalculator object's operands that the user inputs, and then returns their sum.
        /// </summary>
        /// <param name="operands">An array of double type numeric values.</param>
        /// <returns>Returns the sum of all the numbers.</returns>
        public double Add(ICalculator calculator)
        {
            var result = calculator.Operands.Sum();

            return result;
        }

        /// <summary>
        /// Takes an ICalculator object's operands that the user inputs, and then returns the difference.
        /// </summary>
        /// <param name="operands">An array of double type numeric values.</param>
        /// <returns>Returns the difference of all the numbers.</returns>
        public double Subtract(ICalculator calculator)
        {
            double result = 0;

            int counter = 1;

            foreach (double operand in calculator.Operands)
            {
                if (counter == 1)
                {
                    result = operand;
                }
                else
                {
                    result -= operand;
                }
                counter++;
            }

            return result;
        }

        /// <summary>
        /// Takes an ICalculator object's operands that the user inputs, and then returns their product.
        /// </summary>
        /// <param name="operands">An array of double type numeric values.</param>
        /// <returns>Returns the product of all the numbers.</returns>
        public double Multiply(ICalculator calculator)
        {
            double result = 1;

            foreach (double operand in calculator.Operands)
            {
                result = result * operand;
            }

            return result;
        }

        /// <summary>
        /// Takes an ICalculator object's operands that the user inputs, and then returns thei quotient.
        /// </summary>
        /// <param name="operands">An array of double type numeric values.</param>
        /// <returns>Returns the quotient of all the numbers.</returns>
        public double Divide(ICalculator calculator)
        {
            double result = 0;

            for(var index = 0; index < calculator.Operands.Length; index++)
            
            {
                if(index == 0)
                {
                    result = calculator.Operands[index];
                }
                else
                {
                    result /= calculator.Operands[index];
                }                                                 
            }

            return result;
        }
        #endregion
    }
}
