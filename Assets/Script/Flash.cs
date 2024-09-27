using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : SuperHero
{
    //ท่าไม้ตายยย
    public void SpecialAbility()
    {
        Debug.Log($"Time stop!!!");
    }

    //Move
    public void FlashMove()
    {
        Debug.Log($"Bling");
    }

    //ATK
    public void FlashAttack()
    {
        Debug.Log($"Meteorpunch");
    }

    //Move, Attack override
    public override void Move()
    {
        FlashMove();
    }

    public override void Attack()
    {
        FlashAttack();
    }

    public override void Start()
    {
        base.Start();
        Move();
        Attack();
        SpecialAbility();
    }
}