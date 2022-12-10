using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    [SerializeField]
    private GameObject[] characters;
    // Start is called before the first frame update

    private int _charIndex;

    public int CharIndex
    {
        get { return _charIndex; }
        set { _charIndex = value; }
    }

    void Awake()
    {
        if(instance== null)
        {
            instance = this;
            // se mantenga persistente cuando cambiemos de scene
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        
    }
}
