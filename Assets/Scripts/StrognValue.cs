using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StrognValue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI count;
    private int countvalue;
    [SerializeField] public int countstartvalue;
    // Start is called before the first frame update
    void Start()
    {
        if (count == null)
        {
            
        }
        else if (count != null)
        {
            count.text = countstartvalue.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
