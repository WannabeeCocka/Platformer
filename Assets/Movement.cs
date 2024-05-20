using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 5f;
    float speedX, speedY;
    public Rigidbody2D rb;
   // physics fungerar

    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    // rb -> gameobject + variabel
    }


    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        rb.velocity = new Vector2(speedX, speedY).normalized * moveSpeed * Time.deltaTime;
        // callar x,y speed
    }

}
   