using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;   

public class UnityEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent myTrigger;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Sphere"))
        {

        }
    }
}
