using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnPoint : MonoBehaviour
{
    public Transform spawnpoint;
    public Transform spawnpointLeft;

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");

        if (moveX < 0)
        {
            // Activate left spawnpoint and deactivate right spawnpoint
            spawnpoint.gameObject.SetActive(false);
            spawnpointLeft.gameObject.SetActive(true);
        }
        if (moveX > 0)
        {
            // Activate right spawnpoint and deactivate left spawnpoint
            spawnpoint.gameObject.SetActive(true);
            spawnpointLeft.gameObject.SetActive(false);
        }
    }
}
