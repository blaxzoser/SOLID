using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.Lab.SOLID.OpenClosePrincipal.abstrac_sample
{

    namespace Tiempo.Lab.SOLID.OpenClosePrincipal
    {

        public abstract class Service
        {
            public double FoodCost { get; set; }
            public abstract double Cost();
        }

        class Uber : Service
        {
            public double UberCar => 30;
            public int DeliveryMan => 1;
            public double Taxes => UberCar * .01;

            public override double Cost()
            {
                return (FoodCost * DeliveryMan) + UberCar  + Taxes; 
            }

        }

        class SeftServices : Service
        {
            public int DeliveryMan => 10;
            public override double Cost()
            {
                return (FoodCost * DeliveryMan);
            }
        }

        class Rappi : Service
        {
            public double RappiMotherCicle => 10;
            public int DeliveryMan => 1;

            public override double Cost()
            {
                return (FoodCost + DeliveryMan) * RappiMotherCicle;
            }
        }


        public class OrderFoodService
        {
            public double GetCostAllTypeServices(Service[] orderFood)
            {
                double cost = 0;
                foreach (var order in orderFood)
                {
                    cost += order.Cost();
                }
                return cost;
            }
        }
    }

}
