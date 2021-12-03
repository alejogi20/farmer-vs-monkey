using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour
{
    public Vector2 hSpeed = new Vector2(0.10f, 0.0f);
    public Rigidbody2D rb;
    public Boundaries2D bounds;
    public Vector2 aceleracion = new Vector2(0.40f, 0.0f);
    private Vector3 screenBounds;
    private float objectWidth;
    public float score;
    public GameObject scoreText;

    void Start()
    {
        score = 0;
        scoreText = GetComponent<GameObject>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        bounds = GetComponent<Boundaries2D>();
        rb = GetComponent<Rigidbody2D>();
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x;
    }
    
    void FixedUpdate()
    {
        // Check if the screen is being touched and move accordingly 
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); //check the last touch
            TouchPhase phase_1 = touch.phase;
            if (phase_1 != TouchPhase.Ended)
            {
                if (rb.velocity == Vector2.zero || Input.touchCount == 1)
                {
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    touchPosition.z = 0f; // we set this so that we don't set the object to the camera's z coordinate

                    //if the touch is at the right screen side 
                    if (touchPosition.x > 0.0f)
                    {
                       hSpeed += aceleracion;
                        rb.velocity = hSpeed * Time.deltaTime;
                        Debug.Log("right");
                    }
                    else if (touchPosition.x < 0.0f)
                    {    //left screen side 
                        rb.velocity = (hSpeed * -1.0f) * Time.deltaTime;

                        Debug.Log("left");
                    }
                }

            }
            else
            {
                Debug.Log("0 ended");
            }

            if (transform.position.x >= screenBounds.x - (objectWidth / 2) && rb.velocity.x > 0)
            {
                Vector2 fixedPos = new Vector2(screenBounds.x - (objectWidth / 2), transform.position.y);
                rb.MovePosition(fixedPos);
            }

            if (transform.position.x <= screenBounds.x * (-1.0f) + (objectWidth / 2) && rb.velocity.x < 0)
            {
                Vector2 fixedPos = new Vector2(screenBounds.x * (-1.0f) + (objectWidth / 2), transform.position.y);
                rb.MovePosition(fixedPos);
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
    
    void alimentarALosMorochos(){
    	int PerroCalientes = 1000;
    	
    	int barrigaDejavier = 0;
    	
    	int barrigadelotro = 1;
    	
    	    	barrigaDejavier += PerroCalientes/2;
	    	barrigadelotro += PerroCalientes/2;
	    	
    	
    }
}
