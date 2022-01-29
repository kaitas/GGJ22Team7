// �������������R�[�h Creatures.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public Transform _target; //�ڕW��
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _targetPos = _target.position;
        _targetPos.y = transform.position.y; //�f���̑�n�ł̏�����Ȃ̂�
        transform.LookAt(_target); //xy�����^�[�Q�b�g�������������������

        // ���������߂� 0.5�ȏ�2�ȉ��Ȃ�O�ɐi�ށi�������ړ��ł����̂���j
        // �������E�ɂ��Ă̓n�[�h�R�[�h����ׂ��ł͂Ȃ��̂ł�낵��
        float distance = Vector3.Distance(transform.position, _target.position);
        if (distance <= 2.0f && distance >= 0.5f)
        {
            transform.position += transform.forward * 0.01f;
        }
    }
}
