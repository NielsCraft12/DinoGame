using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawn_Obstacles : MonoBehaviour
{
    [SerializeField]
   private GameObject objectToSpawn;
    [SerializeField]
    private float timer;
    private GameObject rock = GameObject.FindGameObjectsWithTag("efw");

    private Vector3 position = new Vector3(165.9f, -36f, -7.4f);
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

        if (timer <= 0 ) {
            Instantiate(objectToSpawn, position, Quaternion.identity);
            timer = Random.Range(3, 5);
        }
    }


    if(gameObject.transform.position.x += 1;)


}
