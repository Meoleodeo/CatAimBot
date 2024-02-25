using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;

    [SerializeField] private LayerMask jumpableGround;
    private float dirX = 0f;
    private float dirY = 0f;
    [SerializeField] private float moveSpeed = 7f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        dirY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, dirY * moveSpeed);
            
   
    }

}
