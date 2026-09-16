using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private float speed = 6f;
    private Rigidbody2D rb;
    private float horizontal,vertical;
    public VariableJoystick joystick;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = joystick.Horizontal*speed;
        vertical = joystick.Vertical*speed;
        rb.velocity = new Vector2(horizontal,vertical)*speed*Time.deltaTime;
    }
}