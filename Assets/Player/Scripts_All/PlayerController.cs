using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int can_jump = 2;
    public float speed;
    public float jumpforce;
    public float gravity = 9.8f;
    private float _fallVelocity = 0;
    private CharacterController _characterController;
    private Vector3 _VectorMove;
    public Animator animator;
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        _fallVelocity += gravity * Time.fixedDeltaTime;

        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);

        _characterController.Move(_VectorMove * speed * Time.fixedDeltaTime);

        if (_characterController.isGrounded)
        {
            _fallVelocity = 0;
        }
    }

    void Update()
    {
        Jump();

        Walk_Move();
    }

    private void Walk_Move()
    {
        _VectorMove = Vector3.zero;
        var runDirection = 0;

        if (Input.GetKey(KeyCode.W))
        {
            _VectorMove += transform.forward;
            runDirection = 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            _VectorMove -= transform.right;
            runDirection = 3;
        }

        if (Input.GetKey(KeyCode.D))
        {
            _VectorMove += transform.right;
            runDirection = 4;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _VectorMove -= transform.forward;
            runDirection = 2;
        }

        animator.SetInteger("RunDirection", runDirection);
    }

    private void Jump()
    {
        if (_characterController.isGrounded)
        {
            can_jump = 2;
        }

        if (Input.GetKeyDown(KeyCode.Space) && (can_jump >= 1))
        {
            _fallVelocity = -jumpforce;
            can_jump -= 1;
        }
    }
}
