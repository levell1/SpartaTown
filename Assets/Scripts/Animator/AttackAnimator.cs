using UnityEngine;
using UnityEngine.InputSystem;

public class AttackAnimator : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void OnFire(InputValue value)
    {
        animator.SetBool("fire", value.isPressed);
    }
}
