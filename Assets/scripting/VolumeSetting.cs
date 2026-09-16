using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolumeSetting : MonoBehaviour
{
    public AudioMixer mymixer;
    public Slider musicslider;
    public AudioSource AudioSource;

    void Start()
    {
        if(PlayerPrefs.HasKey("musicvolume"))
        {
            loadvolue();
        }
        else
        {
            setmusicvolume();
        }
    }
    public void setmusicvolume()
    {
        float volume = musicslider.value;
        mymixer.SetFloat("music", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicvolume", volume);
    }
    public void loadvolue()
    {
        musicslider.value = PlayerPrefs.GetFloat("musicvolume");
        setmusicvolume();
    }
    public void sounded()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
    public void resume()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}  
