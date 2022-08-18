using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Events : MonoBehaviour
{
    public static event Action exampleEvent;
    public static event Action stormComing;
    public static event Action bearInvasion;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(exampleEvent != null)
            {
                exampleEvent();
                stormComing();
                bearInvasion();
            }
        }
        
        
    }

    
}
