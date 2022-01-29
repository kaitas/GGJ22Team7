using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    [SerializeField] private GameObject _lightObj;
    public float scroll;
    void Start()
    {
        _lightObj = GameObject.Find("Directional Light");    
    }

    void Update()
    {
        
    }
}
