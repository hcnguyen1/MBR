using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxHP : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats playerStats = collision.GetComponent<PlayerStats>();
        if (collision.CompareTag("Player"))
        {
            playerStats.MaxHP += 1;
            Destroy(gameObject);
        }
    }
}
