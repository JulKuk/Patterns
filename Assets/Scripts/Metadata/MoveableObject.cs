using Assets.Scripts.Const;
using UnityEngine;

namespace Assets.Scripts.Metadata
{
    public class MoveableObject : MonoBehaviour
    {
        public void MoveForward()
        {
            Move(Vector3.forward);
        }

        public void MoveBack()
        {
            Move(Vector3.back);
        }

        public void TurnLeft()
        {
            Move(Vector3.left);
        }

        public void TurnRight()
        {
            Move(Vector3.right);
        }

        private void Move(Vector3 dir)
        {
            transform.Translate(dir * MovementConstance.k_MoveStepDistance);
        }
    }
}
