using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSample : MonoBehaviour
{
    Animator _anim; //Animator���`�B���ꂪ�����ƕϐ����삪�o���Ȃ��B

    void Start()
    {
        _anim = GetComponent<Animator>(); //���䂵����Animator���擾�B
    }

    public void Anim(string str)
    {
        _anim.SetTrigger(str); //str�ɓ���̂�Move,Eat,Copy,Die��4�B���ꂼ��ړ�,�H��,���B,���ŁB
    }

    public void Anim(string str, bool isOn)
    {
        _anim.SetBool(str,isOn); //str�ɓ���̂�Sleep�BisOn��true�Ő����J�n�Bfalse�Ő����I���B
    }
}
