using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.Lab.SOLID.DependecyInversionPrincipal.sample_classroom.Violation
{
    public class Teacher
    {
        public void TeachThem(){}
    }

    public class ClassRoom
    {
        private Teacher _teacher;

        public bool IsEmpty  { get; set; }
        public void StarClass()
        {
            if (!IsEmpty)
            {
                _teacher.TeachThem();
            }
        }

    }
}
