using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy") || collision.CompareTag("Player"))
        {
            // destruimos a los enemies o al player
            // si llega al limite del mapa
            Destroy(collision.gameObject);
        }
    }
}
