using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landingTest : MonoBehaviour
{
    public Transform planet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        //ray���΂��Ċp�x�̌덷�𒲂ׂĂ����]���Ă���炵��
        if (Physics.Raycast(transform.position, -transform.up, out hit, float.PositiveInfinity))
        {
            Quaternion q = Quaternion.FromToRotation(transform.up,  hit.normal);
            transform.rotation *= q;
        }

    }
}
