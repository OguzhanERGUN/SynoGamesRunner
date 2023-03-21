using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScaleValue : MonoBehaviour
{
    private StrognValue strognValue;
    // Start is called before the first frame update
    void Start()
    {
        strognValue = GetComponent<StrognValue>();
        transform.localScale = new Vector3(2 + (strognValue.countstartvalue * .1f), 2 + (strognValue.countstartvalue * 0.1f), 2 + (strognValue.countstartvalue * 0.1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
