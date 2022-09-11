using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    private Rigidbody _rb;

    public Vector3 spawnPoint;
    public Vector3 startingRotation = new Vector3(0, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Respawn()
    {
        transform.rotation = Quaternion.Euler(startingRotation);
        transform.position = spawnPoint;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -25f)
        {
            Respawn();
        }
    }
}
