using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI count;
    private int countsayaci;

    // Start is called before the first frame update
    void Start()
    {
        countsayaci = 0;
        count.text = countsayaci.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            countsayaci++;
            count.text = countsayaci.ToString();
        }
    }

    
}
