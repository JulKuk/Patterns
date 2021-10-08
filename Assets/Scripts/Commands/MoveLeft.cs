using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Metadata;
using UnityEngine;

public class MoveLeft : ICommand
{
    private readonly MoveableObject m_Entity;

    public MoveLeft(MoveableObject entity)
    {
        m_Entity = entity;
    }

    public void Execute()
    {
        m_Entity.TurnLeft();
    }

    public void UnExecute()
    {
        m_Entity.TurnRight();
    }
}
