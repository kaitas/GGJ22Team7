// 生き物を扱うコード Creatures.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public Transform _target; //目標物
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 _targetPos = _target.position;
        _targetPos.y = transform.position.y; //惑星の大地での上方向なので
        transform.LookAt(_target); //xyだけターゲットがいる方向を向かせる

        // 距離を求めて 0.5以上2以下なら前に進む（ただし移動でいいのか謎）
        // 興味視界についてはハードコードするべきではないのでよろしく
        float distance = Vector3.Distance(transform.position, _target.position);
        if (distance <= 2.0f && distance >= 0.5f)
        {
            transform.position += transform.forward * 0.01f;
        }
    }
}
