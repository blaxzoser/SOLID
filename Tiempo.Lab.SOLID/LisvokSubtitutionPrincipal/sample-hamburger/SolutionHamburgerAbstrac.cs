﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.Lab.SOLID.LisvokSubtitutionPrincipal
{
    public abstract class Hamburger
    {
        public abstract void MakeMeat();
        public abstract void PutPan();
        public abstract void PutVegetables();

    }

    public class Chicken : Hamburger
    {
        public override void MakeMeat()
        {

        }

        public override void PutPan()
        {

        }

        public override void PutVegetables()
        {

        }
    }

    public class Vegin : Hamburger
    {
        public override void MakeMeat()
        {

        }

        public override void PutPan()
        {

        }

        public override void PutVegetables()
        {

        }
    }
}
