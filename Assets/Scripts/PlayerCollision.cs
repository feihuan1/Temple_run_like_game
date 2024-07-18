using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovements movement;

    //called whenever collide with something
    void OnCollisionEnter(Collision collisionInfo) 
    {
        if(collisionInfo.collider.tag == "Obstacle") 
        {
        movement.enabled = false; 
        // gameManager 
        FindObjectOfType<GameManager>().EndGame();
        }
    }
    
}
