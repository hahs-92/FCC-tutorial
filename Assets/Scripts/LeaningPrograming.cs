using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaningPrograming : MonoBehaviour
{

    // Getting components
    private Transform myTransform;
    private Rigidbody2D myBody;
    private BoxCollider2D myCollider;


    // Awake is the fisrt fuction that is called
    private void Awake()
    {
        // inicializar variables
    }

    // 2nd function called
    public void OnEnable()
    {
        
    }

    // 3rd function called
    // Start is called before the first frame update
    void Start()
    {
        //print("Hi there");
        //Debug.Log("Hi from Debug¡");

        // para utilizar la coroutina se utiliza StartCoroutina
        // StartCoroutine(ExecuteSomething(2f));

        myTransform= transform;
        transform.position = new Vector3(10, 10, 0);

        myBody= GetComponent<Rigidbody2D>();
        myBody.gravityScale = 2f;

        myCollider= GetComponent<BoxCollider2D>();
        myCollider.isTrigger = true;
       
    }

    // coroutine
    IEnumerator ExecuteSomething(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("something is executed¡");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
