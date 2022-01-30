// 生き物を扱うコード Creatures.cs
using UnityEngine;

public class Creature
{
    [SerializeField] GameObject _creature_obj;
    [SerializeField] int _creatureType_int;


    public Transform _target_tra; //目標物




    // Update is called once per frame
    public void Update()
    {
        Vector3 _targetPos = _target_tra.position;
        _targetPos.y = _creature_obj.transform.position.y; //惑星の大地での上方向なので
        _creature_obj.transform.LookAt(_target_tra); //xyだけターゲットがいる方向を向かせる

        // 距離を求めて 0.5以上2以下なら前に進む（ただし移動でいいのか謎）
        // 興味視界についてはハードコードするべきではないのでよろしく
        float distance = Vector3.Distance(_creature_obj.transform.position, _target_tra.position);
        if (distance <= 2.0f && distance >= 0.5f)
        {
            _creature_obj.transform.position += _creature_obj.transform.forward * 0.01f;
        }
    }
}
