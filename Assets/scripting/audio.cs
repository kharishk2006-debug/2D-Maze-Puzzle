using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
   public AudioSource audioSource;
    public AudioClip background;
    public VolumeSetting  VolumeSetting;

    public static audio instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
       
    }
    void Start()
    {
        audioSource.clip = background;
        audioSource.Play();
        VolumeSetting.loadvolue();
    }
}
