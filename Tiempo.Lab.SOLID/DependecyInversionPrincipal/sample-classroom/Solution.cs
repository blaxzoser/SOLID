
namespace Tiempo.Lab.SOLID.DependecyInversionPrincipal.sample_classroom.Solution 
{
    //Abstractions 
    public interface  ITeacher
    {
        public void TeachThem();
    }

    /// <summary>
    /// Low Module
    /// </summary>
    public class MathTeacher : ITeacher
    {
        public void TeachThem() { }
    }

    /// <summary>
    /// High Module
    /// </summary>
    public class ClassRoom
    {
        private ITeacher _teacher;
        public bool IsEmpty { get; set; }
        public void StarClass()
        {
            if (!IsEmpty)
            {
                _teacher.TeachThem();
            }
        }

        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

    }
}
