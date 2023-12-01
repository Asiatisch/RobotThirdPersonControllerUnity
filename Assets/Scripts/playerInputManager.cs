using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class playerInputManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 move;
    public Vector2 look;
    public bool switchMode;
    public bool sprint;
    public bool jump;
    void OnMove(InputValue value) 
    {
       move =  value.Get<Vector2>();
    }

    void OnLook(InputValue value)
    {
        look = value.Get<Vector2>();
    }
     void OnSwitchMode(InputValue Value)
    {
        switchMode = Value.isPressed;
    }

    void OnSprint(InputValue Value)
    {
        sprint = Value.isPressed;
    }

    void OnJump(InputValue Value)
    {
        jump = Value.isPressed;
    }
}  