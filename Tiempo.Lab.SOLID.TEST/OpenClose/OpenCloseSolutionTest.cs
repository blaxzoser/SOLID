using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Tiempo.Lab.SOLID.OpenClosePrincipal.abstrac_sample.Tiempo.Lab.SOLID.OpenClosePrincipal;

namespace Tiempo.Lab.SOLID.TEST.OpenClose
{
    [TestFixture]
    public class OpenCloseSolutionTest
    {
        [Test]
        public void ShouldTakeAOrderAtUberEats()
        {
            var uberEatsService = new UberService(34.00);
            var orderFoodManagerService = new OrderFoodManagerService();

            var cost = orderFoodManagerService.GetCost(uberEatsService);
            Debug.WriteLine("UberEats Service: " + cost);
            Assert.That(cost > 34.00);
        }

        [Test]
        public void ShouldTakeAOrderAtRestaurant()
        {
            var restaurant = new RestaurantService();
            restaurant.FoodCost = 34.00;

            var orderFoodManagerService = new OrderFoodManagerService();

            var cost = orderFoodManagerService.GetCost(restaurant);
            Debug.WriteLine("Restaurant Service: " + cost);
            Assert.That(cost > 34.00);
        }


        [Test]
        public void ShouldTakeAOrderAtRappiService()
        {
            var desc = 10;
            var rappiService = new RappiService();
            rappiService.FoodCost = 34.00 - desc;

            var orderFoodService = new OrderFoodManagerService();

            var cost = orderFoodService.GetCost(rappiService);
            Debug.WriteLine("Rappi Service: " + cost);
            Assert.That(cost > 34.00);
        }

    }
}
