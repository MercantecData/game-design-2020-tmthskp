using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour
{

    public float speed;
 
    private Transform player;
    private Vector2 target;

    [SerializeField] Transform spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
       
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }

    }


    private void OnTriggerEnter2D(Collider2D hitInfo)
    {

        if (hitInfo.tag != "Boss" && hitInfo.tag != "walls")
        {
            Destroy(this.gameObject);
            
        }

        if (hitInfo.tag == "walls")
        {
            Destroy(this.gameObject);

        }

        if (hitInfo.tag == "Enemy")
        {
            Destroy(this.gameObject);
            //Debug.Log("Enemy Down!!! Get The Flag to Win");
        }

        if (hitInfo.tag == "player")
        {
            Debug.Log("YOU Died!! Try Again");
           
        }

        if (hitInfo.transform.CompareTag("Player"))
            hitInfo.transform.position = spawnPoint.position;
            
    }

    void DestroyProjectile()
    {
        Destroy(this.gameObject);
        
    }


}
