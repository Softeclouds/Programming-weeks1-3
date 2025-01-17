using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed;
        }

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);
        transform.position = pos;
    }
}
