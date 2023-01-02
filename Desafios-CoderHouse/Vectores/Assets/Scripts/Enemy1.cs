using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public Transform playerPosition;

    void Start()
    {
        
    }

    
    void Update()
    {
        LookAtPlayerQuat();
        DistanceCheck();
    }

    void DistanceCheck()
    {
        float dist = Vector3.Distance(transform.position,playerPosition.position);
        Debug.Log("Distancia contra el enemigo: " + dist);
    }

    void LookAtPlayerQuat()
    {
        Quaternion rot = Quaternion.LookRotation(playerPosition.position - transform.position);
        transform.rotation = rot;
        
    }
}   
