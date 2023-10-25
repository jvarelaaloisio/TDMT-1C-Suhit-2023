using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLife : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject actualLevel;


    [SerializeField] private float maxHealth;
    private float health;

    private void Start()
    {
        health = maxHealth;
    }
    public void TakeDamage(float damage)
    {
        health -= damage;

        if (gameObject.CompareTag("Player") && health <= 0)
        {
            menu.SetActive(true);
            actualLevel.SetActive(false);
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
