using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript1 : MonoBehaviour
{

    [SerializeField]float speed = -2.0f;

    void Start()
    {
     
    }


    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time .deltaTime;

        //往復させる
        if ((transform.position.x <= -2.0f) || (transform.position.x >= 2.0f))
        {
            speed *= -1;
        }
     }
}

//敵のゲームオブジェクトの名前には、必ず [Enemy]を入れておく