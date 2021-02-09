using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(TankData))]

public class TankShooter : MonoBehaviour
{
    public GameObject firePoint;  //Use This Point In Space For Shooting Cannon Balls
    public GameObject cannonBallPrefab;
    private TankData data;

    // Start is called before the first frame update
    void Start()
    {
        data = GetComponent<TankData>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        // Check Cooldown Timer To See If We Can Shoot.

        // Instantiate The Cannon Ball.
        GameObject firedCannonBall = Instantiate(cannonBallPrefab);

        // Propel The Cannon Ball Forward. Use Rigidbody.AddForce()

        // The Cannon Ball Needs Data : Who Fired Cannon Ball, And How Much Damage Will It Do?
        CannonBall cannonBall = firedCannonBall.GetComponent<CannonBall>();
        cannonBall.attacker = this.gameObject;
        cannonBall.attackDamage = data.cannonBallDamage;

    }

  
}
