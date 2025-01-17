using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // creating a vector2 that is equal to the mouse position translated from the screen to a world point
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // the objects position is set to the mousePos vector
        transform.position = mousePos; 
    }
}
