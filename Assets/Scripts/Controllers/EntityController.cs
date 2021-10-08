using System.Collections.Generic;
using Assets.Scripts.Commands;
using Assets.Scripts.Commands.Inventory;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Metadata;
using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class EntityController : MonoBehaviour
    {
        public MoveableObject ObjectThatMoves;

        private ICommand m_ButtonW;
        private ICommand m_ButtonA;
        private ICommand m_ButtonS;
        private ICommand m_ButtonD;
        private ICommand m_ButtonI;

        private readonly Stack<ICommand> m_UndoCommands = new Stack<ICommand>();
        private Inventory _inventory;

        void Start()
        {
            _inventory = new Inventory(8);
            m_ButtonW = new MoveForward(ObjectThatMoves);
            m_ButtonA = new MoveLeft(ObjectThatMoves);
            m_ButtonS = new MoveBackwards(ObjectThatMoves);
            m_ButtonD = new MoveRight(ObjectThatMoves);
            m_ButtonI = new OpenInventory(_inventory);
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                ExecuteNewCommand(m_ButtonW);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                ExecuteNewCommand(m_ButtonA);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                ExecuteNewCommand(m_ButtonS);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                ExecuteNewCommand(m_ButtonD);
            }else if (Input.GetKeyDown(KeyCode.I))
            {
                ExecuteNewCommand(m_ButtonI);
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            var item = collision.gameObject.GetComponent<IItem>();
            if (item != null)
            {
               
            }
        }

        private void OnTriggerStay(Collider collider)
        {
            var item = collider.gameObject.GetComponent<IItem>();
            if (item != null && Input.GetKeyDown(KeyCode.E))
            {
                _inventory.AddItem(item);
                Destroy(collider.gameObject);
            }
        }

        private void ExecuteNewCommand(ICommand commandButton)
        {
            commandButton.Execute();

            m_UndoCommands.Push(commandButton);
        }
    }
}
