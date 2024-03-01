using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //variables responsible for activation of proper UI canvas when proper function is called
    public static bool GamePaused = false;
    public static bool SetsOn = false;  
    public static bool WinAchieved = false;

    //Collection of UI canvases
    public GameObject PauseUI;
    public GameObject InGameUI;
    public GameObject SettingsUI;
    public GameObject WinUI;

    void Start()
    {
        //At the very start only In-Game UI will be active to allow player to play as soon as level is loaded
        InGameUI.SetActive(true);
        PauseUI.SetActive(false);
        SettingsUI.SetActive(false);
        WinUI.SetActive(false);
    }
   
    private void Update()
    {
        //Update function checks which UI canvas should be currently active
        if (GamePaused)
        {
            Pause();
            
        }
        else if (SetsOn)
        {
            SettingsOn();
           
        }
        else if (WinAchieved)
        {
            Win();
        }
        else
        {
            Resume();
            
        }
    }

    //If this function is called, In-Game UI is activated and time scale is set to 1 to allow player to play
    public void Resume()
    {
        //Disabling UIs that should be hidden at given time
        PauseUI.SetActive(false);
        SettingsUI.SetActive(false);
        InGameUI.SetActive(true);
        //setting time scale to either pause the game or let it update so player can continue to play
        Time.timeScale = 1f;
        //changing values that are conditions to activate proper UI canvases
        GamePaused = false;
        SetsOn = false;
        WinAchieved = false;
    }

    //If this function is called, Pause UI is activated and time scale is set to 0 to stop the game; This ui lets player navigate through settings UI, go back to level selection and to pause the game
    public void Pause()
    {
        PauseUI.SetActive(true);
        SettingsUI.SetActive(false);
        InGameUI.SetActive(false);
        Time.timeScale = 0f;
        GamePaused = true;
        SetsOn = false;
        WinAchieved = false;
    }

    //If this function is called, Settings UI is activated and time scale is set to 0 to stop the game; This UI lets player set volume and sensitivity
    public void SettingsOn()
    {
        PauseUI.SetActive(false);
        SettingsUI.SetActive(true);
        InGameUI.SetActive(false);
        Time.timeScale = 0f;
        GamePaused = false;
        SetsOn = true;
        WinAchieved = false;
    }

    //If this function is called, Win UI is activated and time scale is set to 0 to stop the game; This Ui lets player go to next level or to level Selection scene
    public void Win()
    {
        PauseUI.SetActive(false);
        SettingsUI.SetActive(false);
        InGameUI.SetActive(false);
        WinUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = false;
        SetsOn = false;
        WinAchieved = true;
    }
}
