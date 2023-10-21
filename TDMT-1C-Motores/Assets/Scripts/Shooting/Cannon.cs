using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform cannonPoint;
    [SerializeField] private AudioSource cannonClip;
    void Start()
    {

    }

    void Update()
    {
        
    }

    public void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, cannonPoint.position, Quaternion.identity);
        cannonClip.Play();
        var bulletMovement = bulletPrefab.GetComponent<CharacterMovement>();
        bulletMovement.SetDirection(cannonPoint.up);
    }
}
