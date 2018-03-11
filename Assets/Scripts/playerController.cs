using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float moveHoriz = Input.GetAxis("Horizontal");

        float moveVert = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHoriz, moveVert);

        movement = movement * Time.deltaTime * 60 * speed;

        rb2d.velocity = movement;
    }
}