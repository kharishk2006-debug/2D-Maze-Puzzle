using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    public void loaded()
    {
        SceneManager.LoadScene("level 1");
    }
    public void level2()
    {
        SceneManager.LoadScene("level 2");
    }
}
