using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
    
{
    public Rigidbody2D rigitbody2D;
    public Vector2 lastVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rigitbody2D = GetComponent<Rigidbody2D>();
        sendballinrandomdirection();
    }
    public void sendballinrandomdirection() {
        rigitbody2D.velocity = Vector3.zero;
        rigitbody2D.isKinematic = true; 
        transform.position = Vector3.zero;
        rigitbody2D.isKinematic = false;
        rigitbody2D.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized*5f;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            sendballinrandomdirection();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        rigitbody2D.velocity = Vector2.Reflect(rigitbody2D.velocity, collision.contacts[0].normal);
        lastVelocity = rigitbody2D.velocity;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.x > 0)
        {
            Debug.Log("Right Player Wins");
        }
        if (transform.position.x < 0)
        {
            Debug.Log("Left Player Wins");
        }
    }
}
