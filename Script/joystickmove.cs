using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickmove : MonoBehaviour
{
    public Joystick movement_Joystick;
    public float playerSpeed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (movement_Joystick.Direction.y != 0) 
        {
            rb.velocity = new Vector2(movement_Joystick.Direction.x * playerSpeed, movement_Joystick.Direction.y * playerSpeed);

        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
