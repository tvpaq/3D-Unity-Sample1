using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObject : MonoBehaviour
{
    public GameObject myObject;
    void Start()
    {
        gameObject.SetActive(false);
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy: " + myObject.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
