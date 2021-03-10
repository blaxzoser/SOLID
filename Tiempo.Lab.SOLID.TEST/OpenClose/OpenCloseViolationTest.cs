using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Tiempo.OpenClose.Violations;

namespace Tiempo.Lab.SOLID.TEST.OpenClose
{
    [TestFixture]
    public class OpenCloseViolationTest
    {
        #region  Violation Food

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

        #endregion

        #region Violation Animal
        [Test]
        public void ShouldGenerateTicket()
        {
            var veterinanyCDMX = new Veterinary();
            var michi = new Animal { Age = 1, Gender = true, NickName = "Toto", Type = "Cat" };
            var animals = new List<Animal>
            {
                michi
            };

            var ticket = veterinanyCDMX.InjectAnimals(animals.ToArray(), "Karen", DateTime.Now);

            Debug.WriteLine("Ticket: " + ticket);
            Assert.IsTrue(ticket.Contains("Ticket"));
        }

        [Test]
        public void ShouldGenerateTicketWithMoreCats()
        {
            var veterinanyCDMX = new Veterinary();

            var blacky = new Animal { Age = 4, Gender = true, NickName = "Porfilio", Type = "Cat" };
            var michi = new Animal { Age = 8, Gender = true, NickName = "Toto", Type = "Cat" };
            var miu = new Animal { Age = 12, Gender = false, NickName = "Poki", Type = "Cat" };
            var tigre = new Animal { Age = 15, Gender = false, NickName = "Ki", Type = "Cat" };

            var animals = new List<Animal>
            {
                michi,
                blacky,
                michi,
                tigre,
                miu
            };

            var ticket = veterinanyCDMX.InjectAnimals(animals.ToArray(), "Karen macho", DateTime.Now);
            Debug.WriteLine("Ticket: " + ticket);
            Assert.IsTrue(ticket.Contains("Ticket"));
        }

        #endregion
    }
}
