using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject bullet;
    private float moveSpeed = 150.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(Mathf.Sin(transform.rotation.eulerAngles.z));
        transform.Translate(new Vector3 (Mathf.Sin(transform.rotation.eulerAngles.z) * moveSpeed * Time.fixedDeltaTime, Mathf.Cos(transform.rotation.eulerAngles.z) * moveSpeed * Time.fixedDeltaTime , 0.0f));
    }
}
