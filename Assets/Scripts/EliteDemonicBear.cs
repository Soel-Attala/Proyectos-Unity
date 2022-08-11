using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliteDemonicBear : MonoBehaviour
{
    
    void Start()
    {
        //Elite Demonic Bear
        Enemy EliteDemonicBear = new Enemy();
        EliteDemonicBear.healthEnemy = 100;
        EliteDemonicBear.name = "Demonic Bear";
        EliteDemonicBear.enemySpeed = 3f;

        //Demonic Bear King
        DemonicBearKing DemonicBearKing = new DemonicBearKing();
        DemonicBearKing.SpecialAttack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
