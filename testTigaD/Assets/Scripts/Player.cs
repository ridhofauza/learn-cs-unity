using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed;
    float xPosition;
    float zPosition;
    float yPosition;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetMouseButtonDown(0))
        // {
        //     Destroy(gameObject);
        // }
        if(yPosition > 0) {
            yPosition--;
        } else {
            yPosition=0;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            yPosition = 20;
        }

        xPosition = Input.GetAxis("Horizontal");
        zPosition = Input.GetAxis("Vertical");
        rb.AddForce(xPosition*moveSpeed, yPosition, zPosition*moveSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }

}
