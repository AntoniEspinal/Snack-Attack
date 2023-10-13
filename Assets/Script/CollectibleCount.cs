using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollectibleCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    public List<GameObject> target; 
    private float spawnRate = 1.0f;
    public GameObject titleScreen; 
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton; 



    public void StartGame(int difficulty)
    {
        StartCoroutine(SpawnTarget());
        isGameActive = true;
        titleScreen.SetActive(false);
        spawnRate /= difficulty;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    IEnumerator SpawnTarget()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, target.Count);
            Instantiate(target[index]);
        }
    }

    
}
