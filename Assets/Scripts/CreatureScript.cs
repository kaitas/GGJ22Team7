using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    int coordinate_x;     // x座標
    int coordinate_y;     // y座標
    private string type;  // 生息地：陸、海、空
    private int hp;       // 体力
    private int fullHp; // HPのfull状態を記録するために必要
    private int fullness = 0;　　// 満腹度

    public Creature(int x, int y, string type, int hp)
    {
        this.coordinate_x = x;
        this.coordinate_y = y;
        this.type = type;
        this.hp = hp;
        fullHp = this.hp;
    }

    public int getHp()    // hpの数値を取得
    {
        return hp;
    }

    public int getFullHp()  // fullHpの数値を取得
    {
        return fullHp;
    }

    // public abstract void seek(GameObject target);    //遠くのエージェントを見つける　制作はいったん置いとく。

    public abstract void think();   // 行動を判断する

    public abstract void eat();     // 食べる

    public abstract void idle();    // 止まる

    public abstract void move(GameObject target);   // 動く

    public abstract void sleep();    // 睡眠をする

    public abstract void copy(int x, int y);    // 増殖する

    public  void damage(int d)   // ダメージを受ける
    {
        this.hp = this.hp - d;
    }

    public abstract void die();     // 消滅する
}