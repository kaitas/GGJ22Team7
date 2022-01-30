using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRot : MonoBehaviour
{
    Vector2 _mousePos_P;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _mousePos_P = Input.mousePosition;
        }

        if(Input.GetMouseButton(0))
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x - (Input.mousePosition.y - _mousePos_P.y), transform.eulerAngles.y + (Input.mousePosition.x - _mousePos_P.x), 0.0f);
            _mousePos_P = Input.mousePosition;
        }
    }
}
