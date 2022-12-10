using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{

    private void Awake()
    {
        
    }

    // esta func es llamada antes que start y despues de awake
    void OnEnable()
    {
        // se suscribe al evento
        // unity recomienda que se haga aqui
        Sender.playerDiedInfo += PlayerDiedListener;
        Sender.playerDiedInfo += AnotherListener;

        Sender.playerDistanceInfo += CalculateDistance;
    }

    // Start is called before the first frame update
    void Start()
    {
        //// se suscribe al evento
        //Sender.playerDiedInfo += PlayerDiedListener;
    }

    private void OnDisable()
    {
        // para desusbcribirnos
        Sender.playerDiedInfo -= PlayerDiedListener;
        Sender.playerDistanceInfo -= CalculateDistance;
    }

    // como el delgado de sender es void, esta 
    // function tambien es void
    // si el delegado reciviera un parametro 
    // esta func tambien recibiria ese parametro
    void PlayerDiedListener(bool isAlive)
    {
        Debug.Log("Event has called this function to execute: " + isAlive);
    }

    void AnotherListener(bool isAlive)
    {
        Debug.Log("Called from test: " + isAlive);
    }

    float CalculateDistance(Vector3 player, Vector3 target)
    {
        return Vector3.Distance(player, target);
    }
}
