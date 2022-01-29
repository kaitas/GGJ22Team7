using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    int coordinate_x;     // x���W
    int coordinate_y;     // y���W
    private string type;  // �����n�F���A�C�A��
    private int hp;       // �̗�
    private int fullHp; // HP��full��Ԃ��L�^���邽�߂ɕK�v
    private int fullness = 0;�@�@// �����x

    public Creature(int x, int y, string type, int hp)
    {
        this.coordinate_x = x;
        this.coordinate_y = y;
        this.type = type;
        this.hp = hp;
        fullHp = this.hp;
    }

    public int getHp()    // hp�̐��l���擾
    {
        return hp;
    }

    public int getFullHp()  // fullHp�̐��l���擾
    {
        return fullHp;
    }

    // public abstract void seek(GameObject target);    //�����̃G�[�W�F���g��������@����͂�������u���Ƃ��B

    public abstract void think();   // �s���𔻒f����

    public abstract void eat();     // �H�ׂ�

    public abstract void idle();    // �~�܂�

    public abstract void move(GameObject target);   // ����

    public abstract void sleep();    // ����������

    public abstract void copy(int x, int y);    // ���B����

    public  void damage(int d)   // �_���[�W���󂯂�
    {
        this.hp = this.hp - d;
    }

    public abstract void die();     // ���ł���
}