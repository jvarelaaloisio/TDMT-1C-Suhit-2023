using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    [SerializeField] private GameObject actualLevel;
    [SerializeField] private GameObject nextLevel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Cambio de level");
            actualLevel.SetActive(false);
            nextLevel.SetActive(true);
        }
    }
}
