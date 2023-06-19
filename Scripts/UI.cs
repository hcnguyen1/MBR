using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI statUI;
    PlayerStats playerStats;


    void Start()
    {
        playerStats = FindObjectOfType<PlayerStats>();
    }

    void Update()
    {
        statUI.text = "HP: " + playerStats.currentHP + "/" + playerStats.MaxHP +
            "\nDamage: " + playerStats.attack +
            "\nDefense: " + playerStats.defense +
            "\nGun: ";

    }
}
