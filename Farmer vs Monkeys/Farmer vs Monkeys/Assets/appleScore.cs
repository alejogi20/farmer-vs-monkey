using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleScore : MonoBehaviour
{
    Rigidbody2D rigid;
    public float lifeSpanAfterCollision;
    float timeAfterColliding;
    bool collided;

    GameObject fruitBasket;

    // Start is called before the first frame update
    void Start()
    {
        fruitBasket = GameObject.Find("fruit basket");
        rigid = GetComponent<Rigidbody2D>();
        timeAfterColliding = 0;
        lifeSpanAfterCollision = 4;
        collided = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (collided && Time.time - timeAfterColliding >= lifeSpanAfterCollision)
        {
            Destroy(gameObject);
            fruitBasket.BroadcastMessage("substractScore_apple", 0, SendMessageOptions.RequireReceiver);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.gameObject.tag == "gatherer")
        {
            Debug.Log("gathered");
            fruitBasket.BroadcastMessage("addScore_apple", 0, SendMessageOptions.RequireReceiver);
            Destroy(gameObject);

        }
        else
        {
            timeAfterColliding = Time.time;
            collided = true;
        }
    }
}
