using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.Lab.SOLID.SingleResponsability.sample_method
{
    public class SolutionCalculator
    {
        public int OperatorSum(int numberOne, int numberTwo)
        {
            return  numberOne + numberTwo;
        }

        public int OperatorDifference(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        public int OperatorMultiplication(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

    }
}
