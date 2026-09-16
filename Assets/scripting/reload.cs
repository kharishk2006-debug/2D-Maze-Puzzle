using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class reload : MonoBehaviour
{
    public void homen()
    {
        SceneManager.LoadScene("main menu");
        Time.timeScale = 1f;
    }

    public void info()
    {
        SceneManager.LoadScene("info");
    }

    public void share()
    {
        SceneManager.LoadScene("level 1");
    }
}
