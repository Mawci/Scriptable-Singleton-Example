using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Manager : MonoBehaviour
{
//    First, we declare a public static variable to hold the only Instance of the Manager class.
//    Creating a static variable means it can be accessed without creating an instance of the
//    class, which is perfect for a singleton.
    public static Manager Instance;

    public int score = 0;
    public int startingLevel = 1;

    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            Debug.Log("New instance initialized...");
        }
        else if(Instance != this)
        {
            Destroy(this.gameObject);
            Debug.Log("Existing instance found.. deleting self.");
        }
    }

    public void StartGame()
    {
        Debug.Log("New game has started...");
        SceneManager.LoadScene(startingLevel);
    }
}