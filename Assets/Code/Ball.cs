using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    bool start=false;
    Rigidbody2D rb;
    public Transform paddle;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        GameStart();
        if (Input.GetMouseButtonDown(0)&&start==false)
        {
            rb.velocity = new Vector2(0, 25);
            //rb.AddForce(new Vector2(0, 100));
            start = true;
        }
    }
    void GameStart()
    {
        if(start==false)
        {
            transform.position = new Vector2(paddle.position.x, paddle.position.y + 0.5f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="brick")
        {
            Destroy(collision.gameObject);
        }
    }
}
