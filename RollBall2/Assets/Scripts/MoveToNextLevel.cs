using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveToNextLevel : MonoBehaviour
{
    public int nextSceneLoad;

    //Instruction that makes sure next scene loaded is the next one in the build settings
    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void GoToNextLevel()
    {
            //function makes sure that we don't try to load scene with incorrect index causing any errors
            if(SceneManager.GetActiveScene().buildIndex == 7) 
            {
                SceneManager.LoadScene("Level Selection");
                Debug.Log("You Completed ALL Levels");
            }
            else
            {
                //Move to next level
                SceneManager.LoadScene(nextSceneLoad);

                //Setting Int for Index
                if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                }
            }
    }
}
