using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject showObject;
    void Start()
    {
        showObject.SetActive(false);
        //GameClearテキストを隠す
    }

    //ゴールに辿り着いてるとGameClearテキストを表示する

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            showObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
