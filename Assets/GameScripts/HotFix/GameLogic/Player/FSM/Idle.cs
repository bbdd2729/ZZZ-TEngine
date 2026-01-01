

using TEngine;
using UnityEngine;

public class IdleState : FsmState<PlayerController> 
{
    protected override void OnInit(IFsm<PlayerController> fsm)
    {
        base.OnInit(fsm);
    }

    protected override void OnEnter(IFsm<PlayerController> fsm)
    {
        base.OnEnter(fsm);
        Debug.Log("进入待机状态");
        fsm.Owner.animator.Play("Idle");
}
    protected override void OnUpdate(IFsm<PlayerController> fsm, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);
        if (ModuleSystem.GetModule<IPlayerModel>().InputSystem.Player.Move.ReadValue<Vector2>() != Vector2.zero)
        {
            base.ChangeState<WalkState>(fsm);
        }
        Debug.Log(ModuleSystem.GetModule<IPlayerModel>().InputSystem.Player.Move.ReadValue<Vector2>(). x);
    }
    protected override void OnLeave(IFsm<PlayerController> fsm, bool isShutdown)
    {
        base.OnLeave(fsm, isShutdown);
    }
    protected override void OnDestroy(IFsm<PlayerController> fsm)
    {
        base.OnDestroy(fsm);
    }
}
