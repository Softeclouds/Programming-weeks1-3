using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Circle : MonoBehaviour
{
    public GameObject sprite;
    public Circle circle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spawn();
        }
    }

    void spawn()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject spawnedSprite = Instantiate(sprite, mousePos, Quaternion.identity);
        // Random.ColorHSV;

    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
    }
}
