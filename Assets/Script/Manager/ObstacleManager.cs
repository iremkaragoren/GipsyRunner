using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    private int obstacleCount = 0;
    public int maxObstacleCount = 3;

    private void OnEnable()
    {
        EventManager.OnObstacleTriggered += HandleObstacleTriggered;
        EventManager.LevelSuccessed += HandleLevelSuccess;
        EventManager.LevelFailed += HandleLevelFailed;
    }

    private void OnDisable()
    {
        EventManager.OnObstacleTriggered -= HandleObstacleTriggered;
        EventManager.LevelSuccessed -= HandleLevelSuccess;
        EventManager.LevelFailed -= HandleLevelFailed;
    }

    private void HandleObstacleTriggered()
    {
        obstacleCount++;

        if (obstacleCount >= maxObstacleCount)
        {
            EventManager.LevelFailed?.Invoke();
        }
    }

    private void HandleLevelSuccess()
    {
        obstacleCount = 0;
    }

    private void HandleLevelFailed()
    {
        obstacleCount = 0;
    }
}
