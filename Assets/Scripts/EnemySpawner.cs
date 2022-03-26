using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyOptions;

    public float radio = 20.0f;
    public float spawnDelay = 1.0f;
    private float now = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    { 
        if(now >= spawnDelay)
        {
            SortPosition();
        } else
        {
            now += Time.fixedDeltaTime;
        }
    }

    private void SortPosition ()
    {
        int enemy = Random.Range(0, enemyOptions.Length);
        float posX = Random.Range(-radio, radio);
        float posY = Mathf.Sqrt(Mathf.Pow(radio, 2) - Mathf.Pow(posX, 2));
        if (Random.value > 0.5f)
        {
            posY *= -1.0f;
        }

        Instantiate(enemyOptions[enemy], new Vector3(posX, posY, 0.0f) , Quaternion.identity);

        now = 0.0f;
    }
}
