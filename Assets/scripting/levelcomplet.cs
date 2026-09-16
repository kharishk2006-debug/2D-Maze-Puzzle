using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcomplet : MonoBehaviour
{
    public void active()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
    public void level2()
    {
        SceneManager.LoadScene("level 2");
        Time.timeScale = 1f;
    }
    public void level3()
    {
        SceneManager.LoadScene("level 3");
        Time.timeScale = 1f;
    }
    public void level4()
    {
        SceneManager.LoadScene("level 4");
        Time.timeScale = 1f;
    }
    public void level5()
    {
        SceneManager.LoadScene("level 5");
        Time.timeScale = 1f;
    }

}
