using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public int health = 1;
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
        Destroy(gameObject);
    }
}
