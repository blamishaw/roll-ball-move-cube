using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTokenBehaviour : MonoBehaviour
{
    public Vector3 start;

    public Vector3 end;

    public float speed;

    public int nextLevelInSceneBuilder;
    
 

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(start, end, Mathf.PingPong(Time.time * speed, 1));
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(nextLevelInSceneBuilder);

        }
    }
}

