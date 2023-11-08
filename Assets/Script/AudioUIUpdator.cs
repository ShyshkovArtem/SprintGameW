using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioUIUpdator : MonoBehaviour
{
    public Sprite playMusic;
    public Sprite muteMusic;

    private Image musicButtonImage;
    private MusicManager musicManager;


    private void Start()
    {
        musicButtonImage = GetComponent<Image>();
        musicManager = FindObjectOfType<MusicManager>();
        UpdateButtonImage();
        
    }

    public void OnButtonClick()
    {
        musicManager.ToggleMusic();
        UpdateButtonImage();
    }

    private void UpdateButtonImage()
    {
        if (musicManager.IsMusicOn())
        {
            musicButtonImage.sprite = playMusic;
        }
        else
        {
            musicButtonImage.sprite = muteMusic;
        }
    }
}
