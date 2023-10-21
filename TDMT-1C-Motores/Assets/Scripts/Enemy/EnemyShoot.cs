using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private Cannon cannon;

    private float shootTimer = 0f;
    [SerializeField] private float shootInterval;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer += Time.deltaTime;

        if (shootTimer >= shootInterval)
        {
            cannon.Shoot();
            shootTimer = 0f;
        }
    }
}
