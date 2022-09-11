using System.Collections;
using System.Collections.Generic;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using ADBannerView = UnityEngine.iOS.ADBannerView;

public class SphereMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rb;
    public float movementSpeed = 10f;
    public float jumpHeight = 600f;

    private Vector3 target;
    private Vector3 movementVector;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void FixedUpdate()
    {
        _rb.AddForce(movementVector);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_rb.position.y < -20)
        {
            ReloadScene();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            ReloadScene();
        }
        

        float x = 0f;
        float z = 0f;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            z -= movementSpeed;
            
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            z += movementSpeed;
            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x += movementSpeed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            x -= movementSpeed;
            
        }

        movementVector = new Vector3(x, transform.position.y, z);

    }
}
