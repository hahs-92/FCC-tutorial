using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed; // esta velocidad se setea en MonsterSpawner

    private Rigidbody2D myBody;


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
