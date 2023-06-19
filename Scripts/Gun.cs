using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnpoint;
    public Transform spawnpointLeft;

    public int bulletSpeed = 5;
    public float cooldown = 1;
    bool canShoot = true;

    public GameObject bulletSpawnPointLeft;
    public GameObject bulletSpawnPointRight;

    private void Update()
    {
        Transform activeSpawnpoint = spawnpoint;
        float moveX = Input.GetAxis("Horizontal");
        // Which spawnpoint depending on direction

        if (bulletSpawnPointLeft.gameObject.activeSelf && 
            !bulletSpawnPointRight.gameObject.activeSelf) // bulletSpawnPointLeft active and starting position
        {
            activeSpawnpoint = spawnpointLeft;
        }
        else if (bulletSpawnPointRight.gameObject.activeSelf) // bulletSpawnPoint active
        {
            activeSpawnpoint = spawnpoint;
        }


        // Shooting
        if (Input.GetButtonDown("Fire1") && canShoot)
        {

            Shoot(activeSpawnpoint);
            canShoot = false; // Disable shooting temporarily
            Invoke("EnableShooting", cooldown); // Enable shooting after cooldown time
        }
    }

    public void Shoot(Transform spawnpoint)
    {
        GameObject projectile = Instantiate(bullet, spawnpoint.position, spawnpoint.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 shootDirection = (mousePosition - spawnpoint.position).normalized;

        Vector2 bulletVelocity = shootDirection * bulletSpeed;
        bulletVelocity = bulletVelocity.normalized * bulletSpeed;

        rb.velocity = bulletVelocity;
    }
    private void EnableShooting()
    {
        canShoot = true; // Enable shooting
    }
}
