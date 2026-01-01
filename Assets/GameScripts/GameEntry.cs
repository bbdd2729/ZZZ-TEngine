using TEngine;
using UnityEngine;

public class GameEntry : MonoBehaviour
{
    void Awake()
    {
        ModuleSystem.GetModule<IUpdateDriver>();
        ModuleSystem.GetModule<IResourceModule>();
        ModuleSystem.GetModule<IDebuggerModule>();
        ModuleSystem.GetModule<IFsmModule>();
        //ModuleSystem.GetModule<IPlayerModel>();
        Settings.ProcedureSetting.StartProcedure().Forget();
        DontDestroyOnLoad(this);
    }
    
    void Start()
    {
        
    }
}