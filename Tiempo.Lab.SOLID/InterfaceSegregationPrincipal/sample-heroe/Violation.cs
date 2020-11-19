using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.Lab.SOLID.InterfaceSegregationPrincipal.sample_heroe.Violation
{
    public interface Heroe
    {
        public string ShowMask();

        public void ShowArmor();

        public string ShowCap();

        public string Fly();

        public void Drive();

    }

    public class Superman :Heroe
    {
        public string ShowMask()
        {
            throw  new Exception("I dont use mask!!!! WTF");
        }

        public void ShowArmor()
        {
            throw new Exception("I dont use armor , !!!! WTF");
        }

        public string ShowCap()
        {
            return "it is black";

        }

        public string Fly()
        {
            return "i can fly! ";

        }

        public void Drive()
        {
            throw new Exception("I dont need a car WTF!!!");

        }
    }

    public class Batman : Heroe
    {
        public string ShowMask()
        {
            return "it is black";
        }

        public void ShowArmor()
        {
            //It's not so good
        }

        public string ShowCap()
        {
            return "it is black";
        }

        public string Fly()
        {
            throw new Exception("I dont cant :( !!!! WTF");

        }

        public void Drive()
        {
            // I can use batimovil :)
        }
    }

    public class Spiderman : Heroe
    {
        public string ShowMask()
        {
            return "it is red";
        }

        public void ShowArmor()
        {
            throw new Exception("I dont use armor , !!!! WTF");
        }

        public string ShowCap()
        {

            throw new Exception("I dont a cap , !!!! WTF");
        }

        public string Fly()
        {
            throw new Exception("I cant :( !!!! WTF");

        }

        public void Drive()
        {
            throw new Exception("I dont use a car! WTF!!!");
        }
    }

    public class IronMan : Heroe
    {
        public string ShowMask()
        {
            return "it is red";
        }

        public void ShowArmor()
        {
          //It is the best
        }

        public string ShowCap()
        {
            throw new Exception("I dont a cap , !!!! WTF");
        }

        public string Fly()
        {
            return "It can until the sun";
        }

        public void Drive()
        {
            throw new Exception("I dont use a car! WTF!!!");
        }
    }
}
