using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour
{
    [SerializeField]

    public TextMeshProUGUI text;
    private int coinCount;
    

    private void OnEnable()
    {
        EventManager.OnCoinTriggered += UpdateCoinCount;
        EventManager.LevelFailed+= StartingCoin;
        EventManager.LevelSuccessed += StartingCoin;
    }



    private void OnDisable()
    {
        EventManager.OnCoinTriggered -= UpdateCoinCount;
        EventManager.LevelFailed -= StartingCoin;
        EventManager.LevelSuccessed -= StartingCoin;
    }


    private void StartingCoin()
    {
        coinCount = 0;  
        text.text=coinCount.ToString();

    }

    private void UpdateCoinCount()
    {

        coinCount++;
        text.text=coinCount.ToString();

    }


}








   
