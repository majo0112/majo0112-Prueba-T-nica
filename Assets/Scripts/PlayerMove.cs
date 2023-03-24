using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    public float runspeed=2;

    public float jumpSpeed = 3;

    public int vidas = 0;

    Rigidbody2D Casper2D;

    private static Animator animator;

    public bool betterJump = false;

    public float fallMultiplier = 0.5f;

    public float lowJumpMultiplier = 1f;

    public SpriteRenderer spriteRenderer;

    [Header("Rebote")]
    [SerializeField] private float velocidadRebote; 

    void Start()
    {
        Casper2D = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }

    public void Rebote()
    {
        Casper2D.velocity = new Vector2(Casper2D.velocity.x, velocidadRebote);
    }
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right") )

        {
            Casper2D.velocity = new Vector2(runspeed, Casper2D.velocity.y);
            spriteRenderer.flipX = false; //Desactivar flip X.
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            Casper2D.velocity = new Vector2(-runspeed, Casper2D.velocity.y);
            spriteRenderer.flipX = true; //Activar flip X.
        }
        else
        {
            Casper2D.velocity = new Vector2(0, Casper2D.velocity.y);
        }
        if (Input.GetKey("space") && CheckGround.isGrounded)
        {
            Casper2D.velocity = new Vector2(Casper2D.velocity.x, jumpSpeed);
        }
        if (betterJump)
        {
            if(Casper2D.velocity.y>0)
            {
                Casper2D.velocity += Vector2.up * Physics.gravity.y * (fallMultiplier) * Time.deltaTime; 
            }
            if (Casper2D.velocity.y < 0 && !Input.GetKey("space"))
            {
                Casper2D.velocity += Vector2.up * Physics.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
            }
        }

    }
        

}
