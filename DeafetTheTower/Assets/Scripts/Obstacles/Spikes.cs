using UnityEngine;

public class Spikes : Obstacles
{

    [SerializeField] int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")   
        {
            collision.gameObject.GetComponent<PlayerManager>().TakeDamage(damage);
        }
    }
}
