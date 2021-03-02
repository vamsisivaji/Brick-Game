using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       float mousepos = Input.mousePosition.x / Screen.width * 16.0f;
       Vector2 Paddlepos = new Vector2(transform.position.x, transform.position.y);
       Paddlepos.x = Mathf.Clamp(mousepos, 1, 12);
       transform.position = Paddlepos;
        
    }
}
