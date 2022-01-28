using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchTarget : MonoBehaviour
{
    public string searchTag;//探知したいオブジェクトのタグ
    public float followSpeed;//オブジェクトへ向かう速度
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
            Vector3 followVec = (targetPos - transform.position);//相手オブジェクトへの向きを取得
            followVec.Normalize();//正規化
            my_rb.AddForce(followVec * followSpeed);//移動
        }
        else
        {
            Vector3 randomVec = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
            Debug.Log(randomVec);
            my_rb.AddForce(randomVec * followSpeed);//移動
        }
    }

    void OnTriggerStay(Collider other)//オブジェクトが範囲内にある時
    {
        if (other.gameObject.tag == searchTag)
        {
            followTarget = true;
            targetPos = other.gameObject.transform.position;//相手オブジェクトの位置を取得
        }
    }

    void OnTriggerExit(Collider other)//オブジェクトが範囲内から無くなった時
    {
        if (other.gameObject.tag == searchTag)
        {
            followTarget = false;
        }
    }
}
