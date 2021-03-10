using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.OpenClose.Solutions
{
    public interface IAnimal
    {
        int Age { get; set; }

        string NickName { get; set; }

        bool Gender { get; set; }
    }

    public interface ICatVaccine
    {
        bool IsInyectedXX { get; }
        bool IsInyectedXY { get; }

    }

    public interface IDogVaccine
    {
        bool IsInyectedAA { get; }
        bool IsInyectedAC { get; }
        bool IsInyectedCC { get; }
    }

    
    public interface IPill
    {
        bool HasPills { get; }
        int NumberOfPills { get; }
    }


    public interface ITicket
    {
        public DateTime ChecKIn { get; set; }

        public DateTime ChecKOut { get; set; }

        public Guid TicketID { get; set; }
    }


    public class Dog : IAnimal, IDogVaccine, IPill
    {
        public Dog(int age, string nickName, bool gender)
        {
            Age = age;
            NickName = NickName;
            Gender = gender;
        }

        public int Age { get; set; }
        public string NickName { get; set; }
        public bool Gender { get; set; }

        public bool IsInyectedAA => Gender && (Age > 1);
        public bool IsInyectedAC => !Gender;
        public bool IsInyectedCC => !Gender;

        public bool HasPills => NumberOfPills > 0;
        public int NumberOfPills => Gender && Age > 5 ? 8 : 0;
    }

    public class Cat : IAnimal, ICatVaccine, IPill
    {
        public Cat(int age, string nickName, bool gender)
        {
            Age = age;
            NickName = nickName;
            Gender = gender;
        }

        public int Age { get; set; }
        public string NickName { get; set; }
        public bool Gender { get; set; }

        public bool IsInyectedXX => Gender && Age > 1;

        public bool IsInyectedXY => !Gender;

        public int NumberOfPills => !Gender ? 1 : 0;

        public bool HasPills => NumberOfPills > 0;
    }
    public class Customer
    {
        public Customer(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
                throw new Exception("The customer name is mandatory");

            FullName = fullName;
        }

        public string FullName { get; set; }
    }

    public class Ticket : ITicket
    {
        private string _nameCustomer;
        public Ticket(string NameCustomer)
        {
            _nameCustomer = NameCustomer;
        }

        public DateTime ChecKIn { set; get; }
        public DateTime ChecKOut { set; get; }
        public Guid TicketID { set; get; }
    }

    interface Veterinaty
    {
        Ticket InjectAnimals(
            List<IAnimal> animals,
            Customer customer,
            DateTime checkIn
            );
    }
    
    
    public class SuperVeterinary : Veterinaty
    {

        public Ticket InjectAnimals(
            List<IAnimal> animals,
            Customer customer,
            DateTime checkIn
            )
        {
            var newTicket = new Ticket(customer.FullName);
            if (animals.Count <= 2)
            {
                newTicket.ChecKOut = checkIn.AddHours(5);
            }
            else if (animals.Count > 3 && animals.Count < 10)
            {
                newTicket.ChecKOut = checkIn.AddDays(7);
            }
            else if (animals.Count > 10 && animals.Count < 15)
            {
                newTicket.ChecKOut = checkIn.AddDays(20);
            }
            else
                throw new Exception("OMG We had a huge problem");

            return newTicket;
        }

        
        public string GenerteAppointmentWithTicket(
            List<IAnimal> animals,
            Customer customer,
            DateTime checkIn
            )
        {
            var newTicket = InjectAnimals(animals, customer, checkIn);
            return string.Format("No.Ticket --{0}--", newTicket.TicketID);
        }

    }


 

}
