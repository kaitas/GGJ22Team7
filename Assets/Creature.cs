using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    //�l���̈ʒu
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 preyPos = target.position;
        //y�����͐����Ɍ�������
        preyPos.y = transform.position.y;
        //�l���̂ق�������
        transform.LookAt(target);

        float distance = Vector3.Distance(transform.position, target.position);
        if (distance <= 2.0f && distance >= 0.5f)
        {
            transform.position += transform.forward * 0.01f;
        }
    }
}
