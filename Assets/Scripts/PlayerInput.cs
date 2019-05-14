using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;
public class PlayerInput : MonoBehaviour
{

    private InputMaster _controlInput;
    private Vector2 _moveAxis;

    // Start is called before the first frame update
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
        Debug.Log("It's working: " + context.ReadValue<Vector2>());
    }

    // Update is called once per frame
    private void OnDisable()
    {
        _controlInput.Disable();

        _controlInput.Player.Movement.performed -= Movement_performed;
    }
}
