using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public GameObject completeLevelUI;
    float Delay = 2f;
    // Start is called before the first frame update
    public void CompleteLevel()
    {
        Debug.Log("Level Complete!");
        completeLevelUI.SetActive(true);
    }
    public void EndGame() 
    {
        if(GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", Delay);
        }
    }

    void Restart()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(0);
    }
}
