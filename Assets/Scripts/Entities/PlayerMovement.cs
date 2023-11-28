using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerController _controller;
    private Animator _animator;

    

    private Vector3 _movementDirection= Vector2.zero;
    private Rigidbody2D _rigidbody;
    [SerializeField] private int _speed = 5;
    [SerializeField] private GameObject _Npc;
    [SerializeField] private GameObject talk;

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == _Npc)
        {
            talk.SetActive(true);
        } 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == _Npc)
        {
            talk.SetActive(false);
        }
    }


    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }
    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
        
    }
    private void ApplyMovement(Vector2 direction) 
    {
        
        direction = direction * _speed;
        _rigidbody.velocity = direction;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
