using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreToAdd;
    private Score gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<Score>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gameManager.UpdateScore(scoreToAdd); 
    }
}
