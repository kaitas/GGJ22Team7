using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    ViewController viewController;
    [SerializeField] private GameObject _lightObj;
    public float _speed;
    private float scroll = 0f, click = 0f;
    void Start()
    {
        _lightObj = GameObject.Find("Directional Light");//ライトの入れ忘れ防止
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) click = 30;
        scroll = Mathf.Sqrt(Input.mouseScrollDelta.y*Input.mouseScrollDelta.y)*10;
        _lightObj.transform.Rotate(new Vector3(_speed*Time.deltaTime+scroll+click,0,0));
        click = 0;
    }
}
