using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tiempo.Lab.SOLID.LisvokSubtitutionPrincipal.sample_calculator.violation
{
    public class SumCalculator
    {
        protected  readonly int[] _numbers;

        public SumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public int Calculate() => _numbers.Sum();
    }

    public class EvenNumbersSumCalculator : SumCalculator
    {
        public EvenNumbersSumCalculator(int[] numbers)
            : base(numbers)
        {
        }

        public new int Calculate() => this._numbers.Where(number => number % 2 == 0).Sum();
    }


}
