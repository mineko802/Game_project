using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ari : MonoBehaviour
{
    public CameraController cameraController;
    public int hitpoint;
    public float speed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cameraController.SetPosition(transform.position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalKey = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(horizontalKey * speed, rb.velocity.y);

        //cameraController.SetPosition(transform.position);

    }

    public void Damaged(int nun)
    {
        hitpoint = hitpoint - 1;
    }
}
