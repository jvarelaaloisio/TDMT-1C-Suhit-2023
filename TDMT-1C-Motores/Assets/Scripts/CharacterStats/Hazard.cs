using UnityEngine;

public class Hazard : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private GameObject bulletExplosion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CharacterLife playerHp = collision.gameObject.GetComponent<CharacterLife>();
        playerHp.TakeDamage(damage);
        Instantiate(bulletExplosion, transform.position, transform.rotation);
    }
}
