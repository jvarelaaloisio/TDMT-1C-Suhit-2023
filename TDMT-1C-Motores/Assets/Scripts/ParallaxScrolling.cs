using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{
    [SerializeField] private float parallaxSpeed; //velocidad a que se movera el fondo

    private float spriteHeight; //variable para setear la altura del background
    private Vector3 startPos; //variable para setear la posicion de reseto

    void Start()
    {
        startPos = transform.position; //la posicion inicial es 0, 0, 0.
        spriteHeight = GetComponent<SpriteRenderer>().bounds.size.y; //la altura sera el tamaño en Y del sprite de este objeto
    }

    void Update()
    {
        BackgroundMovement();
        ResetBackgroundPosition();
    }

    private void BackgroundMovement()
    {
        transform.Translate(Vector3.down * parallaxSpeed * Time.deltaTime);
    }

    private void ResetBackgroundPosition()
    {
        if (transform.position.y < startPos.y - spriteHeight)
        {
            transform.position = startPos;
        }
    }
}
