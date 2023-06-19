using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int attack = 1;
    public int defense = 1;
    public int MaxHP= 3;
    public int currentHP = 3;

    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            currentHP -= 1;
        }
        if(currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    public int GetAttack()
    {
        return attack;
    }


}
