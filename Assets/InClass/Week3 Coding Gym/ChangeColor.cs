using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public SpriteRenderer sr;
    
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        sr.color = Color.red;
        if(Input.GetMouseButtonDown(0))
        {
          
        }
    }

    void OnMouseExit()
    {
        sr.color = Color.white;
    }

    
}
