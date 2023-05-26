using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager:MonoBehaviour
{
    [SerializeField]
    private Transform gipsy;
    [SerializeField]
    private Transform spawnPoint;


    private void OnEnable()
    {
        EventManager.LevelSuccessed += GipsyStart;
        EventManager.LevelFailed += GipsyStart;


    }

    private void OnDisable()
    {
        EventManager.LevelSuccessed -= GipsyStart;
        EventManager.LevelFailed -= GipsyStart;
    }

    private void GipsyStart()
    {
        gipsy.position=spawnPoint.position;
    }
}
