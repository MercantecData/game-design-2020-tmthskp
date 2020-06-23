using System.Collections;
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
           
        }

        if (hitInfo.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Debug.Log("Enemy Down!!! Get Flag to win");
        }

        if (hitInfo.tag == "Boss")
        {
            Destroy(this.gameObject);
            Debug.Log("BOSS DOWN GREAT!!! Get Flag to Win.");
        }

    }
    
}
