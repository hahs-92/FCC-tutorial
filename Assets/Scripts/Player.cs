using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // permite que las variables sean visibles en el unity
    [SerializeField]
    private float moveForce = 10f;

    [SerializeField]
    private float jumpForce = 11f;

    private float movementX = 0;

    // necesitamos la referencia del rigidBody
    // una manera es arrastrar en el untity la ref
    [SerializeField]
    private Rigidbody2D myBody;

    private Animator anim;
    private SpriteRenderer sr;

    private readonly string WALK_ANIMATION = "isWalk";
    private readonly string GROUNG_TAG = "Ground";
    private bool isGrounded = true;


    private void Awake()
    {
        // esta es otra manera de obtener la ref
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
            
    }

    private void Update()
    {
        PlayerMoveKeyBoard();
        AnimatePlayer();
        PlayerJump();
    }

    private void FixedUpdate()
    {
        //PlayerJump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // el tag se agrego a cada asset de ground
        if(collision.gameObject.CompareTag(GROUNG_TAG))
        {
            isGrounded = true;
        }
    }

    private void PlayerMoveKeyBoard()
    {
        // !GetAxis devuelve valores entre -1... 0 ... 1
        // GetAxisRaw devuleve valores entre -1 0 1
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
        
    }

    void AnimatePlayer()
    {
       if(movementX > 0f)
        {
            // we are going to the right side
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        } else if(movementX < 0f)
        {
            // we are going to the letf side
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        } else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }

    void PlayerJump()
    {
        // se presiona el espaciador
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded= false;
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

}
