using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    private Vector3 coordinate;
    private string type;
    private int hp;
    private int fullHp; // HP��full��Ԃ��L�^���邽�߂ɕK�v
    private int fullness = 0;

    public Creature(Vector3 coordinate, string type, int hp)
    {
        this.coordinate = coordinate;
        this.type = type;
        this.hp = hp;
        fullHp = this.hp;
    }

    public abstract void seek(GameObject target);   //�F����̂��͂�݂��ĉ������B

    public abstract void think();                   //�F����̂��͂�݂��ĉ������B

    public abstract void eat(GameObject target);    //�F����̂��͂�݂��ĉ������B

    public abstract void move(GameObject target);   //�F����̂��͂�݂��ĉ������B

    public void sleep()
    {
        if(hp != fullHp)
        {
            while (hp != fullHp)
                hp = +1;
        }
    }

    public abstract void copy();                    //�F����̂��͂�݂��ĉ������B

    public void death()
    {
        if (hp == 0)
            Destroy(gameObject);
    }
}
