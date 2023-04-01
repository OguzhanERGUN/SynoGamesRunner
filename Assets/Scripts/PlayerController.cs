using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalValue;
    public float speed;
    private float BorderXPozitive = 1.20f;
    private float BorderXNegative = -3.00f;
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        #region Borders 
        if (transform.position.x < BorderXNegative)
        {
            transform.position = new Vector3(BorderXNegative, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > BorderXPozitive)
        {
            transform.position = new Vector3(BorderXPozitive, transform.position.y, transform.position.z);

        }
        #endregion
        #region Right Left Movement Controller
        HorizontalValue = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * HorizontalValue);
        #endregion


        if (!animator.GetBool("IsDead") && !animator.GetBool("IsClosedBoss"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
        
    }
}
