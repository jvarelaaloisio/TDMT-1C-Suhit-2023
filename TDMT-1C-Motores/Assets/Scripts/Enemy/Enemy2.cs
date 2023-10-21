using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private float shootTimer = 0f;
    [SerializeField] private float shootInterval;
    [SerializeField] private Transform cannon;

    [SerializeField] private GameObject bulletPrefab;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        shootTimer += Time.deltaTime;

        if (shootTimer >= shootInterval)
        {
            Instantiate(bulletPrefab, cannon.position, Quaternion.identity);
            shootTimer = 0f;
        }
    }
}
