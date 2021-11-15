using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public float jf;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (speed*move, rb.velocity.y);
        if(Input.GetButtonDown("Jump")) {
            rb.AddForce(new Vector2(0,jf));
        }
    }
}
