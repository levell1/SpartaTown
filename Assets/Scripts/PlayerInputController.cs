using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : PlayerController
{
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject Label1;


    private void Awake()
    {

    }

    public void OnMove(InputValue value) // w  a  s d
    {
        if (!Label1.activeSelf)
        {
            Vector2 moveInput = value.Get<Vector2>().normalized;
            CallMoveEvent(moveInput);
        }
    }
    /*
    public void OnFire(InputValue value) 
    {

    }
    
    public void OnJump(InputValue value)
    {

    }*/
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);          // 월드 포지션으로 변경
        newAim = (worldPos - (Vector2)transform.position).normalized;   // 마우스위치 - 내위치 = 마우스포인트를 향하는 방향
        CallLookEvent(newAim);
        /*Debug.Log("마우스 위치: "+ value.Get<Vector2>() );
        Debug.Log("월드 포지션" + worldPos);
        Debug.Log("방향 :" + newAim);*/

    }

}
