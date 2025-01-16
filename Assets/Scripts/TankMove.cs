using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class TankMove : MonoBehaviour
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

            Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed;

            Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);
        }

        transform.position = pos;
    }
}
