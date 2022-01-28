using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public static float G = 50.67259f; //万有引力定数の定義
    Rigidbody rocket_body;
    public GameObject rocket; //Unity上でロケットにあたるものをドラッグ＆ドロップ
    Rigidbody planet_body;

    // Start is called before the first frame update
    void Start()
    {
        rocket_body = rocket.GetComponent<Rigidbody>(); //
        planet_body = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec_direction = this.transform.position - rocket.transform.position; //ロケットから見た惑星の位置
        Vector3 Univ_gravity = G * vec_direction.normalized * (planet_body.mass * rocket_body.mass) / (vec_direction.sqrMagnitude); //万有引力の計算
        rocket_body.AddForce(Univ_gravity); //ロケットに万有引力を掛ける
    }
}
