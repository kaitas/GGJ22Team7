using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrobeScript : Creature
{
    // GameObject Microbe = Microbe;   // cope()�Ɏg���@�������̃I�u�W�F�N�g��o�^����K�v������

    public MicrobeScript(int x, int y, string type, int hp) : base(x, y, type, 100) { }

    public override void think()   // �s���𔻒f����
    {
        if (IsSpace(x, y + 1) == true)
            copy(x, y + 1);
        else if (IsSpace(x - 1, y) == true)
            copy(x - 1, y);
        else if (IsSpace(x + 1, y) == true)
            copy(x + 1, y);
        else if (IsSpace(x, y - 1) == true)
            copy(x, y - 1);
        else if (getHp != 0)
            damage(1);
        else if (getHp == 1)
            die();
    }

    public override void eat(){}

    public override void idle()  // ���܂�
    {
        // �A�j���[�V�������N������
    }

    public override void move(GameObject target) { }  // ����

    public override void sleep() { }  // ����������

    public override void copy(int x, int y)    // ���B����
    {
        // �����I�u�W�F�N�g�𐶐�����
    }

    public override void die()
    {
        Destroy(gameObject);
        // �A�j���[�V�������N������
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
