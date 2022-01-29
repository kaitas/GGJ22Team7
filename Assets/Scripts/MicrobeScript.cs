using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrobeScript : Creature
{
    // GameObject Microbe = Microbe;   // cope()に使う　微生物のオブジェクトを登録する必要がある

    public MicrobeScript(int x, int y, string type, int hp) : base(x, y, type, 100) { }

    public override void think()   // 行動を判断する
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

    public override void idle()  // 留まる
    {
        // アニメーションを起動する
    }

    public override void move(GameObject target) { }  // 動く

    public override void sleep() { }  // 睡眠をする

    public override void copy(int x, int y)    // 増殖する
    {
        // 同じオブジェクトを生成する
    }

    public override void die()
    {
        Destroy(gameObject);
        // アニメーションを起動する
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
