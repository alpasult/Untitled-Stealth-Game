using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField] float gravityStrength;
    Rigidbody2D rb;
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.AddForce(new Vector2(0, -gravityStrength));
    }
}
