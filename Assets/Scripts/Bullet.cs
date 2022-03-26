using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject bullet;
    private float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(
            new Vector3 (
                Mathf.Sin(transform.rotation.z * Mathf.Deg2Rad) * moveSpeed * Time.fixedDeltaTime, 
                Mathf.Cos(transform.rotation.z * Mathf.Deg2Rad) * moveSpeed * Time.fixedDeltaTime , 
                0.0f
            )
        );
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
