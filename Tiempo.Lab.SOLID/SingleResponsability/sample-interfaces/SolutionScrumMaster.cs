using System;

namespace Tiempo.Lab.SOLID.SingleResponsability.sample_interfaces
{
    interface  ITeamMember
    {
        void GiveStatus(string name);
        void CreateTask(int userStory);
    }

    interface IScrumMaster
    {
        void ResolveImpediment(string name);
        void MoveTask(int userStory);
        void ShowBoard();
    }

    interface IProductOwner
    {
        void ChangeUserStory(int userStory);
    }


    public class ScrumMasterMeting : ITeamMember, IProductOwner, IScrumMaster
    {
        public void CreateTask(int userStory)
        {
            throw new NotImplementedException();
        }

        public void GiveStatus(string name)
        {
            throw new NotImplementedException();
        }

        public void MoveTask(int userStory)
        {
            throw new NotImplementedException();
        }

        public void ResolveImpediment(string name)
        {
            throw new NotImplementedException();
        }

        public void ShowBoard()
        {
            throw new NotImplementedException();
        }

        public void ChangeUserStory(int userStory)
        {
            throw new NotImplementedException();
        }
    }
}
