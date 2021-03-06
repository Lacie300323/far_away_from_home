﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector2 target;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            destroyProjectile();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(1);
            destroyProjectile();
            Debug.Log("Player Hit!");
            
            
        }
    }

    void destroyProjectile()
    {
        Destroy(gameObject);
    }
}
