using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{

    bool isTriggered = false;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && !isTriggered)
        {
            Debug.Log(gameObject.name);
            isTriggered = true;
            EventManager.OnObstacleTriggered?.Invoke();
        }
    }
}
