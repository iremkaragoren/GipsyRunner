using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInstantiate : MonoBehaviour
{
    [SerializeField]
    public LevelList_SO levelList_SO;
    
    GameObject level;
  
    int currentLevelIndex = -1;

    public void Start()
    {
        LevelInst();
    }
    private void Awake()
    {
        EventManager.LevelSuccessed += LevelInst;
        EventManager.LevelFailed += LevelReload;
    }

    private void OnDisable()
    {
        EventManager.LevelSuccessed -= LevelInst;
        EventManager.LevelFailed -= LevelReload;
    }

   
    private void LevelInst()
    {
        currentLevelIndex++;
        if(level)
            Destroy(level);
        level = Instantiate(levelList_SO.GetLevelWithIndex(currentLevelIndex).LevelPrefab, Vector3.zero, Quaternion.identity);
    }

    private void LevelReload()
    {
        if (level)
            Destroy(level);
        level = Instantiate(levelList_SO.GetLevelWithIndex(currentLevelIndex).LevelPrefab, Vector3.zero, Quaternion.identity);
    }

   
}
