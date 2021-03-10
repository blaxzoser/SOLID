using System;

namespace Tiempo.Lab.SOLID.SingleResponsability
{

    /// <summary>
    /// responsibility  to handle children 
    /// </summary>
    public class Mother
    {
        public void PlayWithChildren()
        {
            System.Console.WriteLine("Play With Children");
        }

        public void WatchTv()
        {
            System.Console.WriteLine("Watch Tv");
        }

    }

    /// <summary>
    /// responsibility  make money to get at home
    /// </summary>
    public class Dad 
    {

        public double Bills { get; set; }
        public void Work()
        {
            System.Console.WriteLine("Working hard!....");
        }

        public void PayBills()
        {
            System.Console.WriteLine("Pay Bills");
        }
    }

    /// <summary>
    /// Clean house and help other stuff at house
    /// </summary>
    public class Cleaner
    {
        public void CleanHouse()
        {
            System.Console.WriteLine("Clean House");
        }

        public void Cook()
        {
            System.Console.WriteLine("Prepare dinner");
        }
    }

}
