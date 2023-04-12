using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFightUI : MonoBehaviour
{
    public Animator playerAnim;
    public Canvas bossFightUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerAnim.GetBool("IsClosedBoss"))
        {
            bossFightUI.enabled = true;
        }
        else
        {
            bossFightUI.enabled = false;

        }
    }
}
