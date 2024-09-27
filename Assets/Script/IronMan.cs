using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMan : SuperHero
{
    public void Fly()
    {
        Debug.Log($" is Flying!");
    }
    public void ShootLaser()
    {
        Debug.Log($"is Shooting Lasers!");
    }
    public override void Move()
    {
        Fly();
    }
    public override void Attack()
    {
        ShootLaser();
    }
    public override void Start()
    {
        base.Start();
        Move();
        Attack();
    }
}