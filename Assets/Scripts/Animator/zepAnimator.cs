using UnityEngine;
using UnityEngine.InputSystem;

public class zepAnimator : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnMove(InputValue value) // w  a  s d
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        animator.SetBool("Iswalk", moveInput != Vector2.zero);
    }
}
