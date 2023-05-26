using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Debug.Log("trigger");
            EventManager.OnCoinTriggered?.Invoke();
            gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}
