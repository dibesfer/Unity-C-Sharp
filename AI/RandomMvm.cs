using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMvm : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("getNewDirection", 0, 4f);
    }

    void FixedUpdate()
    {
        rb.velocity = direction* Time.fixedDeltaTime * 100;
    }
    void getNewDirection()
    {
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        direction = new Vector2(x, y);
    }
}

