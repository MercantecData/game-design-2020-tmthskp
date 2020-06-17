using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour

{

    public float speed = 10;
    private string currentState = "patrol";
    public Transform waypoint1;
    public Transform waypoint2;
    public Transform waypoint3;
    public float range = 15;
    private Transform nextWaypoint;
    public LayerMask mask;
    // Start is called before the first frame update
    void Start()
    {
       nextWaypoint = waypoint1;
    }

    // Update is called once per frame
    void Update()
    { 
        
        
        if(currentState == "patrol")
        {
          
            Vector2 nextPosition = Vector2.MoveTowards(transform.position, nextWaypoint.position, Time.deltaTime * speed);
            transform.position = nextPosition;
            if (transform.position == nextWaypoint.position)
            {
                if (nextWaypoint == waypoint1)
                {
                    nextWaypoint = waypoint2;
                }

                else if(nextWaypoint == waypoint2)
                {
                    nextWaypoint = waypoint3;
                }

                else
                {
                    nextWaypoint = waypoint1;
                }
            }
            else if (TargetAquired()) 
            {
                currentState = "Attack";
            }

        }
      
        else if (currentState == "Attack") 
        {
            if (!TargetAquired())
            {
                currentState = "patrol";
            }
        }

    }

    bool TargetAquired()
    {
        GameObject targetGO = GameObject.FindGameObjectWithTag("Player");
        bool inRange = false;
        bool inVision = false;



        if (Vector2.Distance(targetGO.transform.position, transform.position) < range)
        {
            inRange = true;
        }



        var linecast = Physics2D.Linecast(transform.position, targetGO.transform.position, mask);
        if (linecast.transform == null)
        {
            inVision = true;
        }

        return inRange && inVision;
    }
}
