using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class SoundEffectManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] AudioSource audioSource_Finish;
    private bool IsPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource_Finish = GetComponent<AudioSource>();
        Debug.Log(player.tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayLevelFinish()
    {
        IsPlaying = !IsPlaying;
        audioSource_Finish.Play();
        IsPlaying = !IsPlaying;
    }

    public bool IsPLaying()
    {
        return IsPlaying;
    }
}
