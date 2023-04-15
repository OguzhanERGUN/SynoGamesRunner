using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BossController : MonoBehaviour
{
    public Animator animator;
    public bool goCheck;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("IsClosedBoss", true);
        }
    }


    public void Go()
    {
        animator.SetBool("IsClosedBoss", false);

    }


    public void TryAgain()
    {
        SceneManager.LoadScene(0);
    }
}
