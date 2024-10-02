using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Static instance of GameManager
    public static GameManager instance;

    // Example of a game setting stored in the singleton
    public int score;

    private void Awake()
    {
        // Check if instance already exists
        if (instance == null)
        {
            // If not, set instance to this
            instance = this;
        }
        else if (instance != this)
        {
            // Destroy this object if a GameManager instance already exists
            Destroy(gameObject);
        }

        // Make GameManager persistent across scenes
        DontDestroyOnLoad(gameObject);
    }
}
