using System;
using UnityEngine;
using TEngine;

/// <summary>
/// 玩家控制器
/// </summary>
public class PlayerController : MonoBehaviour
    {
        private IFsm<PlayerController> fsm;
        public Animator animator;
        public bool StateLock = false;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        private void Start()
        {
        Debug.Log("PlayerController Start");
        FsmState<PlayerController>[] states =
        {
            new IdleState(),
            new WalkState(),
        };
        fsm = ModuleSystem.GetModule<IFsmModule>().CreateFsm(this, states);
        fsm.Start<IdleState>();
        }


        private void Update()
        {
            Debug.Log(ModuleSystem.GetModule<IPlayerModel>().InputSystem.Player.Move.ReadValue<Vector2>(). x);
        }
        
    
    
    
    }
