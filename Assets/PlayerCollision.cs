using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movementScript;
    void OnCollisionEnter(Collision collisionInfo)
    {
       if(!collisionInfo.collider.tag.Equals("Ground")) {
           Debug.Log(transform.name + " collided with " + collisionInfo.collider.name);
           movementScript.enabled = false;
       }
    }
}
