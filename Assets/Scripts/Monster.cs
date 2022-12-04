using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed; // esta velocidad se setea en MonsterSpawner

    private Rigidbody2D myBody;

    // los enemigos no se chocan entre si, porque tienen la misma layer y
    // en project Settings / physic2d se configuro que no se toquen

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        //speed = 7f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
