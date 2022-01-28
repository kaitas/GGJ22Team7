using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchTarget : MonoBehaviour
{
    public string searchTag;//�T�m�������I�u�W�F�N�g�̃^�O
    public float followSpeed;//�I�u�W�F�N�g�֌��������x
    Rigidbody my_rb;
    bool followTarget;
    Vector3 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        followTarget = false;
        my_rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(followTarget)
        {
            Vector3 followVec = (targetPos - transform.position);//����I�u�W�F�N�g�ւ̌������擾
            followVec.Normalize();//���K��
            my_rb.AddForce(followVec * followSpeed);//�ړ�
        }
        else
        {
            Vector3 randomVec = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
            Debug.Log(randomVec);
            my_rb.AddForce(randomVec * followSpeed);//�ړ�
        }
    }

    void OnTriggerStay(Collider other)//�I�u�W�F�N�g���͈͓��ɂ��鎞
    {
        if (other.gameObject.tag == searchTag)
        {
            followTarget = true;
            targetPos = other.gameObject.transform.position;//����I�u�W�F�N�g�̈ʒu���擾
        }
    }

    void OnTriggerExit(Collider other)//�I�u�W�F�N�g���͈͓����疳���Ȃ�����
    {
        if (other.gameObject.tag == searchTag)
        {
            followTarget = false;
        }
    }
}
