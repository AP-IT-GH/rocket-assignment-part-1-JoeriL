using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public Rigidbody spaceschip;
    // Start is called before the first frame update
    void Start()
    {
        spaceschip = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            spaceschip.velocity += transform.up * 0.3f;
        } 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-0.5f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0.5f, 0, 0);
        }
           
    }
}
