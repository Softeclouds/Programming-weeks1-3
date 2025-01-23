using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    bool wasOver; 
    public float boundry = 1;
    public float offset = 1;

    SpriteRenderer sr;
    public GameObject pixie;

    public float speed = 1f;

    public Transform start;
    public Transform end;

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

        if(mousePos.x >= pixiePos.x - boundry && mousePos.x <= pixiePos.x + boundry && mousePos.y >= pixiePos.y - boundry && mousePos.y <= pixiePos.y + boundry)
        {
            wasOver = true;
        }
     

        Debug.Log("Mouse: " + mousePos + "Pixie: " + pixiePos + wasOver);
        
        if (wasOver)
        {
            //lerp pixie pos to player pos
            transform.position = Vector2.Lerp(start.position, end.position, speed * Time.deltaTime);
        }
    }
}
