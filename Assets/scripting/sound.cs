using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class sound : MonoBehaviour
{
    private Sprite soundonimage;
    public Sprite soundoffimage;
    public AudioMixer audioMixer;
    public Button button;
    private bool ison = true;
    public AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        soundonimage = button.image.sprite;
    }

    public void buttonclicked()
    {
        if (ison)
        {
            button.image.sprite = soundoffimage;
            ison = false;
            AudioSource.mute = true;
        }
        else
        {
            button.image.sprite = soundonimage;
            ison = true;
            AudioSource.mute=false;
        }
    }
}
