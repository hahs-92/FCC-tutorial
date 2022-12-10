using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // esta func se lanza cuando se selecciona un personaje
    // en unity, el objeto character 1 y 2, tiene agregado 
    // el obejto MainMenuController, quien tiene este script
    public void PlayGame()
    {
        //string clickedObject =  EventSystem.current.currentSelectedGameObject.name;

        // de esta manera solo importamos la clase que necesitamos 
        // obtenemos el nombre del objeco que oprime el boton
        // para el character 1 => 0, 2 => 1
        int selectedCharacter = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        
        GameManager.instance.CharIndex= selectedCharacter;

        // pasamos a otra escena
        // para agregar una scene vamos a buildSettings
        SceneManager.LoadScene("GamePlay");
    }
}
