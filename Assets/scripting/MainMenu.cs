using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void menu()
    {
        SceneManager.LoadScene("level 1");
        Time.timeScale = 1f;
    }
}
