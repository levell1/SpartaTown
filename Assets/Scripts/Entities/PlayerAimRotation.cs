using System;
using UnityEngine;

public class PlayerAimRotation : MonoBehaviour
{

    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderers;

    private PlayerController _playerController;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _playerController.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotz = Mathf.Atan2(direction.y,direction.x)*Mathf.Rad2Deg;

        characterRenderers.flipX = (Mathf.Abs(rotz) > 90f);
        armPivot.rotation = Quaternion.Euler(0,0,rotz);
    }
}
