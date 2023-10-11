using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public static int total;
    public int score;
    
    void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Collectible")
       {
            score += 1;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
       }
       
    }
}
