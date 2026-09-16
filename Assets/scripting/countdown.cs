using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class countdown : MonoBehaviour
{
    public TextMeshProUGUI timert;
    public float remainingtime;
    public gamereload gamereload;
    
    void Update()
    {
        time();
        int minutes = Mathf.FloorToInt(remainingtime / 60);
        int seconds = Mathf.FloorToInt(remainingtime % 60);
        timert.text = string.Format("TIMER:{00:00}:{01:00}", minutes, seconds);
    }
    public void time()
    {
        if (remainingtime > 0)
        {
            remainingtime -= Time.deltaTime;
        }
        else if (remainingtime < 0)
        {
            remainingtime = 0;
            gamereload.setup();
        }
    }
}
