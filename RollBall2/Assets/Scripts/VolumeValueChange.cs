using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeValueChange : MonoBehaviour {

    //Audio source that will be controlled by the slider
    private AudioSource audioSrc;

    //At the start volume from audio source will be set to 1
    private float musicVolume = 1f;

	
	void Start () 
    {
        //assigning the audio source
        audioSrc = GetComponent<AudioSource>();
	}

	void Update () 
    {
        //volume of the audio source will be updated to the value set with slider
        audioSrc.volume = musicVolume;
	}
    public void SetVolume(float vol)
    {
        //function using dynamic float to change volume using slider
        musicVolume = vol;
    }
}
