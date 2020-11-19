using System;
namespace Tiempo.Lab.SOLID.OpenClosePrincipal
{
 

    class Uber
    {
        public double UberCar => 30;
        public int DeliveryMan => 1;
        public double Sat => UberCar * .1;
        public double Taxes => UberCar * .01;

    }

    class SeftServices
    {
        public int DeliveryMan => 10;
    }

    class Rappi
    {
        public double RappiMotherCicle => 10;
        public int DeliveryMan => 1;
    }


    public class OrderFoodService
    {
        public double GetCostAllTypeServices(Object[] orderFood,double priceFood)
        {
            double cost = 0;
            foreach (var order in orderFood)
            {
                switch (order)
                {
                    case Uber uber:
                        cost = (priceFood * uber.DeliveryMan) + uber.UberCar + uber.Sat + uber.Taxes;
                        break;
                    case SeftServices seftServices:
                        cost = (priceFood * seftServices.DeliveryMan);
                        break;
                    case Rappi rappi:
                        cost = (priceFood + rappi.DeliveryMan) * rappi.RappiMotherCicle;
                        break;
                }
            }

            return cost;
        }
    }
}
