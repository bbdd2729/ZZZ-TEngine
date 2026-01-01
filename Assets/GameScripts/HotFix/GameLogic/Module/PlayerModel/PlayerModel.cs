using dnlib.DotNet;
using GameLogic;
using TEngine;
using UnityEngine;


public interface IPlayerModel
{
    void OnInit();
    void Shutdown();
    public InputSystem_ZZZ InputSystem { get; }
}

public class PlayerModel : Module, IPlayerModel
{
        public  InputSystem_ZZZ inputSystem;
        
        public InputSystem_ZZZ InputSystem => inputSystem;
        public void Init()
        {
            
        }

        public override void OnInit()
        {
            
            inputSystem = new InputSystem_ZZZ();
            inputSystem.Player.Enable();
            Debug.Log("输入系统初始化成功");
        }
        public override void Shutdown()
        {
            throw new System.NotImplementedException();
            // 2. 对称释放，防止泄漏
            inputSystem?.Player.Disable();
            inputSystem?.UI.Disable();
            inputSystem?.Dispose();         // 如果 InputSystem_ZZZ 实现了 IDisposable
            inputSystem = null;
        }
    }
