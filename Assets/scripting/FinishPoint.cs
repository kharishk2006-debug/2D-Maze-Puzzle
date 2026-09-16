using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    public levelcomplet level;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("coin"))
        {
            level.active();
        }
    }
}
