using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    //Šl•¨‚ÌˆÊ’u
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 preyPos = target.position;
        //y‚¾‚¯‚Í…•½‚ÉŒü‚©‚¹‚é
        preyPos.y = transform.position.y;
        //Šl•¨‚Ì‚Ù‚¤‚ğŒü‚­
        transform.LookAt(target);

        float distance = Vector3.Distance(transform.position, target.position);
        if (distance <= 2.0f && distance >= 0.5f)
        {
            transform.position += transform.forward * 0.01f;
        }
    }
}
