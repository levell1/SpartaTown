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
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);          // ���� ���������� ����
        newAim = (worldPos - (Vector2)transform.position).normalized;   // ���콺��ġ - ����ġ = ���콺����Ʈ�� ���ϴ� ����
        CallLookEvent(newAim);
        /*Debug.Log("���콺 ��ġ: "+ value.Get<Vector2>() );
        Debug.Log("���� ������" + worldPos);
        Debug.Log("���� :" + newAim);*/

    }

}
