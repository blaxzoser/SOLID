using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.OpenClose.Violations
{
    public class Animal
    {
        public bool IsInyectedAA { get; set; }
        public bool IsInyectedAC { get; set; }
        public bool IsInyectedCC { get; set; }
        public bool IsInyectedXX { get; set; }
        public bool IsInyectedXY { get; set; }
        public int Age { get; set; }
        public string NickName { get; set; }
        public bool Gender { get; set; }
        public string Type { get; set; }
        public int Pills { get; set; }
        public bool HasPills { get; set; }
        public Guid Ticket { get; set; }
    }


    public class Veterinary
    {
        public string InjectAnimals(
            Animal[] animals,
            string customerName,
            DateTime checkIn)
        {
            if (string.IsNullOrEmpty(customerName))
                throw new Exception("The customer name is mandatory");

            DateTime checkOut;
            if(animals.Length  <= 2)
            {
                checkOut = checkIn.AddHours(5);
            }
            else if (animals.Length > 3 && animals.Length < 10)
            {
                checkOut = checkIn.AddDays(7);
            }
            else if (animals.Length > 10 && animals.Length < 15)
            {
                checkOut = checkIn.AddDays(20);
            }
            else
                throw new Exception("OMG We had a huge problem");

            var newTicket = Guid.NewGuid();
            foreach (var animal in animals)
            {
                switch (animal.Type)
                {
                    case "Dog":
                        if (animal.Gender)
                        {
                            if (animal.Age > 1)
                                animal.IsInyectedAA = true;
                        }
                        else
                        {
                            animal.IsInyectedAC = true;
                            animal.IsInyectedCC = true;
                            if (animal.Age > 10)
                            {
                                animal.HasPills = true;
                                animal.Pills = 5;
                            }
                        }

                        break;
                    case "Cat":
                        if (animal.Gender)
                        {
                            if (animal.Age > 1)
                                animal.IsInyectedXX = true;
                        }
                        else
                        {
                            animal.IsInyectedXY = true;
                            if (animal.Age > 8)
                            {
                                animal.HasPills = true;
                                animal.Pills = 1;
                            }
                        }
                        break;
                }
                animal.Ticket = newTicket;            
            }
            return string.Format("No.Ticket --{0}-- CheckOut:{1}", newTicket, checkOut.ToShortDateString());
        }

    }
}
