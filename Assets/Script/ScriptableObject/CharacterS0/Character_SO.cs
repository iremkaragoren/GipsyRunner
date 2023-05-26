using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterVariable", menuName = "ThisGame/Player/CharacterVariable", order = 4)]
public class Character_SO : ScriptableObject
{
    [SerializeField] private Vector3 transformPosition;
    [SerializeField] private int currentGoldAmount;


    public Vector3 TransformPosisiton { get=>transformPosition; set => transformPosition = value; }

    public int CurrentGoldAmount { get => currentGoldAmount; set=> currentGoldAmount = value; } 

}
    

