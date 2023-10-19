using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterShooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootingPoint;

    [SerializeField] private float shootingInterval;
    private float intervalReset;

    private float inputValue;

    void Start()
    {
        intervalReset = shootingInterval;
    }

    void Update()
    {
        shootingInterval -= Time.deltaTime;

        if (shootingInterval <= 0) 
        {
            if (inputValue == 1f)
            {
                Shoot();
            }
            shootingInterval = intervalReset;
        }
    }

    public void SetShootValue(InputAction.CallbackContext inputContext)
    {
        inputValue = inputContext.ReadValue<float>();
    }

    void Shoot()
    {
        Instantiate(bullet, shootingPoint.position, Quaternion.identity);
    }
}
