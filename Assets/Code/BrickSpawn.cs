using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawn : MonoBehaviour
{
    public GameObject brick;
    public float offset;
    public GameObject[] brickArray;
    // Start is called before the first frame update
    float x;
    float y;
    void Start()
    {
        brickArray = new GameObject[10];
        x = transform.position.x+1.2f;
        y = 4.0f;
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < brickArray.Length; i++)
            {
                transform.position = new Vector3(x, y, 0);
                brickArray[i] = Instantiate(brick, transform.position, Quaternion.identity);
                x = x + 1.2f;
            }
            int randValue = Random.Range(0, brickArray.Length);
            brickArray[randValue].tag = "SuperBrick";
            x = x - 12.0f;
            y=y-0.5f;
        }
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}