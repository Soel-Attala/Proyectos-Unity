using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainSize : MonoBehaviour
{

    void Start()
    {
        Events.exampleEvent += IncreaseSize;
        Events.stormComing += StormComing;
        Events.bearInvasion += BearInvasion;
    }

    void Update()
    {
        
    }

    void IncreaseSize()
    {
        transform.localScale = new Vector3(3, 3, 3);
    }


    void StormComing()
    {
        Debug.Log ("The storm is coming look for a safe place");
    }

    void BearInvasion()
    {
        Debug.Log ("The invation has been started");
    }
}
