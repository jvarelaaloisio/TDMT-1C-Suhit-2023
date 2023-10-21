using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterShooting : MonoBehaviour
{
    //[SerializeField] private Cannon cannon;
    //[SerializeField] private float shootingInterval;
    private float intervalReset;
    private float _inputValue;

    void Start()
    {
        //intervalReset = shootingInterval;
    }

    void Update()
    {
        //shootingInterval -= Time.deltaTime;

        //if (_inputValue == 1f)
        //{
        //    if (shootingInterval <= 0)
        //    {

        //        //cannon.Shoot();
        //        shootingInterval = intervalReset;
        //    }
        //}
    }

    //public void SetInputPressed(float inputValue)
    //{
    //    _inputValue = inputValue;
    //}
}
