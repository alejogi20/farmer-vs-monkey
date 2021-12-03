using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries2D : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectHeight;
    private float objectWidth;

    // Start is called before the first frame update

    public void set_screen_bounds_and_object_dimensions(float _objectWidth, float _objectHeight)
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = _objectWidth;
        objectHeight = _objectHeight;
    }

    public void check()
    {
        Vector2 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x + (objectWidth / 2), screenBounds.x * -1.0f - (objectWidth / 2)); //screen coordinates are inverse so that the second argument is the minimum
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + (objectHeight / 2), screenBounds.y * -1.0f - (objectHeight / 2)); // this one is unnecesary as the player is moving horizontally only
        transform.position = viewPos;
    }
}
