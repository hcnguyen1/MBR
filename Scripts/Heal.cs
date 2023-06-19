using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats playerStats = collision.GetComponent<PlayerStats>();
        if(collision.CompareTag("Player"))
        {
            if (playerStats.currentHP < playerStats.MaxHP)
            {
                playerStats.currentHP += 1;
                Debug.Log("Heal");
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Max HP");
            }
        }
    }
}
