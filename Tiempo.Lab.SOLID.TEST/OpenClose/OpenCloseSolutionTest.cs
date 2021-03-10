using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Tiempo.OpenClose.Solutions;

namespace Tiempo.Lab.SOLID.TEST.OpenClose
{
    [TestFixture]
    public class OpenCloseSolutionTest
    {

        #region Solution Food

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

        #endregion
       
        #region Solution Animal
        [Test]
        public void ShouldGenerateTicket()
        {
            var veterinanyGDL = new SuperVeterinary();
            var newCustomer = new Customer("Karen");
            var michi = new Cat(1,"Toto",true);
            var animals = new List<IAnimal>
            {
                michi
            };
          

            var ticket = veterinanyGDL.GenerteAppointmentWithTicket(animals, newCustomer, DateTime.Now);

            Debug.WriteLine("Ticket: " + ticket);
            Assert.IsTrue(ticket.Contains("Ticket"));
        }
        
        [Test]    
        public void ShouldGenerateTicketWithMoreCats()
        {
            var veterinanyCDMX = new SuperVeterinary();
            var newCustomer = new Customer("Karen Macho");

            var blacky = new Cat(4, "Porfilio", true);
            var michi = new Cat(8,"Toto",true);
            var miu = new Cat(12, "Poki",false);
            var tigre = new Cat( 15,"Ki",false);

            var animals = new List<IAnimal>
            {
                michi,
                blacky,
                michi,
                tigre,
                miu
            };

            var ticket = veterinanyCDMX.GenerteAppointmentWithTicket(animals, newCustomer, DateTime.Now);
            Debug.WriteLine("Ticket: " + ticket);
            Assert.IsTrue(ticket.Contains("Ticket"));
        }
        
        [Test]
        public void ShouldInjectAnimalsForToday()
        {
            var veterinanyCDMX = new SuperVeterinary();
            var newCustomer = new Customer("Luis");

            var blacky = new Cat(4, "Porfilio", true);
            var michi = new Cat(8, "Toto", true);

            var animals = new List<IAnimal>
            {
                michi,
                blacky
            };

            var ticket = veterinanyCDMX.InjectAnimals(animals, newCustomer, DateTime.Now);
            Debug.WriteLine("Ticket: " + ticket);
            Assert.IsTrue(ticket.ChecKOut.ToShortDateString() == DateTime.Now.ToShortDateString());
        }
        
        [Test]
        public void ShouldInjectAnimalsForTomorrow()
        {
            var veterinanyCDMX = new SuperVeterinary();
            var newCustomer = new Customer("Luis");

            var blacky = new Cat(4, "blacky", true);
            var michi = new Cat(8, "michi", true);
            var lucas = new Dog(20, "lucas", true);
            var sebas = new Cat(8, "sebas", false);

            var animals = new List<IAnimal>
            {
                michi,
                blacky,
                lucas,
                sebas
            };
            var checkInFake = DateTime.Now;

            var ticket = veterinanyCDMX.InjectAnimals(animals, newCustomer, checkInFake);
            Debug.WriteLine("Ticket: " + ticket);
            Assert.IsTrue(ticket.ChecKOut.ToShortDateString() == checkInFake.AddDays(7).ToShortDateString());
        }



        #endregion
    }
}
