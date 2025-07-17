using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �X�e�[�W�M�~�b�N�F�_���[�W��
/// �u���b�N�ɏ�����A�N�^�[(�܂��̓g���K�[�ɐi�������A�N�^�[)�Ƀ_���[�W��^����
/// </summary>
public class Gimmic_DamageBlock : MonoBehaviour
{
    // �ݒ荀��
    [Header("�_���[�W��")]
    public int damage;

    // �A�N�^�[�ڐG������(Trigger)
    private void OnTriggerStay2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;

        if (tag == "Player")
        {
            // �A���Ƀ_���[�W��^����
            collision.gameObject.GetComponent<ari>().Damaged(damage);
        }
    }
    // �A�N�^�[�ڐG������(Collider)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag == "Player")
        {
            // �A���Ƀ_���[�W��^����
            collision.gameObject.GetComponent<ari>().Damaged(damage);
        }
    }
}

