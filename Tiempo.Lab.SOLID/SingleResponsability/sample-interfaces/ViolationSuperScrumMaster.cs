using System;
using System.Collections.Generic;
using System.Text;

namespace Tiempo.Lab.SOLID.SingleResponsability
{
    /// <summary>
    /// Violation Single responsibility
    /// </summary>
    public interface IScrumMeeting
    {
         void ShowBoard();
         void GiveStatus(string name);
         void CreateTask(int userStory);
         void MoveTask(int userStory);
         void ResolveImpediment(int userStory);
         void ChangeUserStory();


    }
}
