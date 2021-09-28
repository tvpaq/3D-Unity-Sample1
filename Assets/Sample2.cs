using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample2 : MonoBehaviour
{
    public int alpha = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x);
        alpha = 12;

        if (transform.position.y <= 5)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(alpha);
    }
}
