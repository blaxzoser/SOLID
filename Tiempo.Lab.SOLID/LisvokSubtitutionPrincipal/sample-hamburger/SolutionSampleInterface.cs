using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.Lab.SOLID.LisvokSubtitutionPrincipal
{
    public interface IMeet
    {
        void MakeMeat();
    }

    public interface IBurger
    {
        void PutPan();

    }

    public interface IVegan
    {
        void PutVegetables();
    }

    public interface IVeganBurger : IBurger, IVegan
    {

    }

    public class VeganBurger : IVeganBurger
    {
        public void PutPan()
        {

        }

        public void PutVegetables()
        {
        }
    }

    public class ChickenBurger : IBurger, IMeet
    {
        public void PutPan()
        {

        }
        public void MakeMeat()
        {

        }

    }

}
