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
        Animation();
        Combat();
        Walk();
        TakeDmg();
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

        if(dist > 25)
        {
            enemySpeed = 3f;
        }
        else
        {
            enemySpeed = 0;
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
    void Walk()
    {
        float dist = Vector3.Distance(transform.position, playerPosition.position);
        if (dist >= 4)
        {
            caminar = true;
            anim.SetBool("Walking", true);
        }
        else
        {
            caminar = false;
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
                TakeDmg();
            }
        }
    }

    void TakeDmg()
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
            Movement();
        }
    }




}
