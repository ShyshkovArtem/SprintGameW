using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class SoundEffectManager : MonoBehaviour
{
    
    [SerializeField] AudioSource soundEffects;
    [SerializeField] AudioClip buttonPressed;
    [SerializeField] AudioClip levelComplete;
    private bool isSoundOn = true;
    // Start is called before the first frame update
    void Start()
    {
        soundEffects = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButtonPressed()
    {
        soundEffects.clip = buttonPressed;
        soundEffects.Play();
    }
    public void PlayLevelComplete()
    {
        soundEffects.clip = levelComplete;
        soundEffects.Play();
    }

    public void ToggleSounds()
    {
        isSoundOn = !isSoundOn;
        if(isSoundOn)
        {
            soundEffects.mute = false;
        }
        else
        {
            soundEffects.mute = true;
        }
    }
    public bool IsSoundOn()
    {
        return isSoundOn;
    }
}
