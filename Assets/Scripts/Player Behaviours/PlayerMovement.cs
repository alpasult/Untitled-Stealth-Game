using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    float movePositionX;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movePositionX = 0;
        if (Input.GetKey(KeyCode.D)) {
            movePositionX += speed;
        }
        if (Input.GetKey(KeyCode.A)) {
            movePositionX -= speed;
        }
        rb.AddForce(new Vector2(movePositionX, 0));
    }
}
