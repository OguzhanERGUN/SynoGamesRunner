using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    private Vector3 ThirdPerson = new Vector3(-1.89f, 3.57f, 3f);

    private void Start()
    {

    }


    void LateUpdate()
    {
        transform.position = Player.transform.position + ThirdPerson;

    }


}
