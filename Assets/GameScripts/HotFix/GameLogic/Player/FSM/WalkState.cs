using TEngine;
using UnityEngine;

public class WalkState : FsmState<PlayerController>
    {
        protected override void OnInit(IFsm<PlayerController> fsm)
        {
            base.OnInit(fsm);
        }
        protected override void OnEnter(IFsm<PlayerController> fsm)
        {
            base.OnEnter(fsm);
            fsm.Owner.animator.Play("Walk");
        }
        protected override void OnUpdate(IFsm<PlayerController> fsm, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);
            Debug.Log(ModuleSystem.GetModule<IPlayerModel>().InputSystem.Player.Move.ReadValue<Vector2>(). x);
            
            if (ModuleSystem.GetModule<IPlayerModel>().InputSystem.Player.Move.ReadValue<Vector2>() == Vector2.zero)
            {
                base.ChangeState<IdleState>(fsm);
            }
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
