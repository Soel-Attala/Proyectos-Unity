using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   
    public Transform playerPosition;
    private bool ataque;
    private bool ataque2;
    private float enemySpeed = 3f;
   
    public Animator anim;
    private bool caminar;
    private bool morir;
    public int healthEnemy = 100;
    public float dist;
    public float da�o;
    public float range = 100f;
    public Transform enemyPosition;


    void Start()
    {
        
    }


    void Update()
    {
        LookAtPlayerQuat();
        FollowPlayer();
        Movement();
        Animation();
        Combat();
        Caminar();
        RecibirDa�o();
        Death();
        Vision();

    }

    void LookAtPlayerQuat()
    {
        Quaternion rot = Quaternion.LookRotation(playerPosition.position - transform.position);
        transform.rotation = rot;

    }
    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition.position, enemySpeed * Time.deltaTime);
    }

    void Movement()
    {
        float dist = Vector3.Distance(transform.position, playerPosition.position);
        if (dist <= 4)
        {
            enemySpeed = 0;
        }
        else
        {
            enemySpeed = 3f;
            
        }
    }
    void Animation()
    {
        float dist = Vector3.Distance(transform.position, playerPosition.position);
        if (dist <= 4)
        {
            ataque = true;
        }
        else
        {
            ataque = false;
        }
    }
    void Caminar()
    {
        float dist = Vector3.Distance(transform.position, playerPosition.position);
        if (dist >= 4)
        {
            caminar = true;
        }
        else
        {
            caminar = false;    
        }

        if (caminar == true)
        {
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }
    }

    void Combat()
    {
        if(ataque == true)
        {
            anim.SetBool("ataque", true);
        }
        else
        {
            anim.SetBool("ataque", false );
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.gameObject.name == "Shoe")
        {
            Debug.Log("Golpeaste a tu enemigo 35 de DMG");

            if (healthEnemy <= 100)
            {
                RecibirDa�o();
            }
        }
    }

    void RecibirDa�o()
    {
        if (healthEnemy <= 100)
        {
            da�o = healthEnemy - 35;
        }
    }

    void Death()
    {
        if (healthEnemy <= 0) Destroy(gameObject);
    }

    void Vision()
    {
        RaycastHit hit;
        if (Physics.Raycast(enemyPosition.position, enemyPosition.transform.forward, out hit, range))
        {
            FollowPlayer();
        }
    }




}
