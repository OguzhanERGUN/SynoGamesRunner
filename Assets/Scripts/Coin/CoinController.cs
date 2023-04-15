using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private float totalCoin = 0;
    public TextMeshProUGUI totalCoinText;
    private void Start()
    {
        totalCoinText.text = totalCoin.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            totalCoin+=10;
            Destroy(other.gameObject);
            totalCoinText.text = totalCoin.ToString();
        }
    }
}
