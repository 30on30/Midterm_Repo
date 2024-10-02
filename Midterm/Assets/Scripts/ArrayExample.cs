using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // Example: An array of integers to store player scores
    public int[] playerScores;

    // Example: An array of GameObjects (can be used for enemies or other objects)
    public GameObject[] enemies;

    void Start()
    {
        // Initialize the playerScores array with 5 elements
        playerScores = new int[5] { 10, 20, 30, 40, 50 };

        // Example: Access and print the first score
        Debug.Log("First player's score: " + playerScores[0]);

        // Iterate over the array and print all scores
        foreach (int score in playerScores)
        {
            Debug.Log("Player Score: " + score);
        }

        // Working with enemies (e.g., disabling them)
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                enemy.SetActive(false); // Disable all enemies
            }
        }
    }
}
