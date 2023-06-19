using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageUp : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats playerStats = collision.GetComponent<PlayerStats>();
        if(collision.CompareTag("Player"))
        {
            playerStats.attack += 1;
            Destroy(gameObject);
        
        }
    }
}
