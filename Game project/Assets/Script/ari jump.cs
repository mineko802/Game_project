using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arijump : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float JumpPower = 0;
    private bool isJumping =false;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            _rb.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor")) {
            isJumping = false;
        }
    }
}
