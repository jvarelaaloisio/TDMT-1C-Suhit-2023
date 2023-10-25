using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLife : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    //[SerializeField] private GameObject bulletExplosion;

    private float health;

    private void Start()
    {
        health = maxHealth;
    }
    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
