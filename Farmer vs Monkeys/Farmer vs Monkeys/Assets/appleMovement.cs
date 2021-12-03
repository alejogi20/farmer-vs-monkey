using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float fallTime;// seconds that the apple will be on the three before dropping
    float birthTime; // time at which the apple was created 
    bool fell;
    // Start is called before the first frame update
    void Start()
    {
        birthTime = Time.time;
        rb = GetComponent<Rigidbody2D>();
        fell = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!fell && Time.time - birthTime >= fallTime) fall();
    }

    void fall()
    {
        rb.WakeUp();
        rb.AddTorque(0.05f);
        fell = true;
    }

} 