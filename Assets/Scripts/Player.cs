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

    private readonly string WALK_ANIMATION = "Walk";


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
    }

    private void PlayerMoveKeyBoard()
    {
        // !GetAxis devuelve valores entre -1... 0 ... 1
        // GetAxisRaw devuleve valores entre -1 0 1
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
        
    }

}
