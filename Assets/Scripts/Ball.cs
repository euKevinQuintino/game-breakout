using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn() {
        transform.position = Vector2.zero;
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle * speed;
    }
}
