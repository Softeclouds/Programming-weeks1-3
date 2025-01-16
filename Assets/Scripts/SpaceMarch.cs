using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMarch : MonoBehaviour
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
        pos.y += speed;

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if (squareInScreenSpace.y < 0 || squareInScreenSpace.y > Screen.height)
        {
            speed = speed * -1;
        }

        transform.position = pos;
    }
}
