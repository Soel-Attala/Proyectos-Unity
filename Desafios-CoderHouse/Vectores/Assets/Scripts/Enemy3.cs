using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public Transform playerPositionTres;
    private float enemySpeed = 3f;

    public int elegirModo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DistanceCheck();

        if(elegirModo == 1)
        {
            LookAtPlayerQuat();
        } else
        {
            FollowPlayer();
        }
    }

    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position,playerPositionTres.position, enemySpeed * Time.deltaTime);
    }

    void DistanceCheck()
    {
        float dist = Vector3.Distance(transform.position,playerPositionTres.position);
        
        if(dist <= 3)
        {
            enemySpeed = 0;
        }else
        {
            enemySpeed = 3f;
        }
       
    }

     void LookAtPlayerQuat()
    {
        Quaternion rot = Quaternion.LookRotation(playerPositionTres.position - transform.position);
        transform.rotation = rot;
        
    }

   

}
