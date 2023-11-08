using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource audioSource_Bgm;
    private bool isMusicOn = true;
    // Start is called before the first frame update
    void Start()
    {      
        audioSource_Bgm = GetComponent<AudioSource>();
        audioSource_Bgm.Play();
        audioSource_Bgm.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void ToggleMusic()
    {
        isMusicOn = !isMusicOn;
        if (isMusicOn)
        {
            audioSource_Bgm.mute = false;
        }
        else
        {
            audioSource_Bgm.mute = true;
        }
    }
    public bool IsMusicOn()
    {
        return isMusicOn;
    }
}
