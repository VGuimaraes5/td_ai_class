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

    void Start()
    {
        angle = Mathf.Atan2(transform.position.y, transform.position.x);
        Debug.Log(angle);

    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(
           new Vector3(
               Mathf.Cos(angle) * speed * Time.fixedDeltaTime * -1.0f,
               Mathf.Sin(angle) * speed * Time.fixedDeltaTime * -1.0f,
               0.0f
           )
       );
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "bullet":
                TakeDamage();
                break;
            case "canon":
                Destroy(this.gameObject);
                break;
        }
    }

    private void TakeDamage()
    {
        hp -= 1.0f;

        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
