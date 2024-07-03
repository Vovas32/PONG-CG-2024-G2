using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D rigidbody2D;
    public KeyCode UpKey;
    public KeyCode DownKey;
    public float speed = 3;
    public float def_speed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        print("Hello from start");

}
    private void Awake()
    {
        def_speed = speed;
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(UpKey) && transform.position.y > - 4)
        {
            rigidbody2D.velocity = Vector2.up * speed;
            
        }
        else if (Input.GetKey(DownKey) && transform.position.y < 4)
        {
            rigidbody2D.velocity = Vector2.down * speed;
         
        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }

     
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
}
