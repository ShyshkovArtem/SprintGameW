using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBackroundMusic : MonoBehaviour
{
    AudioSource audioSource_Bgm;
    // Start is called before the first frame update
    void Start()
    {      
        DontDestroyOnLoad(this.gameObject);
        audioSource_Bgm = GetComponent<AudioSource>();
        audioSource_Bgm.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
