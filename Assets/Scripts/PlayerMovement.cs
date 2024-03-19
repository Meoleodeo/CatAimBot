using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;
    [SerializeField] private LayerMask jumpableGround;
    private float dirX = 0f;
    private float dirY = 0f;
    [SerializeField] private float moveSpeed = 7f;
    private string horizontalInputAxis = "Horizontal";
    private string verticalInputAxis = "Vertical";
    [SerializeField] private string playerNum;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        dirX = Input.GetAxisRaw(horizontalInputAxis+playerNum);
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
        dirY = Input.GetAxisRaw(verticalInputAxis+playerNum);
        rb.velocity = new Vector2(rb.velocity.x, dirY * moveSpeed);
        updateAnim();
    }

    private void updateAnim(){
        if (dirX > 0f)
        {
            sprite.flipX = false;
            anim.Play("run"+playerNum);
        }
        else if (dirX < 0f)
        {
            sprite.flipX = true;
            anim.Play("run"+playerNum);
        }    
        else{
            anim.Play("idle"+playerNum);
        }
    }

}
