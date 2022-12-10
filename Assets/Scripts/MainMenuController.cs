using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // esta func se lanza cuando se selecciona un personaje
    // en unity, el objeto character 1 y 2, tiene agregado 
    // el obejto MainMenuController, quien tiene este script
    public void PlayGame()
    {
        // pasamos a otra escena
       // para agregar una scene vamos a buildSettings
        SceneManager.LoadScene("GamePlay");
    }


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
