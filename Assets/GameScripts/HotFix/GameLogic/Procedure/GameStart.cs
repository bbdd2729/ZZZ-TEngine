using TEngine;
using UnityEngine;


public class GameStart : ProcedureBase
    {
        protected override void OnInit(IFsm<IProcedureModule> procedureOwner)
        {
            base.OnInit(procedureOwner);
            
        }
        protected override void OnEnter(IFsm<IProcedureModule> procedureOwner)
        {
            base.OnEnter(procedureOwner);

            Debug.Log("--------------GameStart,游戏开始--------------");
        }
        protected override void OnUpdate(IFsm<IProcedureModule> procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
            ChangeState<InitAvatar>(procedureOwner);
        }
        protected override void OnLeave(IFsm<IProcedureModule> procedureOwner, bool isShutdown)
        {
            base.OnLeave(procedureOwner, isShutdown);
        }
        protected override void OnDestroy(IFsm<IProcedureModule> procedureOwner)
        {
            base.OnDestroy(procedureOwner);
        }
    }
