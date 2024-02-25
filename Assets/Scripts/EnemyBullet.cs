using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f; // Speed at which the bullet moves
    public float damage = 10f; // Damage the bullet will deal to the player
    public Rigidbody2D rb; // Rigidbody2D component of the bullet
    public GameObject Player;

    public float angle;

    void Start()
    {
        Destroy(gameObject, 2f);
        Player = GameObject.Find("Player");
        Vector2 direction = (Player.transform.position - transform.position).normalized;

        float radvalue = Mathf.Atan2(direction.y, direction.x);
        angle = radvalue * (180 / Mathf.PI);

        transform.Rotate(0f, 0f, angle);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerMovement player = hitInfo.GetComponent<PlayerMovement>(); // Get the PlayerMovement script attached to the collided object

        if (player != null)
        {
            player.TakeDamage(damage); // Call TakeDamage on the PlayerMovement script
            Destroy(gameObject); // Destroy the bullet after applying damage
        }

        // Optionally, destroy the bullet if it hits something other than the player
        // else
        // {
        //     Destroy(gameObject);
        // }
    }
}
