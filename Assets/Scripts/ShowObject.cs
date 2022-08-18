using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShowObject : MonoBehaviour
{
    [SerializeField] private GameObject cubit;

    public void ActivateCubit()
    {
        cubit.SetActive(true);
    }

    
    public void OpenDoor()
    {
        Debug.Log("Las puertas del castillo han sido abiertas");
    }

    public void CloseDoors()
    {
        Debug.Log("Las puertas se estan cerrando");
    }
}
