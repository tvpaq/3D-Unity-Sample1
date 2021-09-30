using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    private float fixedUpdateTimer;
    private float updateTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
        // Called every physics step
        // FixedUpdate intervals are consistent
        // Used for regular updates such as:
        // Adjusting physics (Ridgidbody) objects
    {
        Debug.Log("FixedUpdate time: " + Time.deltaTime);
        //Debug.Log("FixedUpdate Height of object" + transform.position.y);
    }

    // Update is called once per frame
    void Update()
        // useed for regular updates such as:
        // Moving non-physics objects
        // Simple Timers
        // Receiving input

        //update interval times vary
    {
        Debug.Log("Update time: " + Time.deltaTime);
        //Debug.Log("Update Height of object" + transform.position.y);
    }
}
