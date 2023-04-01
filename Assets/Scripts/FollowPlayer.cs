using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Transform Boss;
    private float xplayer = -2.99f;
    private float yplayer = 3.63f;
    private float zplayer = 4.25f;
    private float xboss = -5.4f;
    private float ybpss = 5.82f;
    private float zboss = 20.03f;

    private Vector3 ThirdPerson;
    private Vector3 LookBoss;

    public Animator animator;

    private void Start()
    {
        ThirdPerson = new Vector3(xplayer, yplayer, zplayer);
        LookBoss = new Vector3(xboss, ybpss, zboss);
    }


    void LateUpdate()
    {
        
        
        if (!animator.GetBool("IsClosedBoss"))
        {
            transform.position = Player.transform.position + ThirdPerson;
        }
        else if (animator.GetBool("IsClosedBoss"))
        {
            transform.position = Boss.transform.position + LookBoss;
        }
    }


}
