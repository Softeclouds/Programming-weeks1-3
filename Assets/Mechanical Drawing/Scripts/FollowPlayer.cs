using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    public bool followPlayer = false;
    bool isOver;


    SpriteRenderer sr;
    public GameObject pixie;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pixiePos = pixie.transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(mousePos.x >= pixiePos.x - 1 && mousePos.x <= pixiePos.x +1 && mousePos.y >= pixiePos.y - 1 && mousePos.y <= pixiePos.y + 1)
        {
            isOver = true;
        }
        else
        {
            isOver = false;
        }

        Debug.Log("Mouse: " + mousePos + "Pixie: " + pixiePos + isOver);
        
        if (isOver)
        {
            followPlayer = true;
        }
    }
}
