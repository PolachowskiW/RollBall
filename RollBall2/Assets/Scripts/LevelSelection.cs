using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    //Button array for all level selection buttons
    public Button[] lvlButtons;

    void Start()
    {
        //int used to verify current scene number as seen in build settings
        int levelAt = PlayerPrefs.GetInt("levelAt", 2); 

        //instruction checking if player unlocked another level based on the difference between current scene index and other scenes index
        //number 2 is added, because scenes with index 0 and 1 are respectively "menu" and "Level selection"
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            //if player completes level number 1, level number 2 will be unlocked and other levels will remain locked unless next available is completed
            if (i + 2 > levelAt)
                lvlButtons[i].interactable = false;
        }
    }

}
