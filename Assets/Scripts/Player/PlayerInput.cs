using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

namespace Forms.Player
{
    public class PlayerInput : MonoBehaviour
    {
        
        [SerializeField]
        private Vector2 _offset = new Vector2 (2, 0);
        private InputMaster _controlInput;
        private Vector2 _moveAxis;

        void Awake()
        {
            _controlInput = new InputMaster();
        }

        private void OnEnable()
        {
            _controlInput.Enable();

            _controlInput.Player.Movement.performed += Movement_performed;
        }

        private void Movement_performed(InputAction.CallbackContext context)
        {
            if (CheckMovement(context))
                return;

            transform.position = (Vector2)transform.position 
                + context.ReadValue<Vector2>() 
                * _offset;
        }
             

        // Update is called once per frame
        private void OnDisable()
        {
            _controlInput.Disable();

            _controlInput.Player.Movement.performed -= Movement_performed;
        }

        private bool CheckMovement(InputAction.CallbackContext _ctx)
        {
            if (_ctx.ReadValue<Vector2>().x == -1 && transform.position.x == -2)
                return true;
            else if (_ctx.ReadValue<Vector2>().x == 1 && transform.position.x == 2)
                return true;
            else
                return false;
        }

    }
}