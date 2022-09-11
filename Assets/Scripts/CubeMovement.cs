using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public float speed;

    public Vector3 start;

    public Vector3 end;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        // Using Mathf.PingPong inspired by StackOverflow
        transform.position = Vector3.Lerp(start, end, Mathf.PingPong(Time.time * speed, 1));
    }

    
}
