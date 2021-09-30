using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyAndGetButton : MonoBehaviour
{
   
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
            
        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(new Vector3(0, 5, 0));
        }
    }
}
