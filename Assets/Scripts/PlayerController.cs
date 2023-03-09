using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalValue;
    public float speed;
    private float BorderX = 1.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
        if (transform.position.x < -BorderX)
        {
            transform.position = new Vector3(-BorderX,transform.position.y,transform.position.z);
        }
        else if(transform.position.x > BorderX)
        {
            transform.position = new Vector3(BorderX, transform.position.y, transform.position.z);

        }
        HorizontalValue = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * HorizontalValue);
        transform.Translate(Vector3.forward * Time.deltaTime * speed );
    }
}
