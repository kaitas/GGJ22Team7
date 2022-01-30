// �������������R�[�h Creatures.cs
using UnityEngine;

public class Creature
{
    [SerializeField] GameObject _creature_obj;
    [SerializeField] int _creatureType_int;


    public Transform _target_tra; //�ڕW��




    // Update is called once per frame
    public void Update()
    {
        Vector3 _targetPos = _target_tra.position;
        _targetPos.y = _creature_obj.transform.position.y; //�f���̑�n�ł̏�����Ȃ̂�
        _creature_obj.transform.LookAt(_target_tra); //xy�����^�[�Q�b�g�������������������

        // ���������߂� 0.5�ȏ�2�ȉ��Ȃ�O�ɐi�ށi�������ړ��ł����̂���j
        // �������E�ɂ��Ă̓n�[�h�R�[�h����ׂ��ł͂Ȃ��̂ł�낵��
        float distance = Vector3.Distance(_creature_obj.transform.position, _target_tra.position);
        if (distance <= 2.0f && distance >= 0.5f)
        {
            _creature_obj.transform.position += _creature_obj.transform.forward * 0.01f;
        }
    }
}
