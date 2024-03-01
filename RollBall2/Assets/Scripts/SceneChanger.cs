using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //Scene that will be loaded after function is called
    public string SceneName;

    //Function that lodes chosen scene when called
    public void SceneChange(string SceneName)
    {
        SceneManager.LoadScene(SceneName);   
    }
}
