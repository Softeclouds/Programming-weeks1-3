using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixieIdle : MonoBehaviour
{
    public AnimationCurve curve;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }
        Vector2 pos = transform.localPosition;
        pos.y = curve.Evaluate(t);
        transform.localPosition = pos;
    }
}
