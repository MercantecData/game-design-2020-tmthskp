﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{

    public GameObject Particle_Enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
       
        if(hitInfo.tag != "player" && hitInfo.tag != "walls") 
        {  
            Destroy(this.gameObject);
            Destroy(hitInfo.gameObject);
        }
        
        if(hitInfo.tag == "walls")
        {
            Destroy(this.gameObject);
            FindObjectOfType<AudioManager>().Play("HitWall"); // ShootSound

        }

        if (hitInfo.tag == "Enemy")
        {
            Destroy(this.gameObject);
            FindObjectOfType<AudioManager>().Play("EnemyHit"); // ShootSound
            Debug.Log("Enemy Down!!! Get Flag to win");
            Instantiate(Particle_Enemy, transform.position, Quaternion.identity);

        }

        if (hitInfo.tag == "Boss")
        {
            Destroy(this.gameObject);
            FindObjectOfType<AudioManager>().Play("EnemyHit"); // ShootSound
            Debug.Log("BOSS DOWN GREAT!!! Get Flag to Win.");
            Instantiate(Particle_Enemy, transform.position, Quaternion.identity);
        }

    }
    
}
