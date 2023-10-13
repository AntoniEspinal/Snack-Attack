using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public static int total;
    int score = 0;
    public int scoreValue = 0;
    
    void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Collectible")
       {
            score += scoreValue;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
       }
       
    }
}
