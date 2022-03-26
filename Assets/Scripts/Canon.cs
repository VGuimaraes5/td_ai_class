using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0.0f, 0.0f, -Input.GetAxis ("Horizontal") * speed);
    }
}
