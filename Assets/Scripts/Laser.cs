using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private Transform playerTransform;

    void Start()
    {
        
    }

    void Update()
    {
        LaserMovement();
    }

    private void LaserMovement()
    {
        transform.localPosition += Vector3.up * movementSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            transform.localPosition = new Vector2(playerTransform.position.x, playerTransform.position.y);
        }
        if (collision.gameObject.CompareTag("FirstInvader"))
        {
            Destroy(collision.gameObject);
            GameManager.Instance.IncreaseScore(50);
        }
        if (collision.gameObject.CompareTag("SecondInvader"))
        {
            Destroy(collision.gameObject);
            GameManager.Instance.IncreaseScore(30);
        }
        if (collision.gameObject.CompareTag("ThirdInvader"))
        {
            Destroy(collision.gameObject);
            GameManager.Instance.IncreaseScore(20);
        }
        if (collision.gameObject.CompareTag("MysteryShip"))
        {
            Destroy(collision.gameObject);
            GameManager.Instance.IncreaseScore(100);
        }
    }
}
