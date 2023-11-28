using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class zepAnimator : MonoBehaviour
{
    private Animator animator;

    public void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void OnMove(InputValue value) // w  a  s d
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        animator.SetBool("Iswalk", moveInput != Vector2.zero);
    }


}
