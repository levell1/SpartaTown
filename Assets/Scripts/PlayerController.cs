using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnJumpEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action<Vector2> OnFireEvent;

    public void CallMoveEvent(Vector2 direction) 
    {
        OnMoveEvent?.Invoke(direction);
    }
    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    /*    public void CallJumpEvent(Vector2 direction)
        {
            OnJumpEvent?.Invoke(direction);
        }

        public void CallFireEvent(Vector2 direction)
        {
            OnFireEvent?.Invoke(direction);
        }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
