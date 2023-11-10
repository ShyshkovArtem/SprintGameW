using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicUIUpdator : MonoBehaviour
{
    public Sprite musicOn;
    public Sprite musicOff;

    private Image musicButtonImage;
    private MusicManager musicManager;

    private void Start()
    {
        musicButtonImage = GetComponent<Image>();
        musicManager = FindObjectOfType<MusicManager>();
        UpdateMusicButtonImage();
    }

    public void OnMusicButtonClick()
    {
        musicManager.ToggleMusic();
        UpdateMusicButtonImage();
    }


    private void UpdateMusicButtonImage()
    {
        if (musicManager.IsMusicOn())
        {
            musicButtonImage.sprite = musicOn;
        }
        else
        {
            musicButtonImage.sprite = musicOff;
        }
    }
}
