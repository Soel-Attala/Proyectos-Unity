using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObject : MonoBehaviour
{
    [SerializeField] private GameObject cubit;

    public void ActivateCubit()
    {
        cubit.SetActive(true);
    }
}
