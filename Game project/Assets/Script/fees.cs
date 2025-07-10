using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fees : MonoBehaviour
{
    [SerializeField] private GameObject pusher;
    private Vector3 defaultPosition;
    [SerializeField] private float movepowre = 3f;
    // Start is called before the first frame update
    void Start()
    {
        defaultPosition = pusher.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float y = movepowre * Mathf.Sin(Time.time);

        Debug.Log(Mathf.Sin(Time.time));

        pusher.transform.localPosition = new Vector3(0, y, 0) + defaultPosition;
    }
}
