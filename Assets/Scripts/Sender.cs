using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{
    // puede o no recibir paramatros
    public delegate void PlayerDied(bool isAlive);
    public static event PlayerDied playerDiedInfo;

    // ejm => calcular la distancia del player con el enemy
    public delegate float PlayerDistance(Vector3 player, Vector3 target);
    public static event PlayerDistance playerDistanceInfo;

    private float distance = 0;

    // Start is called before the first frame update
    void Start()
    {
        //if(playerDiedInfo != null)
        //{
        //    playerDiedInfo();
        //}

        //ejecutara la func despues de 5 seg
        //Invoke("ExecuteEvent", 5f);
        Invoke(nameof(ExecuteEvent), 5f); // otra forma
    }

    void ExecuteEvent()
    {
        // verificar que alguien este subscrito
        //if (playerDiedInfo != null)
        //{
        //    playerDiedInfo();
        //}

        // otra forma mas simplificada
        playerDiedInfo?.Invoke(true);

        distance = (float)(playerDistanceInfo?.Invoke(new Vector3(1f, 1f, 1f), new Vector3(2f, 1f, 1f)));
        Debug.Log("Distance: " + distance);
    }


}
