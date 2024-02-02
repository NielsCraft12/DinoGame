using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToSpawn;
    [SerializeField]
    private float timer;

    private Vector3 position = new Vector3(10.33f, -3.44f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(3, 5);
        //Instantiate(objectToSpawn, position, Quaternion.identity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(objectToSpawn, position, Quaternion.identity);
            timer = Random.Range(3, 5);
        }
    }
}
