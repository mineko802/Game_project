using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heateGauge : MonoBehaviour
{
    // Start is called before the first frame update
    //heartにlifepointを付与する
    //lifepointが減ったらheartを隠す

    public GameObject heartimage = null;
    public GameObject heartimage2 = null;
    public GameObject heartimage3 = null;
    public ari aristarts = null;

    public void heartview()
    {

        //hitpointの値が1つだったらheart1個表示する
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
