using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(new Vector2(speed, 0));
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(new Vector2(-speed, 0));
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(new Vector2(speed, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(new Vector2(-speed, 0));
        }
    }
}
