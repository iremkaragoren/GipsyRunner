using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelList", menuName = "ThisGame/Levels/LevelList", order = 1)]
public class LevelList_SO : ScriptableObject
{
    [SerializeField] List<Level_SO> allLevels;

    public Level_SO GetLevelWithIndex(int curretnLevel)
    {
        if(allLevels.Count<=curretnLevel)
            return allLevels[curretnLevel % allLevels.Count];

        return allLevels[curretnLevel];
    }

}
