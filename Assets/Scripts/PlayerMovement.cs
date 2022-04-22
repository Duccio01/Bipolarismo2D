using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movementVector;
    public float speed = 5.0f;
    public float jumpHeight = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnMove(InputValue inputMove)
    {
        movementVector = inputMove.Get<Vector2>();
    }
    private void OnJump()
    {
        rb.velocity += Vector2.up * jumpHeight;
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(movementVector.x * speed, rb.velocity.y);
    }
}
