using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetTotalCoin : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI totalCoinText;
    // Start is called before the first frame update
    void Start()
    {
        SetTotalCoinValue();
    }
    
    private void SetTotalCoinValue()
    {
        totalCoinText.text = PlayerPrefs.GetFloat("TotalCoinValue").ToString();
    }

}
