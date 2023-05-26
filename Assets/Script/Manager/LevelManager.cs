using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    [SerializeField]
    private LevelList_SO levelList;
    [SerializeField]
    private Level_SO currentLevel_SO;

    int currentLevel = 0;
    private void Awake()
    {
        EventManager.LevelSuccessed += LevelChange;
        EventManager.LevelFailed -= LevelChange;
    }

    private void OnDisable()
    {
        EventManager.LevelSuccessed -= LevelChange;
        EventManager.LevelFailed -= LevelChange;
    }

    void LevelChange()
    {
        EventManager.LevelSuccessed?.Invoke();
        currentLevel++;
        currentLevel_SO=levelList.GetLevelWithIndex(currentLevel);
    }

    private void Start()
    {
        currentLevel_SO = levelList.GetLevelWithIndex(0);
    }
}
