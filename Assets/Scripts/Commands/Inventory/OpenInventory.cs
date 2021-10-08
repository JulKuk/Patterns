using System;

namespace Assets.Scripts.Commands.Inventory
{
    public class OpenInventory : ICommand
    {
        private readonly Models.Inventory m_Inventory;

        public OpenInventory(Models.Inventory inventory)
        {
            m_Inventory = inventory;
        }

        public void Execute()
        {
            m_Inventory.ShowInventory();
        }

        public void UnExecute()
        {
            throw new NotImplementedException("not implementedYET");
        }
    }
}
