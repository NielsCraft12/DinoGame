using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_obstacles : MonoBehaviour
{
    [SerializeField]
    float speed = -100f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2 (speed, 0f);
    }
}
