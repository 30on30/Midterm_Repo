using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    // A list of integers (can be scores, levels, etc.)
    public List<int> playerScores = new List<int>();

    // A list of GameObjects (e.g., enemies)
    public List<GameObject> enemies = new List<GameObject>();

    void Start()
    {
        // Add some player scores to the list
        playerScores.Add(10);
        playerScores.Add(20);
        playerScores.Add(30);

        // Example: Access and print the first score
        Debug.Log("First player's score: " + playerScores[0]);

        // Iterate over the list and print all scores
        foreach (int score in playerScores)
        {
            Debug.Log("Player Score: " + score);
        }

        // Check the size of the list
        Debug.Log("Number of players: " + playerScores.Count);

        // Adding GameObjects to the enemy list (these can be enemy prefabs)
        // You would typically assign these via the inspector, but here's how to add them programmatically:
        GameObject enemy1 = new GameObject("Enemy1");
        GameObject enemy2 = new GameObject("Enemy2");

        enemies.Add(enemy1);
        enemies.Add(enemy2);

        // Example: Access and disable the first enemy
        if (enemies.Count > 0 && enemies[0] != null)
        {
            enemies[0].SetActive(false);
            Debug.Log("First enemy disabled");
        }

        // Removing an enemy from the list
        enemies.Remove(enemy1);
        Debug.Log("Enemy removed. Remaining enemies: " + enemies.Count);
    }
}
