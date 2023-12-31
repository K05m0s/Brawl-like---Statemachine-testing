using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shroom_DeadState : DeadState
{
    private Shroom shroom;

    public Shroom_DeadState(Entity entity, FiniteStateMachine stateMachine, string animBoolName, D_DeadState stateData, Shroom shroom) : base(entity, stateMachine, animBoolName, stateData)
    {
        this.shroom = shroom;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
