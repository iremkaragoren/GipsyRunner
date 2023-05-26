using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level_SO", menuName = "ThisGame/Levels/LevelSO", order = 2)]

    public class Level_SO: ScriptableObject
    {
        [SerializeField]
        GameObject levelPrefab;

        public GameObject LevelPrefab => levelPrefab;
    }

