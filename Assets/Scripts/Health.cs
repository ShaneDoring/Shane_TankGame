using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth=5;
    public int maxHealth=5;

    public void TakeDamage(Attack attackData)
    {
        currentHealth -= attackData.attackDamage;

        //Check To See If We Die
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        throw new NotImplementedException();
    }
}
