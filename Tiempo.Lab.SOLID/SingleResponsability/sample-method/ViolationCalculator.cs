using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.Lab.SOLID.SingleResponsability.sample_method
{
    public class ViolationCalculator
    {
        public int Operator(int numberOne,int numberTwo,string math)
        {
            return math switch
            {
                "+" => numberOne + numberTwo,
                "-" => numberOne - numberTwo,
                "*" => numberOne * numberTwo,
                _ => 0
            };
        }
    }
}
