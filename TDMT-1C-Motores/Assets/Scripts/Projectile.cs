using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D projectileRB;
    void Start()
    {
        projectileRB.velocity = transform.up * speed;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
