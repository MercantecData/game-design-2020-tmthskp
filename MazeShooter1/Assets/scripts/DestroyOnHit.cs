﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if(other.tag != "player" && other.tag != "walls") 
        {  
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        
        if(other.tag == "walls")
        {
            Destroy(this.gameObject);
        }
    }

    
}
