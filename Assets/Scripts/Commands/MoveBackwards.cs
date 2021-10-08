using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Metadata;
using UnityEngine;

public class MoveBackwards : ICommand
{
    private readonly MoveableObject m_Entity;

    public MoveBackwards(MoveableObject entity)
    {
        m_Entity = entity;
    }

    public void Execute()
    {
        m_Entity.MoveBack();
    }

    public void UnExecute()
    {
        m_Entity.MoveForward();
    }
}
