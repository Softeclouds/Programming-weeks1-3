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
        // Restart t once its bigger than 1 to loop the animation curve
        if (t > 1)
        {
            t = 0;
        }
        // Make the curve affect only the Y axis, to make the pixie flutter up and down
        Vector2 pos = transform.localPosition;
        pos.y = curve.Evaluate(t);
        transform.localPosition = pos;
    }
}
