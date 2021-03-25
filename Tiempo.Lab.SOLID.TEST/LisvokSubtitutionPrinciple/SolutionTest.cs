
using NUnit.Framework;
using Tiempo.Lisvok.Solutions;

namespace Tiempo.Lab.SOLID.TEST.LisvokSubtitutionPrincipal
{
    [TestFixture]
    class SolutionTest
    {
        [Test]
        public void ShouldPassChildrenLikeFather()
        {
            IVeganBurger burger = new VeganBurger();

            burger.PutPan();
            burger.PutVegetables();
        }

        [Test]
        public void ShouldPassChildrenLikeFatherWithAbstracClass()
        {
            Hamburger burger = new Vegin();

            burger.PutPan();
            burger.PutVegetables();
        }

        [Test]
        public void ShouldGeNotAIssueWithParent()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Calculator sum = new SumCalculator(numbers);
            Assert.AreEqual(45, sum.Calculate());

            Calculator evenSum = new EvenNumbersSumCalculator(numbers);
            Assert.AreEqual(20, evenSum.Calculate());
        }

    }
}
