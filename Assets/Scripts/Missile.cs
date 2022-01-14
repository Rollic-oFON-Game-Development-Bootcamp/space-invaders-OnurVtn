using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        MissileMovement();
    }

    private void MissileMovement()
    {
        transform.localPosition += Vector3.down * movementSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
