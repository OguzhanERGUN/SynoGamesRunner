using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountController : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI count;
    [SerializeField] public int baslangiccountdegeri;
    private Animator Animator;
    public int countsayaci;
    private Transform transformplayer;


    // Start is called before the first frame update
    void Start()
    {
        countsayaci = baslangiccountdegeri;
        count.text = countsayaci.ToString();
        Animator = GetComponent<Animator>();
        transformplayer = GetComponent<Transform>();
    }


    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boss" || other.gameObject.tag == "Wall" && !Animator.GetBool("IsDead"))
        {
            countsayaci = countsayaci - other.gameObject.GetComponent<StrognValue>().countstartvalue;
            count.text = countsayaci.ToString();
        }
        else if (other.gameObject.tag == "Human" && !Animator.GetBool("IsDead"))
        {
            Destroy(other.gameObject);

            countsayaci = countsayaci + other.gameObject.GetComponent<StrognValue>().countstartvalue;


            count.text = countsayaci.ToString();
        }

        if (countsayaci <= 45)
        {
            transformplayer.localScale = new Vector3(2 + (countsayaci * 0.1f), 2 + (countsayaci * 0.1f), 2 + (countsayaci * 0.1f));
        }
        if (countsayaci <= 0)
        {
            Animator.SetBool("IsDead", true);
            count.text = "0";
        }
    }

}
