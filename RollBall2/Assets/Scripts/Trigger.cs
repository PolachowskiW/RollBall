using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    //Player and Maze objects
    public GameObject Player;
    public GameObject Maze;

    //Sound to be played after player reached the trigger
    public AudioSource WinSound;

    private void OnTriggerEnter(Collider other)
    {
        //When chosen object comes in contact with the trigger it will play set sound, activate Win UI and reset maze and player position to prepare level for when it's next loaded
        WinSound.Play();
        //function links to UIManager class to change 'WinAchieved' variable and activate proper UI canvas
        UIManager.WinAchieved = true;
        Maze.transform.rotation = Quaternion.identity;
        Player.transform.position = PlayerStart.StartPos;
    }
}
