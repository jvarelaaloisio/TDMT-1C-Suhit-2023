using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float xMin;
    [SerializeField] private float xMax;
    [SerializeField] private float yMin;
    [SerializeField] private float yMax;
    [SerializeField] private float speed;

    private Vector2 inputValue;

    void Start()
    {
        
    }

    void Update()
    {
        MoveCharacter();
    }

    public void SetMoveValue(InputAction.CallbackContext inputContext)
    {
        inputValue = inputContext.ReadValue<Vector2>();
    }

    void MoveCharacter()
    {
        transform.position = transform.position + new Vector3(inputValue.x, inputValue.y) * speed * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), Mathf.Clamp(transform.position.y, yMin, yMax), 0);
    }
}
