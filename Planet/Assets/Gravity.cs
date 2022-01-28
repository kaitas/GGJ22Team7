using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public static float G = 50.67259f; //���L���͒萔�̒�`
    Rigidbody rocket_body;
    public GameObject rocket; //Unity��Ń��P�b�g�ɂ�������̂��h���b�O���h���b�v
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
        Vector3 vec_direction = this.transform.position - rocket.transform.position; //���P�b�g���猩���f���̈ʒu
        Vector3 Univ_gravity = G * vec_direction.normalized * (planet_body.mass * rocket_body.mass) / (vec_direction.sqrMagnitude); //���L���͂̌v�Z
        rocket_body.AddForce(Univ_gravity); //���P�b�g�ɖ��L���͂��|����
    }
}
