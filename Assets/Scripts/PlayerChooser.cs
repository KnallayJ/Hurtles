using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerChooser : MonoBehaviour
{
    // Start is called before the first frame update

    public void LoadLevel()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene(1);
    }
    public void SetJumper()
    {
        PlayerPrefs.SetFloat("Speed", 0.5f);
        PlayerPrefs.SetFloat("JumpHeight", 1.0f);
        PlayerPrefs.SetFloat("ClimbSpeed", 0.5f);
        PlayerPrefs.SetFloat("SwimSpeed", 0.5f);
        PlayerPrefs.SetFloat("FlightSpeed", 0f);
        PlayerPrefs.SetString("Character","Jumper");
        LoadLevel();
    }
    public void SetRunner()
    {
        PlayerPrefs.SetFloat("Speed", 1.0f);
        PlayerPrefs.SetFloat("JumpHeight", 0.5f);
        PlayerPrefs.SetFloat("ClimbSpeed", 0.5f);
        PlayerPrefs.SetFloat("SwimSpeed", 0.5f);
        PlayerPrefs.SetFloat("FlightSpeed", 0f);
        PlayerPrefs.SetString("Character","Runner");
        LoadLevel();
    }
    public void SetClimber()
    {
        PlayerPrefs.SetFloat("Speed", 0.5f);
        PlayerPrefs.SetFloat("JumpHeight", 0.5f);
        PlayerPrefs.SetFloat("ClimbSpeed", 1.0f);
        PlayerPrefs.SetFloat("SwimSpeed", 0.5f);
        PlayerPrefs.SetFloat("FlightSpeed", 0f);
        PlayerPrefs.SetString("Character","Climber");
        LoadLevel();
    }
    public void SetFlyer()
    {
        PlayerPrefs.SetFloat("Speed", 0.5f);
        PlayerPrefs.SetFloat("JumpHeight", 0.5f);
        PlayerPrefs.SetFloat("ClimbSpeed", 0.5f);
        PlayerPrefs.SetFloat("SwimSpeed", 0.5f);
        PlayerPrefs.SetFloat("FlightSpeed", 1.0f);
        PlayerPrefs.SetString("Character","Flyer");
        LoadLevel();
    }
    public void SetSwimmer()
    {
        PlayerPrefs.SetFloat("Speed", 0.25f);
        PlayerPrefs.SetFloat("JumpHeight", 0.5f);
        PlayerPrefs.SetFloat("ClimbSpeed", 0.5f);
        PlayerPrefs.SetFloat("SwimSpeed", 2.0f);
        PlayerPrefs.SetFloat("FlightSpeed", 0f);
        PlayerPrefs.SetString("Character","Swimmer");
        LoadLevel();
    }
}
