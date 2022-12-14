using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private Vector3 temPos;

    [SerializeField]
    private float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        Debug.Log("the selected character is: " + GameManager.instance.CharIndex);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void LateUpdate()
    {
        // si el player fue destruido
        // es igual a player == null
        if(!player)
        {
            return;
        }

        temPos = transform.position;
        temPos.x = player.position.x;

        if(temPos.x < minX)
        {
            temPos.x = minX;
        }

        if(temPos.x > maxX)
        {
            temPos.x = maxX;
        }

        transform.position = temPos;
    }
}
