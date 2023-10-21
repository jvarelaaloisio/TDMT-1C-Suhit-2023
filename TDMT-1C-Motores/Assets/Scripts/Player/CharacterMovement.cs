using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float xMin = -4f;
    [SerializeField] private float xMax = 4f;
    [SerializeField] private float yMin = -7f;
    [SerializeField] private float yMax = 7f;
    [SerializeField] private float speed;

    public Vector2 _direction;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + new Vector3(_direction.x, _direction.y) * (speed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), Mathf.Clamp(transform.position.y, yMin, yMax), 0);
    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }
}
