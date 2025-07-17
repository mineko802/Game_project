using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ステージギミック：ダメージ床
/// ブロックに乗ったアクター(またはトリガーに進入したアクター)にダメージを与える
/// </summary>
public class Gimmic_DamageBlock : MonoBehaviour
{
    // 設定項目
    [Header("ダメージ量")]
    public int damage;

    // アクター接触時処理(Trigger)
    private void OnTriggerStay2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;

        if (tag == "Player")
        {
            // アリにダメージを与える
            collision.gameObject.GetComponent<ari>().Damaged(damage);
        }
    }
    // アクター接触時処理(Collider)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag == "Player")
        {
            // アリにダメージを与える
            collision.gameObject.GetComponent<ari>().Damaged(damage);
        }
    }
}

