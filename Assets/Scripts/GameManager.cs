using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public GameObject completeLevelUI;
    public GameObject Pufferfish;
    public GameObject Cactus;
    public GameObject Penguin;
    public GameObject Pig;
    public GameObject Plant;
    public GameObject George;
    float Delay = 2f;
    void Start() 
    {
        if(PlayerPrefs.GetString("Character") == "Runner")
        {
            Instantiate(Pig, new Vector3(0,1,0), Quaternion.identity);
        }
        else if(PlayerPrefs.GetString("Character") == "Swimmer")
        {
            Instantiate(Pufferfish, new Vector3(0, 1, 0), Quaternion.identity);
        }
        else if (PlayerPrefs.GetString("Character") == "Jumper")
        {
            Instantiate(Penguin, new Vector3(0, 1, 0), Quaternion.identity);
        }
        else if (PlayerPrefs.GetString("Character") == "Flyer")
        {
            Instantiate(Plant, new Vector3(0, 1, 0), Quaternion.identity);
        }
        else if (PlayerPrefs.GetString("Character") == "Climber")
        {
            Instantiate(Cactus, new Vector3(0, 1, 0), Quaternion.identity);
        }
        else if (PlayerPrefs.GetString("Character") == "George")
        {
            Instantiate(George, new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
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
