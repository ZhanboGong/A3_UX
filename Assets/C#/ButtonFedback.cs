using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFedback : MonoBehaviour
{
    public Button playButton;
    public Sprite playOnImage;
    public Sprite playOffImage;
    public AudioSource clickSound;

    private bool isPlayOn = true;

    void Start()
    {
        playButton.onClick.AddListener(ToggleVolume);
        playButton.image.sprite = playOnImage;
    }

    void ToggleVolume()
    {
        isPlayOn = !isPlayOn;

        if (isPlayOn)
        {
            playButton.image.sprite = playOnImage;
        }
        else
        {
            playButton.image.sprite = playOffImage;
        }

        if (clickSound != null)
        {
            clickSound.Play();
        }
        else
        {
            Debug.LogWarning("Œ¥…Ë÷√µ„ª˜“Ù–ß£°");
        }
    }
}
