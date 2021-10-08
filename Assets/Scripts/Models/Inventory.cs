using System.Collections.Generic;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class Inventory
    {
        private List<IItem> _inventory;

        private InventoryState _state;

        private int _maxItemCount;

        public Inventory(int maxItemCount)
        {
            _state = InventoryState.Close;
            _maxItemCount = maxItemCount;
            _inventory = new List<IItem>();
        }

        public void AddItem(IItem itemToAdd)
        {
            if (_maxItemCount >= _inventory.Count)
            {
                _inventory.Add(itemToAdd);
            }
        }

        public void ShowInventory()
        {
            if (_state == InventoryState.Close)
            {
                _state = InventoryState.Open;
                Debug.Log("im Opened");
                foreach (var item in GetItems())
                {
                    Debug.Log(item.Name);
                }
                
            }
            else
            {
                _state = InventoryState.Close;
                Debug.Log("im closed");
            }
        }

        public void RemoveItem(IItem itemToRemove)
        {
            _inventory.Remove(itemToRemove);
        }

        public List<IItem> GetItems()
        {
            return _inventory;
        }
    }

    internal enum InventoryState
    {
        Close,
        Open
    }
}
