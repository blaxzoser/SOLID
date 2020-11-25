
using System;
using NUnit.Framework;
using Tiempo.Lab.SOLID.LisvokSubtitutionPrincipal;
using Tiempo.Lab.SOLID.LisvokSubtitutionPrincipal.sample_calculator.violation;

namespace Tiempo.Lab.SOLID.TEST.LisvokSubtitutionPrincipal
{
    [TestFixture]
    public class ViolationTest
    {
        [Test]
        public void ShouldThrowException()
        {
            Burger burger = new VegiBurger();

            burger.PutPan();
            burger.PutVegetables();
            Assert.Throws(typeof(NotImplementedException), () => burger.MakeMeat());
        }

        [Test]
        public void ShouldNotThrowException()
        {
            Burger burger = new ChikenBurger();

            burger.PutPan();
            burger.PutVegetables();
            burger.MakeMeat();
        }


        [Test]
        public void ShouldCalculateWithDifferentsClass()
        {
            var numbers = new[] { 1,2,3,4,5,6,7,8,9 };
            
            SumCalculator sum = new SumCalculator(numbers);
            Assert.AreEqual(45, sum.Calculate());

            EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            Assert.AreEqual(20, evenSum.Calculate());
        }


        [Test]
        public void ShouldGetAnIssueWithParent()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            SumCalculator sum = new SumCalculator(numbers);
            Assert.AreEqual(45, sum.Calculate());

            SumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            Assert.AreNotEqual(20, evenSum.Calculate());
        }
    }
}
