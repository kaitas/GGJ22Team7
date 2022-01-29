using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    [SerializeField] private GameObject _lightObj;
    void Start()
    {
        _lightObj = GameObject.Find("Directional Light");    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
