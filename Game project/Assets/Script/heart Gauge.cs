using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heateGauge : MonoBehaviour
{
    // Start is called before the first frame update
    //heart��lifepoint��t�^����
    //lifepoint����������heart���B��

    public GameObject heartimage = null;
    public GameObject heartimage2 = null;
    public GameObject heartimage3 = null;
    public ari aristarts = null;

    public void heartview()
    {

        //hitpoint�̒l��1��������heart1�\������
        if (aristarts.hitpoint == 3)
        {
            heartimage.SetActive(true);
            heartimage2.SetActive(true);
            heartimage3.SetActive(true);
        }

        if (aristarts.hitpoint == 1)
        {
            heartimage.SetActive(true);
            heartimage2.SetActive(false);
            heartimage3.SetActive(false);
        }

        if (aristarts.hitpoint == 2)
        {
            heartimage.SetActive(true);
            heartimage2.SetActive(true);
            heartimage3.SetActive(false);
        }
        if (aristarts.hitpoint == 0)
        {
            heartimage.SetActive(false);
            heartimage2.SetActive(false);
            heartimage3.SetActive(false);

        }

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        heartview();
    }
}
