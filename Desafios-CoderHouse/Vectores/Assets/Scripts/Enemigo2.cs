using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
    public Transform playerPositionDos;
    private float enemySpeed = 3f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
        DistanceCheck();
    }

    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position,playerPositionDos.position, enemySpeed * Time.deltaTime);
    }

    void DistanceCheck()
    {
        float dist = Vector3.Distance(transform.position,playerPositionDos.position);
        
        if(dist <= 2)
        {
            enemySpeed = 0;
        }else
        {
            enemySpeed = 3f;
        }
        
    }

     

   


}
