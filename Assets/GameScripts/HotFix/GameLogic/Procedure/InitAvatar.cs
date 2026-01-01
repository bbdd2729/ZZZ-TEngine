using TEngine;
using UnityEngine;

public class InitAvatar : ProcedureBase
    {
        protected override void OnInit(IFsm<IProcedureModule> procedureOwner)
        {
            base.OnInit(procedureOwner);
        }
        protected override void OnEnter(IFsm<IProcedureModule> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            GameObject avatar = GameObject.Find("Avatar_Female_Size02_Anbi_Model");
            if (avatar != null)
            {
                //avatar.AddComponent<PlayerController>();
                
            }
            else
            {
                Debug.LogError("Avatar_Female_Size02_Anbi_Model 不存在");
            }
        }
        protected override void OnUpdate(IFsm<IProcedureModule> procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
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
