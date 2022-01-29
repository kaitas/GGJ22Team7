using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    [SerializeField] private GameObject _lightObj;
    public float _speed;
    void Start()
    {
        _lightObj = GameObject.Find("Directional Light");  
    }

    void Update()
    {
        _lightObj.transform.Rotate(new Vector3(_speed*Time.deltaTime, 0, 0));
    }
}
