using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invaders : MonoBehaviour
{    
    void Start()
    {
        
    }

    void Update()
    {
        InvadersKilled();
    }

    private void InvadersKilled()
    {
        if(transform.childCount == 0)
        {
            GameManager.Instance.GameOver();
        }
    }
}
