using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arijump : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float JumpPower = 0;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
        }
    }
}
