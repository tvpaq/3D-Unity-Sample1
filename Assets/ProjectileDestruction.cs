using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestruction : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, 3.5f);
    }
}
