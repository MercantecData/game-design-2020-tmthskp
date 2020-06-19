using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public movement mymovement; //A reference to our PlayerMovement Script

    //This function runs when we hit another object.
    //We get information about the collision and call it "collisinInfo"
    void OnCollisionEnter(Collision collisionInfo)
    {
        //We check if the object we collided with has a tag called "Obstacle"
        if (collisionInfo.collider.tag == "projectile")
        {
            mymovement.enabled = false; //Disable the player movement

            //FindObjectOfType<AudioManager>().Play("PlayerDeath");
            FindObjectOfType<Game_Manager>().EndGame();

        }
    }
}
