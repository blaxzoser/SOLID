using System;


namespace Tiempo.Lab.SOLID.LisvokSubtitutionPrincipal
{
    public class Burger
    {
        public virtual void MakeMeat()
        {
            //wummy
        }

        public virtual void PutPan()
        {

        }

        public virtual void PutVegetables()
        {

        }
    }
    public class PorkBurger : Burger
    {
         public override void MakeMeat()
         {
             //wummy
         }

         public override void PutPan()
         {

         }

         public override void PutVegetables()
         {

         }
     }
    public class ChikenBurger : Burger
    {
         public override void MakeMeat()
         {
             //wummy
         }

         public override void PutPan()
         {

         }

         public override void PutVegetables()
         {

         }
     }
    public class VegiBurger : Burger
    {
        public override void MakeMeat()
        {
            throw new NotImplementedException();
        }

        public override void PutPan()
    {

    }

        public override void PutVegetables()
    {

    }
    }
}

