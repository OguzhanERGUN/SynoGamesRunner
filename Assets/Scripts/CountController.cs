using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountController : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI count;
    [SerializeField] public int baslangiccountdegeri;
    public int countsayaci;

    // Start is called before the first frame update
    void Start()
    {
        countsayaci = baslangiccountdegeri;
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
            countsayaci = countsayaci - other.gameObject.GetComponent<StrognValue>().countstartvalue;
            count.text = countsayaci.ToString();
        }
        else if (other.gameObject.tag == "Human")
        {
            Destroy(other.gameObject);
            countsayaci = countsayaci + other.gameObject.GetComponent<StrognValue>().countstartvalue;
            count.text = countsayaci.ToString();
        }
    }

}
