using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript2 : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 0.1f;
    [SerializeField] private float _width = 2.0f;
    private Vector3 _originalPosition;

    void Start()
    {
        _originalPosition = transform.position;
    }


    void Update()
    {
        transform.position += new Vector3(_moveSpeed, 0, 0) * Time.deltaTime;

        //往復させる
        if (transform.position.x < _originalPosition.x - _width ||
            transform.position.x > _originalPosition.x + _width)
        {
            _moveSpeed *= -1;
        }
    }
}

//敵のゲームオブジェクトの名前には、必ず [Enemy]を入れておく