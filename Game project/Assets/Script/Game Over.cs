using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject showObject;
    void Start()
    {
        showObject.SetActive(false);
        //GameOverテキストを隠す
    }

    //奈落に落ちるとGameOverテキストを表示する
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Dead")
        {
            showObject.SetActive(true);
        }
    }
}
