using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public int health = 100;
    public Animator trigger;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            trigger.SetBool("InDeath", true);
            Invoke("Die", 1.0f);
            Die();
        }

    }

    void Die()
    {
        trigger.SetTrigger("OnDeath");
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
