using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    private Vector3 coordinate;
    private string type;
    private int hp;
    private int fullHp; // HPのfull状態を記録するために必要
    private int fullness = 0;

    public Creature(Vector3 coordinate, string type, int hp)
    {
        this.coordinate = coordinate;
        this.type = type;
        this.hp = hp;
        fullHp = this.hp;
    }

    public abstract void seek(GameObject target);   //皆さんのお力を貸して下さい。

    public abstract void think();                   //皆さんのお力を貸して下さい。

    public abstract void eat(GameObject target);    //皆さんのお力を貸して下さい。

    public abstract void move(GameObject target);   //皆さんのお力を貸して下さい。

    public void sleep()
    {
        if(hp != fullHp)
        {
            while (hp != fullHp)
                hp = +1;
        }
    }

    public abstract void copy();                    //皆さんのお力を貸して下さい。

    public void death()
    {
        if (hp == 0)
            Destroy(gameObject);
    }
}
