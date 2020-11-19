
namespace Tiempo.Lab.SOLID.InterfaceSegregationPrincipal.sample_heroe
{
    public interface AlienHeroe
    {
        public string Fly();
    }
    public interface TechHeroe
    {
        public void ShowArmor();
    }
    public interface BasicArmor
    {
        public string ShowMask();
    }
    public interface RichHeroe
    {
        public void Drive();
    }
    public class Superman : AlienHeroe
    {
        public string Fly()
        {
            return "i can fly! ";

        }
    }
    public class Batman : TechHeroe, RichHeroe
    {
        public void ShowArmor()
        {
            //It's not so good
        }

        public void Drive()
        {
            // I can use batimovil :)
        }
    }
    public class Spiderman : BasicArmor
    {
        public string ShowMask()
        {
            return "it is red";
        }
    }
    public class IronMan : BasicArmor, TechHeroe
    {
        public string ShowMask()
        {
            return "it is red";
        }

        public void ShowArmor()
        {
            //It is the best
        }
    }
}
