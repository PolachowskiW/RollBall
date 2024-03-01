using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSwitch : MonoBehaviour
{
    //function that will switch off Win UI after changing the scene or loading next level to avoid activating it while loading level
    public void SwitchOff()
    {
        //link to UIManager class that changes value of condition activating Win UI
        UIManager.WinAchieved = false;
    }
}
