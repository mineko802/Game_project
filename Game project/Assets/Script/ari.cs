using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ari : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey("a"))
        {
            Vector2 pos = transform.position;
            pos.x -= 0.05f;
            transform.position = pos;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            Vector2 pos = transform.position;
            pos.x += 0.05f;
            transform.position = pos;
        }
        
    }
}
