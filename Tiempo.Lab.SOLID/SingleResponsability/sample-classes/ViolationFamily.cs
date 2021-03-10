using System;

namespace Tiempo.Lab.SOLID.SingleResponsability
{
    /// <summary>
    /// Violation Single responsibility  because we had more 1 things to do,
    /// in terms on  an actor mother multitasking 
    /// </summary>
    public class BadMother
    {
        public double Bills { get; set; }

        public void Cook()
        {
            System.Console.WriteLine("Prepare dinner");
        }

        public void Work()
        {
            System.Console.WriteLine("Working hard!....");
        }

        public void PlayWithChildren()
        {
            System.Console.WriteLine("Play With Children");
        }
        public void PayBills()
        {
            System.Console.WriteLine("Pay Bills");
        }

        public void WatchTv()
        {
            System.Console.WriteLine("Watch Tv");
        }

        public void CleanHouse()
        {
            System.Console.WriteLine("Clean House");
        }

    }
}
