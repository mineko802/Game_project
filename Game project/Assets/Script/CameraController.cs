using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 basePos;

    public void SetPosition(Vector2 targetPos)
    {
        basePos = targetPos;
    }

    private void FixedUpdate()
    {
        Vector3 pos = transform.localPosition;
        pos.x = basePos.x + 2.5f;
        pos.y = basePos.y + 1.5f;

        transform.localPosition = Vector3.Lerp(transform.localPosition, pos, 0.08f);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
