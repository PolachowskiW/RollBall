using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script is used to display current sensitivity set by player to better adjust controls
public class SensitivityReader : MonoBehaviour
{
    //text objects that will be displaying information of current sensitivity for their respectible axis
    public Text SensXread;
    public Text SensZread;


    void Start()
    {
        //Text will take display constant message as well as changing value of currently set sensitivity which is converted from float to string
        SensXread.text = "Sensitivity X: " + MazeControls.SensitivityX.ToString();
        SensZread.text = "Sensitivity Z: " + MazeControls.SensitivityZ.ToString();
    }


    void Update()
    {
        //set of the same instructions as found in the Start function; used to update sensitivity value each frame
        SensXread.text = "Sensitivity X: " + MazeControls.SensitivityX.ToString();
        SensZread.text = "Sensitivity Z: " + MazeControls.SensitivityZ.ToString();
    }
}
