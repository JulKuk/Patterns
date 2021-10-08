using Assets.Scripts.Metadata;
using UnityEngine;

public class MoveRight : ICommand
{
    private readonly MoveableObject m_Entity;

    public MoveRight(MoveableObject entity)
    {
        m_Entity = entity;
    }

    public void Execute()
    {
        m_Entity.TurnRight();
    }

    public void UnExecute()
    {
        m_Entity.TurnLeft();
    }
}
