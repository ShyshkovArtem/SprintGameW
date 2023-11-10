using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivate : MonoBehaviour
{
    public GameObject[] firstGroup;
    public GameObject[] secondGroup;
    public ButtonActivate button;
    public Material normal;
    public Material transparent;
    public bool canPush;
    public bool isActive;
    private SoundEffectManager soundEffectManager;

    private void Awake()
    {
        soundEffectManager = FindObjectOfType<SoundEffectManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (canPush) { 
            if (other.CompareTag("Cube") || other.CompareTag("Player"))
            {
            foreach (GameObject first in firstGroup)
                {
                    first.GetComponent<Renderer>().material = normal;
                    first.GetComponent<Collider>().isTrigger = false;
                }
            foreach (GameObject second in secondGroup)
                {
                    second.GetComponent<Renderer>().material = transparent;
                    second.GetComponent<Collider>().isTrigger = true;
                }
            if (isActive)
                {
                    isActive = !isActive;
                    soundEffectManager.PlayButtonPressed();
                }
            
            GetComponent<Renderer>().material = transparent;
            button.GetComponent<Renderer>().material = normal;
            button.canPush = true;
            button.isActive =!isActive;
        }
            
        }

}
}
