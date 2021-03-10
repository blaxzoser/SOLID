using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Tiempo.Lab.SOLID.OpenClosePrincipal;

namespace Tiempo.Lab.SOLID.TEST.OpenClose
{
    [TestFixture]
    public class OpenCloseViolationTest
    {

        [Test]
        public void ShouldTakeAOrderAtUberEats() 
        {
            var uberEats = new Uber();
            var orderFoodService = new OrderFoodService();
            
            var cost = orderFoodService.GetCost(uberEats, 34.00);
            Debug.WriteLine("UberEats: " + cost);
            Assert.That(cost > 34.00);
        }

        [Test]
        public void ShouldTakeAOrderAtRestaurant()
        {
            var restaurant  = new SeftServices();
            var orderFoodService = new OrderFoodService();

            var cost = orderFoodService.GetCost(restaurant, 34.00);
            Debug.WriteLine("Restaurant: " + cost);
            Assert.That(cost > 34.00);
        }


        [Test]
        public void ShouldTakeAOrderAtRappi()
        {
            var uberEats = new Uber();
            var orderFoodService = new OrderFoodService();

            var cost = orderFoodService.GetCost(uberEats, 34.00);
            Debug.WriteLine("Rappi: "+ cost);
            Assert.That(cost > 34.00);
        }

    }
}
