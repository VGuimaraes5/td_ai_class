using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float hp;
    public float damage;
    public float armor;

    private float angle;

    // Start is called before the first frame update
    void Start()
    {
        angle = Mathf.Atan2(transform.position.y, transform.position.x);
        Debug.Log(angle);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float multiplierX = transform.position.x < 0 ? -1.0f : 1.0f;
        float multiplierY = transform.position.y < 0 ? -1.0f : 1.0f;

        transform.Translate(
           new Vector3(
               Mathf.Cos(angle) * speed * Time.fixedDeltaTime * -1.0f,
               Mathf.Sin(angle) * speed * Time.fixedDeltaTime * -1.0f,
               0.0f
           )
       );
    }
}
