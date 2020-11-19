using System;

namespace Tiempo.Lab.SOLID.SingleResponsability
{
    /// <summary>
    /// Violation Single responsibility  because we had more 1 things to do,
    /// in terms on patricardo domain
    /// </summary>
    public class BadMother
    {
        public double Bills { get; set; }

        public void Cook()
        {
            Console.WriteLine("Prepare dinner");
        }

        public void Work()
        {
            Console.WriteLine("Working hard!....");
        }

        public void PlayWithChildren()
        {
            Console.WriteLine("Play With Children");
        }
        public void PayBills()
        {
            Console.WriteLine("Pay Bills");
        }

        public void WatchTv()
        {
            Console.WriteLine("Watch Tv");
        }

        public void CleanHouse()
        {
            Console.WriteLine("Clean House");
        }

    }
}
