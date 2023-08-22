using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CoinController : MonoBehaviour
{
    private float totalCoin = 0;
    public TextMeshProUGUI totalCoinText;
    private void Start()
    {
        totalCoin = PlayerPrefs.GetFloat("TotalCoinValue");
        totalCoinText.text = totalCoin.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            totalCoin+=10;
            SetTotalCoin("TotalCoinValue", totalCoin);
            Destroy(other.gameObject);
            totalCoinText.text = totalCoin.ToString();
        }
    }



    private void SetTotalCoin(string key, float score)
    {
        PlayerPrefs.SetFloat(key, score);
    }
}
