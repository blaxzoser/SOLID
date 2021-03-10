using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.OpenClose.Violations
{

    enum Animal
    {
        Dog,
        Cat
    }

    public class Dog
    {
        public void Cry()
        {
            //wuauff
        }
    }

    public class Cat
    {
        public void Cry()
        {
            //wuauff
        }
    }


    public class Veterinary
    {
        public void InjectAllAnimals(object[] animals)
        {
            foreach (var animal in animals)
            {
                switch (animal)
                {
                    case Dog dog:
                        dog.Cry();
                        break;
                    case Cat cat:
                        cat.Cry();
                        break;
                }
            }
        }

    }
}
