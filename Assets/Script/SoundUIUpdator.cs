using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundUIUpdator : MonoBehaviour
{
    public Sprite soundOn;
    public Sprite soundOff;
    private Image buttonImage;
    private SoundEffectManager soundManager;
    // Start is called before the first frame update
    private void Start()
    {
        buttonImage = GetComponent<Image>();
        soundManager = FindObjectOfType<SoundEffectManager>();
        UpdateSoundButtonImage();
    }

    public void OnSoundButtonClick()
    {
        soundManager.ToggleSounds();
        UpdateSoundButtonImage();
    }

    private void UpdateSoundButtonImage()
    {
        if (soundManager.IsSoundOn())
        {
            buttonImage.sprite = soundOn;
        }
        else
        {
            buttonImage.sprite = soundOff;
        }
    }
}
