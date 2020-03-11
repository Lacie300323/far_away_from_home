using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D collidedObject = collision.gameObject.GetComponent<Rigidbody2D>(); // Getting the rigidbody of the collided object

        if(collision.CompareTag("Player"))
        {
            CheckpointManager.instance.RestorePlayerToCheckpoint();
            collidedObject.velocity = Vector2.zero; // set movement to 0
            Debug.Log(collision.name + "has left the boundaries");
            
        }
    }
}
