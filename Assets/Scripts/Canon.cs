using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject bullet;
    public float healthPoints = 10.0f;


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
        transform.Rotate(0.0f, 0.0f, -Input.GetAxis("Horizontal") * speed);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "enemy":
                TakeDamage(col.gameObject.GetComponent<Enemy>().damage);
                break;
        }
    }

    private void TakeDamage(float damage)
    {
        healthPoints -= damage;

        if (healthPoints <= 0.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
