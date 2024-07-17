using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovements movement;
    //called whenever collide with something
    void OnCollisionEnter(Collision collisionInfo) 
    {
        if(collisionInfo.collider.tag == "Obstacle") 
        {
        Debug.Log("dead");
        movement.enabled = false;
        }
        if(collisionInfo.collider.name == "Ground") 
        {
        Debug.Log("off we go");
        }
        
    }
    
}
