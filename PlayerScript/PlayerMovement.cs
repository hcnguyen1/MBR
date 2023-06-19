using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5f;
    public Transform gunPrefab;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Horizontal movement
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * movementSpeed, rb.velocity.y);

        // Vertical movement
        float moveY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, moveY * movementSpeed);

        // Flips the sprite
        if(moveX < 0)
        {
            spriteRenderer.flipX = true;
            // Offset the initial position of the gun prefab to the bottom left
            // gun position inside Player
            Vector3 gunPosition = gunPrefab.localPosition;
            gunPosition.x = -Mathf.Abs(gunPosition.x);
            gunPrefab.localPosition = gunPosition;

        }
        if(moveX > 0)
        {
            spriteRenderer.flipX = false;
            // Restore the original position of the gun prefab
            Vector3 gunPosition = gunPrefab.localPosition;
            gunPosition.x = Mathf.Abs(gunPosition.x);
            gunPrefab.localPosition = gunPosition;
        }
    }
}
