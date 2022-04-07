using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void FixedUpdate()
    {
        transform.Translate(
            new Vector3(
                Mathf.Sin(transform.rotation.z * Mathf.Deg2Rad) * moveSpeed * Time.fixedDeltaTime,
                Mathf.Cos(transform.rotation.z * Mathf.Deg2Rad) * moveSpeed * Time.fixedDeltaTime,
                0.0f
            )
        );
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
