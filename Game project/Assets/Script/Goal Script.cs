using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject showObject;
    void Start()
    {
        showObject.SetActive(false);
        //GameClear�e�L�X�g���B��
    }

    //�S�[���ɒH�蒅���Ă��GameClear�e�L�X�g��\������

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            showObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
