using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    bool wasOver;               
    public float boundry = 1;       // boundry sourrounding pixies for the mouse to be in
    public GameObject pixie;        // pixie object
    public float speed = 1f;        // pixie follow speed
    public Transform currentPos;    // starting position
    public Transform playerPos;     // ending position

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 pixiePos = pixie.transform.position;                                // Vector2 that stores the pixies current position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);     // Vector2 that stores the mouses current position in a world point

        // Checked if the mouse is within the bounds of a pixie
        if(mousePos.x >= pixiePos.x - boundry && mousePos.x <= pixiePos.x + boundry && mousePos.y >= pixiePos.y - boundry && mousePos.y <= pixiePos.y + boundry)
        {
            wasOver = true; // sets the variable to true, so that when the mouse leaves the boundry, the pixie will continue to follow the player
        }
     
        // testing to make sure my mousechecks are working
        // Debug.Log("Mouse: " + mousePos + "Pixie: " + pixiePos + wasOver);
        
        if (wasOver)
        {
            //lerp (smoothly transition between) the pixies current position, and the players position with speed
            transform.position = Vector2.Lerp(currentPos.position, playerPos.position, speed * Time.deltaTime);
        }
    }
}
