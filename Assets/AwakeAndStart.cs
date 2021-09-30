using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    // Awake, references between scripts, initialization
    private void Awake()
    {
        Debug.Log("Awake called");
    }
    // Start is called before the first frame update
    // Once script component is enable
    void Start()
    {
        Debug.Log("Start called");
    }

}
