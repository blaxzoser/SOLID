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
            Console.WriteLine("Play With Children");
        }

        public void WatchTv()
        {
            Console.WriteLine("Watch Tv");
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
            Console.WriteLine("Working hard!....");
        }

        public void PayBills()
        {
            Console.WriteLine("Pay Bills");
        }
    }

    /// <summary>
    /// Clean house and help other stuff at house
    /// </summary>
    public class Cleaner
    {
        public void CleanHouse()
        {
            Console.WriteLine("Clean House");
        }

        public void Cook()
        {
            Console.WriteLine("Prepare dinner");
        }
    }

}
