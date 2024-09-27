using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainAmerica : SuperHero
{
    public void LeapAndJump()
    {
        Debug.Log($"is Leap and Jump!");

    }
    public void ThrowShield()
    {
        Debug.Log($"is Trowing Shield!");

    }
    //override
    public override void Move()
    {
        LeapAndJump();
    }
    public override void Attack()
    {
        ThrowShield();
    }
    public override void Start()
    {
        base.Start();
        Move();
        Attack();
    }

}