using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonicBearKing : Enemy
{
    void Start()
    {
        Enemy DemonicBearKing = new Enemy();
        DemonicBearKing.healthEnemy = 10000;
        DemonicBearKing.enemySpeed = 4f;
        DemonicBearKing.name = "Samrek";
    }

    public void SpecialAttack()
    {
        Debug.Log("The boss is casting his special skill");
    }
    
    
    public void SpecialAttack2()
    {
            Debug.Log("The boss is casting his final skill");
    }



}
