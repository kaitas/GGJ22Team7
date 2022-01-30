using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSample : MonoBehaviour
{
    Animator _anim; //Animatorを定義。これが無いと変数操作が出来ない。

    void Start()
    {
        _anim = GetComponent<Animator>(); //制御したいAnimatorを取得。
    }

    public void Anim(string str)
    {
        _anim.SetTrigger(str); //strに入るのはMove,Eat,Copy,Dieの4つ。それぞれ移動,食事,増殖,消滅。
    }

    public void Anim(string str, bool isOn)
    {
        _anim.SetBool(str,isOn); //strに入るのはSleep。isOnがtrueで睡眠開始。falseで睡眠終了。
    }
}
