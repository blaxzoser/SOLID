using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.Lab.SOLID.OpenClosePrincipal.abstrac_sample
{

    namespace Tiempo.Lab.SOLID.OpenClosePrincipal
    {
        public interface IProvider
        {
            int GetDeliveryMan();
        }

        public abstract class ServiceBase : IProvider
        {
            public double FoodCost { get; set; }
            public abstract double Cost();            
            public virtual int GetDeliveryMan() { return 0; }
        }
      
        public  class UberService : ServiceBase
        {

            public UberService(double foodCost)
            {
                FoodCost = foodCost;
            }

            public double UberCar => 30;
            public override int GetDeliveryMan ()  { return 2; }
            public double Taxes => UberCar * .01;

            public override double Cost()
            {
                return (FoodCost * GetDeliveryMan()) + UberCar  + Taxes; 
            }

        }

        public class RestaurantService : ServiceBase
        {
            public override int GetDeliveryMan() { return 10; }
            public override double Cost()
            {
                return (FoodCost * GetDeliveryMan());
            }
        }

        public class RappiService : ServiceBase
        {
            public double RappiMotherCicle => 10;
            public override int GetDeliveryMan() { return 2; }

            public override double Cost()
            {
                return (FoodCost + GetDeliveryMan()) * RappiMotherCicle;
            }
        }


        public class OrderFoodManagerService
        {
            public double GetCost(ServiceBase orderFood)
            {             
                return orderFood.Cost();
            }
        }
    }

}
