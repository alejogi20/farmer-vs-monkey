using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateFruit : MonoBehaviour
{

    public float fruitInterval = 6.00f;
    public float lastFruitGenerated = 0.0f;
    public float currentTime = 0.0f;
    public GameObject apple;

    List<GameObject> fruits = new List<GameObject>();

    // Update is called once per frame

    void Update()
    {
        currentTime = Time.time;

        if (currentTime >= lastFruitGenerated + fruitInterval)
        {
            //gen fruit at random position
            float fruitPosx = Random.Range(-7.0f, 7.0f);
            float fruitPosy = Random.Range(-0.0f, 4.5f);
            Vector3 fruitPos = new Vector3(fruitPosx, fruitPosy, 0);
            Instantiate(apple, fruitPos, Quaternion.identity);
            //reset time
            lastFruitGenerated = currentTime;
        }

    }
}
