using Assets.Scripts.Metadata;

namespace Assets.Scripts.Commands
{
    public class MoveForward : ICommand
    {
        private readonly MoveableObject m_Entity;

        public MoveForward(MoveableObject entity)
        {
            m_Entity = entity;
        }

        public void Execute()
        {
            m_Entity.MoveForward();
        }

        public void UnExecute()
        {
           m_Entity.MoveBack();
        }
    }
}
