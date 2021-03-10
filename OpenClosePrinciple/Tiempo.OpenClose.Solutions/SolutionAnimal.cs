using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.OpenClose.Solutions
{
    public interface IAnimal
    {
        void Cry();
    }

    public class Dog : IAnimal
    {
        public void Cry()
        {
            //wuauff
        }
    }

    public class Cat : IAnimal
    {
        public void Cry()
        {
            //Miau
        }
    }

    public class Veterinary
    {
        public void InjectAllAnimals(IEnumerable<IAnimal> animals)
        {
            foreach (var animal in animals)
            {
                animal.Cry();
            }
        }
    }
}
