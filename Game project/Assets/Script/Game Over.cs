using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject showObject;
    void Start()
    {
        showObject.SetActive(false);
        //GameOver�e�L�X�g���B��
    }

    //�ޗ��ɗ������GameOver�e�L�X�g��\������
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Dead")
        {
            showObject.SetActive(true);
        }
    }
}
